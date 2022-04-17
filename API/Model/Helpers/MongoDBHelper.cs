using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace API.Model.Helpers
{
    public class MongoDBHelper
    {
        public MongoDBHelper()
        {   
        }

        public static async Task<LocationEntity> GetLocationInformation(){
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://unibility-admin:Q4oVQd9IivNDgqXJ@unibility-cluster.trgpx.mongodb.net/Unibility?retryWrites=true&w=majority");
            
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            
            var client = new MongoClient(settings);

            var database = client.GetDatabase("Unibility");

            var data = database.GetCollection<LocationEntity>("Locations");

            var result = data.Find(new BsonDocument()).FirstOrDefault();

            var location = new LocationEntity{
                name = result.name,
                TypeOfBusiness = result.TypeOfBusiness,
                OwnerContactInfo = result.OwnerContactInfo,
                AccessibilityList = result.AccessibilityList
            };

            return result;
        }

        public static async void AddReview(ReviewEntity item)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://unibility-admin:Q4oVQd9IivNDgqXJ@unibility-cluster.trgpx.mongodb.net/Unibility?retryWrites=true&w=majority");

            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            var client = new MongoClient(settings);

            var database = client.GetDatabase("Unibility");

            // reviews collection
            var data = database.GetCollection<ReviewEntity>("Reviews");

            var review = new ReviewEntity{
                rating = 3,
                body = "some review"
            };

            data.InsertOne(review);
        }

        public static async void AddReport(ReportEntity item) {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://unibility-admin:Q4oVQd9IivNDgqXJ@unibility-cluster.trgpx.mongodb.net/Unibility?retryWrites=true&w=majority");

            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            var client = new MongoClient(settings);

            var database = client.GetDatabase("Unibility");
            var data = database.GetCollection<ReportEntity>("Reports");

            data.InsertOne(item);
        }
    }
}