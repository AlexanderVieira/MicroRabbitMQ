using System.Net.Security;
using System.Runtime.Serialization;
using System.Transactions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
//using MediatR.Extensions.Microsoft.DependencyInjection;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Repositories;
using AVS.MicroRabbitmq.Domain.Banking.Interfaces.Repositories;
using AVS.MicroRabbitmq.Domain.Banking.CommandHandlers;
using AVS.MicroRabbitmq.Domain.Banking.Commands;
using AVS.MicroRabbitmq.Domain.Banking.Events;
using AVS.MicroRabbitmq.Domain.Banking.Models;
using AVS.MicroRabbitmq.Application.Banking.Interfaces;
using AVS.MicroRabbitmq.Application.Banking.Services;
using AVS.MicroRabbitmq.Domain.Core.Interfaces;
using AVS.MicroRabbitmq.Infra.CrossCutting.Bus;

namespace AVS.MicroRabbitmq.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
             //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });  

            services.AddMediatR(typeof(NativeInjectorBootStrapper));          

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Infra - Data - SQL
            services.AddSingleton<RabbitMqDbContext>();            

            services.AddScoped<IAccountRepository, AccountRepository>();            

            services.AddScoped<IAccountService, AccountService>();            

        }
    }
}
