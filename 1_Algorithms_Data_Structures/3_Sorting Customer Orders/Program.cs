using System;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int id, string name, double price)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
    }

    public override string ToString()
    {
        return $"OrderId: {OrderId}, Customer: {CustomerName}, TotalPrice: {TotalPrice}";
    }
}

class Program
{
    // Bubble Sort by TotalPrice
    static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    // Quick Sort by TotalPrice
    static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(orders, low, high);
            QuickSort(orders, low, pivotIndex - 1);
            QuickSort(orders, pivotIndex + 1, high);
        }
    }

    static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;
                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;

        return i + 1;
    }

    static void Display(Order[] orders)
    {
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
    }

    static void Main(string[] args)
    {
        Order[] orders1 = {
            new Order(201, "Alice", 450.0),
            new Order(202, "Bob", 1200.0),
            new Order(203, "Charlie", 750.0),
            new Order(204, "Diana", 300.0)
        };

        Console.WriteLine("Before Bubble Sort:");
        Display(orders1);
        BubbleSort(orders1);
        Console.WriteLine("\nAfter Bubble Sort (by TotalPrice):");
        Display(orders1);

        Order[] orders2 = {
            new Order(201, "Alice", 450.0),
            new Order(202, "Bob", 1200.0),
            new Order(203, "Charlie", 750.0),
            new Order(204, "Diana", 300.0)
        };

        Console.WriteLine("\nBefore Quick Sort:");
        Display(orders2);
        QuickSort(orders2, 0, orders2.Length - 1);
        Console.WriteLine("\nAfter Quick Sort (by TotalPrice):");
        Display(orders2);
    }
}
