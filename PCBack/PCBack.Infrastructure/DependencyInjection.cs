using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCBack.Application.Interfaces;
using PCBack.Infrastructure.Persistance;
using PCBack.Infrastructure.Services;
using PCBack.Infrastructure.Settings;
using System;

namespace PCBack.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CompilerApiSettings>(configuration.GetSection(CompilerApiSettings.Path));
            services.AddHttpClient<ISubmissionService, SubmissionService>(client =>
            {
                var compilerSettings = new CompilerApiSettings();
                configuration.GetSection(CompilerApiSettings.Path).Bind(compilerSettings);
                client.BaseAddress = new Uri(compilerSettings.Url);
            });
            services.AddDbContext<PcDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("Default"), 
                builder => builder.MigrationsAssembly(typeof(PcDbContext).Assembly.FullName)));

            services.AddScoped<IPcDbContext>(provider => provider.GetService<PcDbContext>());

            return services;
        }
    }
}
