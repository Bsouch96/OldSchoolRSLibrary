using OldSchoolRSLibrary.Models.ItemsResponse;

namespace OldSchoolRSLibrary.Clients
{
    public interface IGrandExchangeClient
    {
        Task<ItemsResponse> GetItemsByCategoryAndNameAsync(string itemChar, int pageNumber);
    }
}