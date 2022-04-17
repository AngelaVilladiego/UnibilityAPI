using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using MongoDB.Bson;

namespace API.Model.Entities
{
    public class CoordinatesEntity
    {
        [JsonPropertyName("latitude")]public double latitude { get; set; }
        [JsonPropertyName("longitude")]public double longitude { get; set; }

    }
}