using System;

// 1. Command Interface
public interface ICommand
{
    void Execute();
}

// 2. Receiver Class (Device)
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is OFF");
    }
}

// 3. Concrete Command – Turn Light ON
public class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}

// 4. Concrete Command – Turn Light OFF
public class LightOffCommand : ICommand
{
    private Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOff();
    }
}

// 5. Invoker Class – Remote Control
public class RemoteControl
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        if (command != null)
            command.Execute();
        else
            Console.WriteLine("No command set.");
    }
}

// 6. Test Class
class Program
{
    static void Main(string[] args)
    {
        // Receiver
        Light livingRoomLight = new Light();

        // Commands
        ICommand lightOn = new LightOnCommand(livingRoomLight);
        ICommand lightOff = new LightOffCommand(livingRoomLight);

        // Invoker
        RemoteControl remote = new RemoteControl();

        // Turn light on
        remote.SetCommand(lightOn);
        remote.PressButton();

        // Turn light off
        remote.SetCommand(lightOff);
        remote.PressButton();
    }
}
