using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace API.Model.Entities
{
    public class ContactInfoEntity
    {
        [JsonPropertyName("Text")]public string Text { get; set; }
        [JsonPropertyName("Call")]public string Call { get; set; }
        [JsonPropertyName("Address")]public string Address { get; set; }
    }
}