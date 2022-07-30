using AutoMapper;
using ComicWorld.Application.Interfaces;
using ComicWorld.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ComicWorld.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplications(this IServiceCollection services)
        {
            services.AddTransient<IComicService, ComicService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
