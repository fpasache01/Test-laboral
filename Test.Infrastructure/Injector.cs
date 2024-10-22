using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Namespace;

namespace Vass.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public static class Injector
    {    
        public static IServiceCollection Inject(this IServiceCollection services)
        {
            services.AddSingleton<ITestRepository,TestRepository>();
             services.AddScoped<IClientRepository,ClientRepository>();
            return services;
        }
    }
}
