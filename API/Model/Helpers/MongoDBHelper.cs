using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model.Entities;
using MongoDB.Driver;

namespace API.Model.Helpers
{
    public class MongoDBHelper
    {
        private readonly string _connectionString = "mongodb+srv://unibility-admin:Q4oVQd9IivNDgqXJ@unibility-cluster.trgpx.mongodb.net/Unibility?retryWrites=true&w=majority";

        public MongoDBHelper()
        {
            
            
        }

        public static async Task<LocationEntity> GetLocationInformation(){
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://unibility-admin:Q4oVQd9IivNDgqXJ@unibility-cluster.trgpx.mongodb.net/Unibility?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);

            var database = client.GetDatabase("Unibility");
            return new LocationEntity();
        }
    }
}