using Core.Services.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Api.Extensions
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddAuthModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddJwtAuthenticationExtension(configuration);
            services.AddAuthServices();
            services.AddSwaggerExtension();
            return services;
        }
    }
}
