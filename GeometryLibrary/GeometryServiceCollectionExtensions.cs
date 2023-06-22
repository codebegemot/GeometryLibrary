using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace GeometryLibrary
{
    public static class GeometryServiceCollectionExtensions
    {
        public static IServiceCollection AddGeometryLibrary(this IServiceCollection services)
        {
            services.AddScoped<IShape, Circle>();
            services.AddScoped<IShape, Triangle>();
            return services;
        }
    }
}
