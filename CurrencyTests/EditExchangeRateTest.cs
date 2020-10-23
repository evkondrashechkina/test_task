using Currencies.Dto;
using Currencies.Implementations;
using CurrencyTests.DataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyTests
{
    [TestFixture]
    public class EditExchangeRateTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestEditExchangeRate";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Изменяем данные о валюте")]
        public void EditExchangeRateNormal()
        {
            var rate = new ExchangeRateDto
            {
                Id = Guid.Parse("666C1BCC-4686-4600-9CBE-8ACEAEB84DC4"),
                UnitsNumber = 2,
                Date = DateTime.Parse("2020-10-17"),
                Rate = 154.0424f
            };

            var result = _repository.EditExchangeRate(rate);

            Assert.True(result);

            //проверяем, что база проапдейтилась
            using (var _dbContext = TestData.GetDataContext(dbName))
            {
                var updatedRate = _dbContext.ExchangeRates.FirstOrDefault(x => x.Id == rate.Id);

                Assert.True(updatedRate != null);
                Assert.AreEqual(rate.UnitsNumber, updatedRate.UnitsNumber);
                Assert.AreEqual(rate.Rate, updatedRate.Rate);
                Assert.AreEqual(rate.Date, updatedRate.Date);
            }
        }
    }
}
