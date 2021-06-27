using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCBack.Application.Interfaces;
using PCBack.Infrastructure.Persistance;

namespace PCBack.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PcDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("Default"), 
                builder => builder.MigrationsAssembly(typeof(PcDbContext).Assembly.FullName)));

            services.AddScoped<IPcDbContext>(provider => provider.GetService<PcDbContext>());

            return services;
        }
    }
}
