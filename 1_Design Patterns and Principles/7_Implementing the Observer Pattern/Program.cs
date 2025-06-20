using System;
using System.Collections.Generic;

// 1. Observer Interface
public interface IObserver
{
    void Update(string stockName, double price);
}

// 2. Subject Interface
public interface IStock
{
    void RegisterObserver(IObserver observer);
    void DeregisterObserver(IObserver observer);
    void NotifyObservers();
}

// 3. Concrete Subject (StockMarket)
public class StockMarket : IStock
{
    private List<IObserver> observers = new List<IObserver>();
    private string stockName;
    private double stockPrice;

    public void SetStock(string name, double price)
    {
        stockName = name;
        stockPrice = price;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void DeregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName, stockPrice);
        }
    }
}

// 4. Concrete Observer – Mobile App
public class MobileApp : IObserver
{
    private string _appName;

    public MobileApp(string appName)
    {
        _appName = appName;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"[MobileApp - {_appName}] {stockName} updated to ₹{price}");
    }
}

// 5. Concrete Observer – Web App
public class WebApp : IObserver
{
    private string _appName;

    public WebApp(string appName)
    {
        _appName = appName;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"[WebApp - {_appName}] {stockName} updated to ₹{price}");
    }
}

// 6. Test Class
class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();

        IObserver mobile = new MobileApp("Zerodha");
        IObserver web = new WebApp("Groww");

        stockMarket.RegisterObserver(mobile);
        stockMarket.RegisterObserver(web);

        stockMarket.SetStock("TCS", 3685.75);
        stockMarket.SetStock("INFY", 1450.40);

        stockMarket.DeregisterObserver(web);

        stockMarket.SetStock("HDFC", 1625.10);
    }
}
