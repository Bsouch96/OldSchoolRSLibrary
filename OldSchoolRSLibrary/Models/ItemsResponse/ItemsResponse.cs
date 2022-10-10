using System.Text.Json.Serialization;

namespace OldSchoolRSLibrary.Models.ItemsResponse
{
    public class ItemsResponse
    {
        [JsonInclude]
        public int Total { get; set; }
        [JsonInclude]
        public Item[] Items { get; set; }
    }
}
