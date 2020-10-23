using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Currencies.Dto;

namespace Currencies.Implementations
{
    public class DbStorage
    {
        private readonly CurrencyContext _dbContext;
        private readonly IMapper _mapper;

        public DbStorage(CurrencyContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        #region Currencies
        public IEnumerable<CurrencyDto> GetCurrencies()
        {
            var currencies = _dbContext.Currencies.AsQueryable();
            var result = _mapper.Map<List<CurrencyDto>>(currencies.ToList());
            return result;
        }

        public CurrencyDto GetCurrency(Guid id)
        {
            var currency = _dbContext.Currencies
                .Include(x => x.ExchangeRates)
                .FirstOrDefault(x => x.Id == id);
            if (currency != null)
                currency.ExchangeRates = currency.ExchangeRates.OrderByDescending(x => x.Date).ToList();
            var result = _mapper.Map<CurrencyDto>(currency);
            return result;
        }

        public Guid AddNewCurrency(CurrencyDto currencyDto)
        {
            var result = Guid.Empty;
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var currencyId = AddCurrency(currencyDto);

                    if (currencyDto.ExchangeRates != null)
                    {
                        foreach (var rate in currencyDto.ExchangeRates)
                        {
                            AddExchangeRateToCurrency(rate, currencyId);
                        }
                    }

                    result = currencyId;
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }

            return result;
        }

        public bool EditCurrency(CurrencyDto currencyDto)
        {
            if (currencyDto.Id == null)
                return false;

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                var dbCurrency = _dbContext.Currencies.FirstOrDefault(x => x.Id == currencyDto.Id);
                if (dbCurrency == null)
                {
                    throw new Exception($"Currency with id {currencyDto.Id} not found");
                }

                try
                {
                    if (!string.IsNullOrEmpty(currencyDto.Name))
                    {
                        dbCurrency.Name = currencyDto.Name;
                    }
                    if (!string.IsNullOrEmpty(currencyDto.Code))
                    {
                        dbCurrency.Code = currencyDto.Code;
                    }

                    _dbContext.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool DeleteCurrency(Guid currencyId)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var currency = _dbContext.Currencies
                        .Include(x => x.ExchangeRates)
                        .FirstOrDefault(x => x.Id == currencyId);

                    if (currency != null)
                    {
                        _dbContext.RemoveRange(currency.ExchangeRates);
                        _dbContext.Remove(currency);
                        _dbContext.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        #endregion

        #region ExchangeRates
        public ExchangeRateDto GetExchangeRate(Guid id)
        {
            var rate = _dbContext.ExchangeRates.FirstOrDefault(x => x.Id == id);
            var result = _mapper.Map<ExchangeRateDto>(rate);
            return result;
        }

        public Guid AddNewExchangeRate(ExchangeRateDto exchangeRateDto, Guid currencyId)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var id = AddExchangeRateToCurrency(exchangeRateDto, currencyId);
                    transaction.Commit();
                    return id;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return Guid.Empty;
                }
            }
        }

        public bool EditExchangeRate(ExchangeRateDto exchangeRateDto)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var rate = _dbContext.ExchangeRates.FirstOrDefault(x => x.Id == exchangeRateDto.Id);
                    if (rate != null)
                    {
                        rate.Rate = exchangeRateDto.Rate;
                        rate.Date = exchangeRateDto.Date;
                        rate.UnitsNumber = exchangeRateDto.UnitsNumber;
                        _dbContext.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool DeleteExchangeRateFromCurrency(Guid currencyId, Guid exchangeRateId)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var currency = _dbContext.Currencies.Include(x => x.ExchangeRates).FirstOrDefault(x => x.Id == currencyId);
                    var rate = currency?.ExchangeRates.FirstOrDefault(x => x.Id == exchangeRateId);
                    if (rate != null)
                    {
                        _dbContext.ExchangeRates.Remove(rate);
                        _dbContext.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        #endregion

        #region Private
        private Guid AddExchangeRateToCurrency(ExchangeRateDto exchangeRateDto, Guid currencyId)
        {
            var rate = _dbContext.ExchangeRates.FirstOrDefault(x => x.Id == exchangeRateDto.Id);
            if (rate == null)
            {
                var newExchangeRate = new ExchangeRate
                {
                    Rate = exchangeRateDto.Rate,
                    Date = exchangeRateDto.Date,
                    UnitsNumber = exchangeRateDto.UnitsNumber,
                    CurrencyId = currencyId
                };
                _dbContext.ExchangeRates.Add(newExchangeRate);
                _dbContext.SaveChanges();

                return newExchangeRate.Id;
            }

            return Guid.Empty;

        }
        private Guid AddCurrency(CurrencyDto currencyDto)
        {
            var currency = new Currency
            {
                Code = currencyDto.Code,
                Name = currencyDto.Name
            };
            _dbContext.Currencies.Add(currency);
            _dbContext.SaveChanges();
            return currency.Id;
        }
        #endregion
    }
}