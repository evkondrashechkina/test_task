using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Currencies.Dto;
using Currencies.Implementations;

namespace Currencies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrenciesController : ControllerBase
    {
        private readonly DbStorage _storage;

        public CurrenciesController(DbStorage storage)
        {
            _storage = storage;
        }

        #region Currencies

        /// <summary>
        /// Получить список валют
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_storage.GetCurrencies());
        }

        /// <summary>
        /// Получить данные о конкретной валюте
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetCurrency(Guid id)
        {
            var result = _storage.GetCurrency(id);
            if (result != null)
                return Ok(result);
            else
                return NoContent();
        }

        /// <summary>
        /// Добавить новую валюту
        /// </summary>
        /// <param name="currencyDto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCurrency([FromBody] CurrencyDto currencyDto)
        {
            var result = _storage.AddNewCurrency(currencyDto);
            return Ok(result);
        }

        /// <summary>
        /// Изменить информацию о существующей валюте
        /// </summary>
        /// <param name="currencyDto"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult EditCurrency([FromBody] CurrencyDto currencyDto)
        {
            var result = _storage.EditCurrency(currencyDto);
            if (result)
                return Ok();
            else
                return Conflict();
        }

        /// <summary>
        /// Удалить валюту
        /// </summary>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        [HttpDelete("{currencyId}")]
        public IActionResult DeleteCompany(Guid currencyId)
        {
            var result = _storage.DeleteCurrency(currencyId);
            if (result)
                return Ok();
            else
                return Conflict();
        }

        #endregion

        #region ExchangeRates
        //Текущий курс всегда в связке с валютой, так что оставила в одном контроллере

        /// <summary>
        /// Удалить курс валюты
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="exchangeRateId"></param>
        /// <returns></returns>
        [HttpDelete("{currencyId}/rates/{exchangeRateId}")]
        public IActionResult DeleteExchangeRateFromCurrency(Guid currencyId, Guid exchangeRateId)
        {
            var result = _storage.DeleteExchangeRateFromCurrency(currencyId, exchangeRateId);
            if (result)
                return Ok();
            else
                return Conflict();
        }

        /// <summary>
        /// Получить конкретный курс валюты
        /// </summary>
        /// <param name="exchangeRateId"></param>
        /// <returns></returns>
        [HttpGet("{currencyId}/rates/{exchangeRateId}")]
        public IActionResult GetExchangeRate(Guid exchangeRateId)
        {
            var result = _storage.GetExchangeRate(exchangeRateId);
            if (result != null)
                return Ok(result);
            else
                return Conflict();
        }

        /// <summary>
        /// Изменить данные курса валюты
        /// </summary>
        /// <param name="exchangeRateDto"></param>
        /// <returns></returns>
        [HttpPut("{currencyId}/rates")]
        public IActionResult EditExchangeRate([FromBody] ExchangeRateDto exchangeRateDto)
        {
            var result = _storage.EditExchangeRate(exchangeRateDto);
            if (result)
                return Ok();
            else
                return Conflict();
        }

        /// <summary>
        /// Добавить новый курс валют
        /// </summary>
        /// <param name="exchangeRateDto"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        [HttpPost("{currencyId}/rates")]
        public IActionResult AddExchangeRate([FromBody] ExchangeRateDto exchangeRateDto, Guid currencyId)
        {
            var result = _storage.AddNewExchangeRate(exchangeRateDto, currencyId);
            if (result != Guid.Empty)
                return Ok(result);
            else
                return Conflict();
        }

        #endregion
    }
}