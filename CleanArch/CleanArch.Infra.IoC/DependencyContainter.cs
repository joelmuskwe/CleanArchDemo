using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICourseService, CourseService>();
            
            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            
            return services;
        }
    }
}