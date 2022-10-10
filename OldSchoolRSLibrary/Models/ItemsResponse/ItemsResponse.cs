using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
