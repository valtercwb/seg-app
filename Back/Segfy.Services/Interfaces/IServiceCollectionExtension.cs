using Microsoft.Extensions.DependencyInjection;
using Segfy.Domain;
using Segfy.Domain.Interfaces;

namespace Segfy.Services.Interfaces
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection ServicesCollection (this IServiceCollection services)
        {
            services.AddScoped<IApoliceAutomovelRepository, ApoliceAutomovelRepository>();
            return services;
        }
    }
}
