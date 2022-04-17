using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using MongoDB.Bson;

namespace API.Model.Entities
{
    public class ReportEntity
    {
        [JsonPropertyName("type")]public string type { get; set; }
        [JsonPropertyName("location")]public CoordinatesEntity location { get; set; }

    }
}