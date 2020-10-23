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
    public class EditCurrencyTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestEditCurrency";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Изменяем данные о валюте")]
        public void EditCurrencyNormal()
        {
            var currency = new CurrencyDto
            {
                Id = Guid.Parse("4AF36C6C-BA0C-48EC-8397-8FDEDE42DD50"),
                Code = "USD",
                Name = "Доллар Соединенных Штатов Америки"
            };

            var result = _repository.EditCurrency(currency);

            Assert.True(result);

            //проверяем, что база проапдейтилась
            using (var _dbContext = TestData.GetDataContext(dbName))
            {
                var updatedCurrency = _dbContext.Currencies.FirstOrDefault(x => x.Id == currency.Id);

                Assert.True(updatedCurrency != null);
                Assert.AreEqual(currency.Code, updatedCurrency.Code);
                Assert.AreEqual(currency.Name, updatedCurrency.Name);
            }
        }
    }
}
