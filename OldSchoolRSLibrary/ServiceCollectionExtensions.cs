using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OldSchoolRSLibrary.Clients;
using OldSchoolRSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
