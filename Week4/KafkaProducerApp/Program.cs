using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Enter messages to send to Kafka (type 'exit' to stop):");

        while (true)
        {
            var message = Console.ReadLine();
            if (message == "exit") break;

            await producer.ProduceAsync("chat-app", new Message<Null, string> { Value = message });
            Console.WriteLine("Message sent: " + message);
        }
    }
}

