using System.Text.Json.Serialization;

namespace OldSchoolRSLibrary.Models.ItemsResponse
{
    public class Item
    {
        [JsonInclude]
        public string? Icon { get; set; }
        [JsonInclude]
        public string? Icon_large { get; set; }
        [JsonInclude]
        public int ID { get; set; }
        [JsonInclude]
        public string Type { get; set; }
        [JsonInclude]
        public string TypeIcon { get; set; }
        [JsonInclude]
        public string Name { get; set; }
        [JsonInclude]
        public string Description { get; set; }
        [JsonInclude]
        public Current Current { get; set; }
        [JsonInclude]
        public Today Today { get; set; }
        [JsonInclude]
        public bool Members { get; set; }
    }
}
