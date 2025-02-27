namespace SHM.MessageQueues.RabbitMQ;

public class RabbitMQOptions
{
    public string Hostname { get; init; } = "localhost";
    public string Username { get; init; } = "guest";
    public string Password { get; init; } = "guest";
    public int Port { get; init; } = 5672;
}