using Microsoft.Extensions.DependencyInjection;
using OldSchoolRSLibrary.Clients;

namespace OldSchoolRSLibrary
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureOSServices(this IServiceCollection services)
        {
            services.AddHttpClient<IGrandExchangeClient, GrandExchangeClient>();
            services.AddTransient<IClientData, ClientData>();
        }
    }
}
