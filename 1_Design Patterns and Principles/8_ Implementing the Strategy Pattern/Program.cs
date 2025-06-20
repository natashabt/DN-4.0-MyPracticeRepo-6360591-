using System;

// 1. Strategy Interface
public interface IPaymentStrategy
{
    void Pay(double amount);
}

// 2. Concrete Strategy – Credit Card
public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"[CreditCard] ₹{amount} paid using card ending with {cardNumber.Substring(cardNumber.Length - 4)}");
    }
}

// 3. Concrete Strategy – PayPal
public class PayPalPayment : IPaymentStrategy
{
    private string email;

    public PayPalPayment(string email)
    {
        this.email = email;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"[PayPal] ₹{amount} paid using PayPal account {email}");
    }
}

// 4. Context Class
public class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        this.paymentStrategy = strategy;
    }

    public void ExecutePayment(double amount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("No payment strategy selected!");
            return;
        }
        paymentStrategy.Pay(amount);
    }
}

// 5. Test Class
class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();

        // Pay using Credit Card
        context.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432"));
        context.ExecutePayment(2500.00);

        // Switch to PayPal
        context.SetPaymentStrategy(new PayPalPayment("user@example.com"));
        context.ExecutePayment(1500.00);
    }
}
