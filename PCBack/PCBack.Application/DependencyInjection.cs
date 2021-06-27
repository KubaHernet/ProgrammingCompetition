using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PCBack.Application.Mappings;
using System.Reflection;

namespace PCBack.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<ApplicationProfile>();
            });
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
