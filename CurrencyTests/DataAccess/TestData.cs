using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CurrencyTests.DataAccess
{
    public class TestData
    {
        private static readonly List<string> InitializedDbNames = new List<string>();

        public static CurrencyContext GetDataContext(string dbName = "Currencies.Test")
        {
            InitDb(dbName);

            var options = new DbContextOptionsBuilder<CurrencyContext>()
                .UseInMemoryDatabase(dbName)
                .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;

            var dbContext = new CurrencyContext(options);

            return dbContext;
        }

        private static void InitDb(string dbName = "Currencies.Test")
        {
            lock (InitializedDbNames)
            {
                if (InitializedDbNames.Contains(dbName))
                    return;

                var options = new DbContextOptionsBuilder<CurrencyContext>()
                    .UseInMemoryDatabase(dbName)
                    .ConfigureWarnings(warnings => warnings.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                    .Options;

                using (var dbContext = new CurrencyContext(options))
                {
                    InitializedDbNames.Add(dbName);

                    LoadEntityListToDatabase<Currency>(dbContext);
                    LoadEntityListToDatabase<ExchangeRate>(dbContext);
                    dbContext.SaveChanges();
                }
            }
        }

        private static void LoadEntityListToDatabase<T>(DbContext dbContext, string resourceFileName = null) where T : class
        {
            var assembly = typeof(TestData).GetTypeInfo().Assembly;

            if (resourceFileName == null)
            {
                resourceFileName = typeof(T).Name + ".json";
            }

            var resourceName = $"{assembly.GetName().Name}.Data.{resourceFileName}";

            var format = "yyyy-MM-dd";
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };

            using (var streamreader = new StreamReader(assembly.GetManifestResourceStream(resourceName), Encoding.UTF8))
            {
                var json = streamreader.ReadToEnd();

                var list = JsonConvert.DeserializeObject<List<T>>(json, dateTimeConverter);

                dbContext.Set<T>().AddRange(list);
            }
        }
    }
}
