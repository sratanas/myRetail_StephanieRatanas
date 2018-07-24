using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using myRetail_StephanieRatanas.Models;

namespace myRetail_StephanieRatanas.Services
{
    public class RedSkyContext
    {

        private readonly IMongoDatabase _database = null;


        public RedSkyContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoCollection<RootMongoDBResults> RootRedSkyResults{
            get
            {
                return _database.GetCollection<RootMongoDBResults>("RedSky");
            }
        }

    }
}
