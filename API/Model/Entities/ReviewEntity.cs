using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using MongoDB.Bson;

namespace API.Model.Entities
{
    public class ReviewEntity
    {
        [JsonPropertyName("rating")]public int rating { get; set; }
        [JsonPropertyName("body")]public string body { get; set; }

    }
}