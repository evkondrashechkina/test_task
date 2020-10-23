using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class ExchangeRate
    {
        public Guid Id { get; set; }
        //отнесла сюда, а не в Currency, так как количество единиц бывает отличается по дням
        public int UnitsNumber { get; set; }
        public float Rate { get; set; }
        public DateTime Date { get; set; }
        public Guid CurrencyId { get; set; }
    }
}
