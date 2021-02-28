using IdStore.NetCore.Application.Interfaces.Repositories;
using IdStore.NetCore.Domain.Enums;
using IdStore.NetCore.Infrastructure.ExecuteCommands;
using IdStore.NetCore.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdStore.NetCore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionDict = new Dictionary<EnumDbConnName, string>
            {
                { EnumDbConnName.IdStore, configuration.GetConnectionString("IdStoreConnection") }
            };

            services.AddSingleton<IDictionary<EnumDbConnName, string>>(connectionDict);
            services.AddTransient<IExecuters, Executers>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
