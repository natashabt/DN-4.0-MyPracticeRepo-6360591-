public class PaymentTest {
    public static void main(String[] args) {
        // Using PayPal
        PayPalGateway paypal = new PayPalGateway();
        PaymentProcessor paypalProcessor = new PayPalAdapter(paypal);
        paypalProcessor.processPayment(250.00);

        System.out.println("---------------------------");

        // Using Stripe
        StripeGateway stripe = new StripeGateway();
        PaymentProcessor stripeProcessor = new StripeAdapter(stripe);
        stripeProcessor.processPayment(430.75);
    }
}

