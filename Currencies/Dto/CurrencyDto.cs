using System;
using System.Collections.Generic;

namespace Currencies.Dto
{
    public class CurrencyDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<ExchangeRateDto> ExchangeRates { get; set; }
    }
}