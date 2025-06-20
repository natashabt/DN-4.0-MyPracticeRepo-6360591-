using System;

// 1. Subject Interface
public interface IImage
{
    void Display();
}

// 2. Real Subject (Simulates remote image loading)
public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromRemoteServer();
    }

    private void LoadFromRemoteServer()
    {
        Console.WriteLine($"[Loading] {_fileName} from remote server...");
    }

    public void Display()
    {
        Console.WriteLine($"[Displaying] {_fileName}");
    }
}

// 3. Proxy Class (Lazy initialization + caching)
public class ProxyImage : IImage
{
    private string _fileName;
    private RealImage _realImage;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName); // load only when needed
        }
        _realImage.Display();
    }
}

// 4. Test Class
class Program
{
    static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("nature.jpg");
        IImage image2 = new ProxyImage("space.png");

        // Image will be loaded when Display is called
        image1.Display(); // Loads from remote
        image1.Display(); // Uses cached image

        Console.WriteLine();

        image2.Display(); // Loads from remote
        image2.Display(); // Uses cached image
    }
}
