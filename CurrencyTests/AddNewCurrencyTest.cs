using Currencies.Dto;
using Currencies.Implementations;
using CurrencyTests.DataAccess;
using NUnit.Framework;
using System;
using System.Linq;

namespace CurrencyTests
{
    [TestFixture]
    public class AddNewCurrencyTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestAddNewCurrency";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Добавляем новую валюту")]
        public void AddNewCurrencyNormal()
        {
            var newCurrency = new CurrencyDto
            {
                Code = "AUD",
                Name = "Австралийский доллар"
            };

            var result = _repository.AddNewCurrency(newCurrency);

            Assert.AreNotEqual(Guid.Empty, result);

            //проверяем, что база проапдейтилась
            using (var _dbContext = TestData.GetDataContext(dbName))
            {
                var currency = _dbContext.Currencies.FirstOrDefault(x => x.Id == result);

                Assert.True(currency != null);
                Assert.AreEqual(newCurrency.Code, currency.Code);
                Assert.AreEqual(newCurrency.Name, currency.Name);
            }
        }
    }
}