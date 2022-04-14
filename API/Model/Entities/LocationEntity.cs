using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace API.Model.Entities
{
    public class LocationEntity
    {
        [JsonPropertyName("_id")]public ObjectId Id { get; set; }
        [JsonPropertyName("lat")]public string latitude { get; set; }
        [JsonPropertyName("long")]public string longitude { get; set; }
        [JsonPropertyName("name")]public string name { get; set; }
        [JsonPropertyName("TypeOfBusiness")]public string TypeOfBusiness { get; set; }
        [JsonPropertyName("AccessibilityList")]public List<String> AccessibilityList { get; set; }
        [JsonPropertyName("InformationLinks")]public List<String> InformationLinks { get; set; }
        [JsonPropertyName("OwnerContactInfo")]public ContactInfoEntity OwnerContactInfo { get; set; }
        [JsonPropertyName("ReportList")]public List<String> ReportList { get; set; }
        [JsonPropertyName("ReviewList")]public List<String> ReviewList { get; set; }
    }
}