using System;

// Target Interface
public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}

// Adaptee Class 1 – PayPal (incompatible interface)
public class PayPal
{
    public void SendPayment(double amount)
    {
        Console.WriteLine($"[PayPal] Processed ₹{amount}");
    }
}

// Adaptee Class 2 – Stripe (incompatible interface)
public class Stripe
{
    public void MakeStripePayment(double amount)
    {
        Console.WriteLine($"[Stripe] Processed ₹{amount}");
    }
}

// Adapter for PayPal
public class PayPalAdapter : IPaymentProcessor
{
    private PayPal _paypal;

    public PayPalAdapter(PayPal paypal)
    {
        _paypal = paypal;
    }

    public void ProcessPayment(double amount)
    {
        _paypal.SendPayment(amount);
    }
}

// Adapter for Stripe
public class StripeAdapter : IPaymentProcessor
{
    private Stripe _stripe;

    public StripeAdapter(Stripe stripe)
    {
        _stripe = stripe;
    }

    public void ProcessPayment(double amount)
    {
        _stripe.MakeStripePayment(amount);
    }
}

// Test Class / Client
class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor paypalProcessor = new PayPalAdapter(new PayPal());
        paypalProcessor.ProcessPayment(1500.00);

        IPaymentProcessor stripeProcessor = new StripeAdapter(new Stripe());
        stripeProcessor.ProcessPayment(900.50);
    }
}
