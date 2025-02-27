namespace SHM.MessageQueues.RabbitMQ;

public class RabbitMQOptions
{
    public string Hostname { get; set; } = "localhost";
    public string Username { get; set; } = "guest";
    public string Password { get; set; } = "guest";
    public int Port { get; set; } = 5672;
}