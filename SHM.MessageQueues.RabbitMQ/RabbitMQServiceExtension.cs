using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SHM.MessageQueues.Abstractions;

namespace SHM.MessageQueues.RabbitMQ;

public static class RabbitMQServiceExtension
{
    public static IServiceCollection RegisterSHMRabbitMQ(this IServiceCollection services, Action<RabbitMQOptions> configureOptions)
    {
        services.Configure(configureOptions);
        services.TryAddSingleton<IMessageBrokerConnection, RabbitMQConnection>();
        return services;
    }
}