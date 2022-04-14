using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace API.Model.Helpers
{
    public class MongoDBHelper
    {
        private readonly string _connectionString = "mongodb+srv://unibility-admin:Q4oVQd9IivNDgqXJ@unibility-cluster.trgpx.mongodb.net/Unibility?retryWrites=true&w=majority";
        private MongoDB.Driver.MongoClientSettings settings;

        public MongoDBHelper()
        {
            settings = MongoClientSettings.FromConnectionString(_connectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        }
    }
}