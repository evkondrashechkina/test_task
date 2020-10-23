using Currencies.Implementations;
using CurrencyTests.DataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyTests
{
    [TestFixture]
    public class GetCurrencyTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestGetCurrency";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Получаем данные по существующей валюте")]
        public void GetCurrencyNormal()
        {
            var usdGuid = Guid.Parse("4AF36C6C-BA0C-48EC-8397-8FDEDE42DD50");
            var result = _repository.GetCurrency(usdGuid);

            Assert.True(result != null);
            Assert.AreEqual("USD", result.Code);
            Assert.AreEqual("Доллар США", result.Name);
            Assert.AreEqual(3, result.ExchangeRates.Count);
        }

        [Test(Description = "Получаем данные по несуществующей валюте")]
        public void GetCurrencyNotExisting()
        {
            var usdGuid = Guid.Parse("ED3A1E0A-F614-4E75-BAB7-24F2EB657ECF");
            var result = _repository.GetCurrency(usdGuid);

            Assert.True(result == null);
        }
    }
}
