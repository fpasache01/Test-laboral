using System;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Vass.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public static class Injector
    {
        public static IServiceCollection Inject(this IServiceCollection services)
        {
            services.AddSingleton<ITestService, TestService>();
            return services;
        }
    }
}
