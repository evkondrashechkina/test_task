using System;

namespace Currencies.Dto
{
    public class ExchangeRateDto
    {
        public Guid Id { get; set; }
        public int UnitsNumber { get; set; }
        public float Rate { get; set; }
        public DateTime Date { get; set; }
    }
}