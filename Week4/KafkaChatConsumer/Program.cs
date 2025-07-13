using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",  // Kafka server
            GroupId = "chat-consumer-group",      // Unique consumer group
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

        consumer.Subscribe("chat-app"); // Topic name created in Kafka

        Console.WriteLine("📥 Waiting for messages from Kafka...");

        try
        {
            while (true)
            {
                var message = consumer.Consume(); // Waits for a new message
                Console.WriteLine($"📨 Received: {message.Message.Value}");
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}

