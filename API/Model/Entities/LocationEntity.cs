using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class LocationEntity
    {
        [JsonPropertyName("name")]public string Name { get; set; }
        [JsonPropertyName("TypeOfBusiness")]public string TypeOfBusiness { get; set; }
        [JsonPropertyName("AccessibilityList")]public List<String> AccessibilityList { get; set; }
        [JsonPropertyName("InformationLinks")]public List<String> InformationLinks { get; set; }
        [JsonPropertyName("OwnerContactInfo")]public ContactInfoEntity OwnerContactInfo { get; set; }
    }
}