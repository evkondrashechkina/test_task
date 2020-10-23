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
    public class GetCurrenciesTest
    {
        private DbStorage _repository;
        private readonly string dbName = "TestGetCurrencies";

        [SetUp]
        public void SetUp()
        {
            _repository = BaseTestSetupConfiguration.SetDbStorage(dbName);
        }

        [Test(Description = "Получаем список валют")]
        public void GetCurrenciesNormal()
        {
            var result = _repository.GetCurrencies();

            Assert.True(result != null);
            Assert.AreEqual(3, result.ToList().Count);
        }
    }
}
