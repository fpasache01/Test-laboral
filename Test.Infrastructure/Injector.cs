using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

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
            return services;
        }
    }
}
