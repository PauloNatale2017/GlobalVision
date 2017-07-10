using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace GlobalVisionVendor.SPA.MongoDB
{
    public static class MongoSupport
    {
        public static void AddMongo(this IServiceCollection services, IConfigurationSection configuration)
        {
            services.AddSingleton(new MongoClient(configuration.GetSection("ConnectionString").Value));
        }
    }
}