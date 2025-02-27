using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SHM.MessageQueues.Abstractions;

namespace SHM.MessageQueues.RabbitMQ;

public static class RabbitMQServiceExtension
{
    public static IServiceCollection RegisterSHMRabbitMQ(this IServiceCollection services, IConfigurationSection configurationSection)
    {
        services.Configure<RabbitMQOptions>(configurationSection);
        services.TryAddSingleton<IMessageBrokerConnection, RabbitMQConnection>();
        return services;
    }
}