using ComicWorld.Domain.Interface;
using ComicWorld.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IComicRepository, ComicRepository>();
            return services;
        }
    }
}
