using Microsoft.Extensions.DependencyInjection;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context;

namespace AVS.MicroRabbitmq.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data - SQL
            services.AddSingleton<RabbitMqDbContext>();            
        }
    }
}
