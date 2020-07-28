using Microsoft.Extensions.DependencyInjection;
using Mordor.Repository.Abstractions;
using Mordor.Repository.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository
{
    public static class Services
    {
        public static void RegisterRepositoryDependencies(this IServiceCollection services)
        {
            services.AddTransient<IIzeContext, IzeContext>();
            services.AddTransient<IOrkRepository, OrkRepository>();
            services.AddTransient<IOrkMapper, OrkMapper>();
            services.AddTransient<IHordaRepository, HordaRepository>();
            services.AddTransient<IHordaMapper, HordaMapper>();
        }
    }
}
