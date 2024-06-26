using CodingTestAPI.Interfaces;
using CodingTestAPI.Services;

namespace CodingTestAPI.Configurations
{
    public static class ConfigureServices
    {

        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICodingCourseService, CodingCourseService>();
            return services;
        }
    }
}
    