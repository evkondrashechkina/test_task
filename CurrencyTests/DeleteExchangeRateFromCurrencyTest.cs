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
    public class DeleteExchangeRateFromCurrencyTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestDeleteExchangeRate";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Удаляем конкретное значение валюты")]
        public void DeleteExchageRateNormal()
        {
            var currencyId = Guid.Parse("4AF36C6C-BA0C-48EC-8397-8FDEDE42DD50");
            var rateId = Guid.Parse("666C1BCC-4686-4600-9CBE-8ACEAEB84DC4");

            var result = _repository.DeleteExchangeRateFromCurrency(currencyId, rateId);

            Assert.True(result);

            //проверяем, что база проапдейтилась
            using (var _dbContext = TestData.GetDataContext(dbName))
            {
                var rate = _dbContext.ExchangeRates.FirstOrDefault(x => x.Id == rateId);

                Assert.True(rate == null);
            }
        }

        [Test(Description = "Удаляем несуществующее значение валюты")]
        public void DeleteExchangeRateNotExisting()
        {
            var currencyId = Guid.Parse("4AF36C6C-BA0C-48EC-8397-8FDEDE42DD50");
            var rateId = Guid.NewGuid();

            var result = _repository.DeleteExchangeRateFromCurrency(currencyId, rateId);

            Assert.IsFalse(result);
        }
    }
}
