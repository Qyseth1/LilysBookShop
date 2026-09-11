using Microsoft.Extensions.DependencyInjection;
using SharedLibrary.Interfaces.Services;
using SharedLibrary.Service;

namespace SharedLibrary.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // 🔹 Services
            services.AddSingleton<IMessageService, MessageService>();
            //services.AddSingleton<IDataService, DataService>();
            //services.AddTransient<IUserService, UserService>();            
            // services.AddSingleton<ILoggingService, LoggingService>();

            return services;
        }
    }
}  
