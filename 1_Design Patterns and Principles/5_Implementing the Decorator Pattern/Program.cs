using System;

// 1. Component Interface
public interface INotifier
{
    void Send(string message);
}

// 2. Concrete Component
public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"[Email] {message}");
    }
}

// 3. Base Decorator
public abstract class NotifierDecorator : INotifier
{
    protected INotifier _wrappedNotifier;

    public NotifierDecorator(INotifier notifier)
    {
        _wrappedNotifier = notifier;
    }

    public virtual void Send(string message)
    {
        _wrappedNotifier.Send(message);
    }
}

// 4. Concrete Decorators
public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"[SMS] {message}");
    }
}

public class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"[Slack] {message}");
    }
}

// 5. Client / Test
class Program
{
    static void Main(string[] args)
    {
        // Base notifier
        INotifier notifier = new EmailNotifier();

        // Add SMS notification
        notifier = new SMSNotifierDecorator(notifier);

        // Add Slack notification on top
        notifier = new SlackNotifierDecorator(notifier);

        // Send a message through all channels
        notifier.Send("System alert: Backup completed successfully.");
    }
}
