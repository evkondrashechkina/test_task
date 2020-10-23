using AutoMapper;
using Currencies;
using Currencies.Implementations;

namespace CurrencyTests.DataAccess
{
    public class BaseTestSetupConfiguration
    {
        public static DbStorage SetDbStorage(string dbName)
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.AddProfile<MappingProfile>();
            });

            var mapper = config.CreateMapper();
            var dbContext = TestData.GetDataContext(dbName);

            return new DbStorage(dbContext, mapper);
        }
    }
}
