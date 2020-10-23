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
    public class DeleteCurencyTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestDeleteCurrency";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Удаляем валюту")]
        public void DeleteCurrencyNormal()
        {
            var currencyId = Guid.Parse("4AF36C6C-BA0C-48EC-8397-8FDEDE42DD50");

            var result = _repository.DeleteCurrency(currencyId);

            Assert.True(result);

            //проверяем, что база проапдейтилась
            using (var _dbContext = TestData.GetDataContext(dbName))
            {
                var currency = _dbContext.Currencies.FirstOrDefault(x => x.Id == currencyId);

                Assert.True(currency == null);
            }
        }

        [Test(Description = "Удаляем несуществующую валюту")]
        public void DeleteCurrencyNotExisting()
        {
            var currencyId = Guid.NewGuid();

            var result = _repository.DeleteCurrency(currencyId);

            Assert.IsFalse(result);
        }
    }
}
