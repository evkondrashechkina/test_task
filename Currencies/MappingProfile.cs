using System.Linq;
using AutoMapper;
using DataAccessLayer.Entities;
using Currencies.Dto;

namespace Currencies
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Currency, CurrencyDto>();
            CreateMap<ExchangeRate, ExchangeRateDto>();
        }
    }
}