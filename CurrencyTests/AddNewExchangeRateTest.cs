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
    public class AddNewExchangeRateTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestAddNewExchangeRate";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Изменяем данные о валюте")]
        public void AddNewExchangeRateNormal()
        {
            var rate = new ExchangeRateDto
            {
                Rate = 77.0288f,
                UnitsNumber = 1,
                Date = DateTime.Parse("2020-10-18")
            };

            var currencyId = Guid.Parse("4AF36C6C-BA0C-48EC-8397-8FDEDE42DD50");

            var result = _repository.AddNewExchangeRate(rate, currencyId);

            Assert.AreNotEqual(Guid.Empty, result);

            //проверяем, что база проапдейтилась
            using (var _dbContext = TestData.GetDataContext(dbName))
            {
                var newRate = _dbContext.ExchangeRates.FirstOrDefault(x => x.Id == result);

                Assert.True(newRate != null);
                Assert.AreEqual(rate.Date, newRate.Date);
                Assert.AreEqual(rate.UnitsNumber, newRate.UnitsNumber);
                Assert.AreEqual(rate.Rate, newRate.Rate);
            }
        }
    }
}
