using Newtonsoft.Json;
using OldSchoolRSLibrary.Models;
using OldSchoolRSLibrary.Models.ItemsResponse;

namespace OldSchoolRSLibrary.Clients
{
    public class GrandExchangeClient : IGrandExchangeClient
    {
        private readonly HttpClient _httpClient;
        private readonly GEClientData _geClientData;

        public GrandExchangeClient(HttpClient httpClient, IClientData clientData)
        {
            _httpClient = httpClient;
            _geClientData = clientData.GEClientData;
        }

        public async Task<ItemsResponse> GetItemsByCategoryAndNameAsync(string itemChar, int pageNumber)
        {
            ItemsResponse itemsResponse = null;
            try
            {
                string endpoint = _geClientData.ItemsAddress.Replace("{alpha}", itemChar).Replace("{page}", pageNumber.ToString());
                var response = await _httpClient.GetAsync($"{_geClientData.BaseAddress}{endpoint}");
                var responseJson = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                    itemsResponse = JsonConvert.DeserializeObject<ItemsResponse>(responseJson);
                
            }
            catch(Exception ex)
            {

            }
            return itemsResponse;
        }
    }
}
