using Microsoft.Extensions.DependencyInjection;
using Mordor.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Service
{
    public static class Services
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IOrkService, OrkService>();
            services.AddTransient<IHordaService, HordaService>();
        }
    }
}
