using Currencies.Implementations;
using CurrencyTests.DataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyTests
{
    [TestFixture]
    public class GetExchangeRateTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestGetExchangeRate";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Получаем данные по существующему значению валюты")]
        public void GetExchangeRateNormal()
        {
            var rateId = Guid.Parse("666C1BCC-4686-4600-9CBE-8ACEAEB84DC4");
            var result = _repository.GetExchangeRate(rateId);

            Assert.True(result != null);
            Assert.AreEqual(77.0284f, result.Rate);
            Assert.AreEqual(1, result.UnitsNumber);
            Assert.AreEqual(DateTime.Parse("2020-10-17"), result.Date);
        }

        [Test(Description = "Получаем данные по несуществующему значению валюты")]
        public void GetExchangeRateNotExisting()
        {
            var rateId = Guid.NewGuid();
            var result = _repository.GetExchangeRate(rateId);

            Assert.True(result == null);
        }
    }
}
