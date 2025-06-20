using System;

public class Computer
{
    // Required properties
    public string CPU { get; private set; }
    public string RAM { get; private set; }

    // Optional properties
    public string Storage { get; private set; }
    public string GraphicsCard { get; private set; }
    public string OperatingSystem { get; private set; }

    // Private constructor to force use of builder
    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
        GraphicsCard = builder.GraphicsCard;
        OperatingSystem = builder.OperatingSystem;
    }

    // Display computer configuration
    public void ShowSpecs()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage ?? "Not added"}");
        Console.WriteLine($"Graphics Card: {GraphicsCard ?? "Not added"}");
        Console.WriteLine($"Operating System: {OperatingSystem ?? "Not installed"}");
    }

    // Builder class
    public class Builder
    {
        // Required
        public string CPU { get; }
        public string RAM { get; }

        // Optional
        public string Storage { get; private set; }
        public string GraphicsCard { get; private set; }
        public string OperatingSystem { get; private set; }

        public Builder(string cpu, string ram)
        {
            CPU = cpu;
            RAM = ram;
        }

        public Builder SetStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public Builder SetGraphicsCard(string graphicsCard)
        {
            GraphicsCard = graphicsCard;
            return this;
        }

        public Builder SetOperatingSystem(string os)
        {
            OperatingSystem = os;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}

// Test class
class Program
{
    static void Main(string[] args)
    {
        // Basic Computer
        Computer basic = new Computer.Builder("Intel i3", "8GB").Build();
        Console.WriteLine("Basic Computer Specs:");
        basic.ShowSpecs();

        Console.WriteLine("\n---------------------------\n");

        // Gaming Computer
        Computer gaming = new Computer.Builder("Intel i9", "32GB")
                                .SetStorage("1TB SSD")
                                .SetGraphicsCard("NVIDIA RTX 4080")
                                .SetOperatingSystem("Windows 11")
                                .Build();
        Console.WriteLine("Gaming Computer Specs:");
        gaming.ShowSpecs();
    }
}
