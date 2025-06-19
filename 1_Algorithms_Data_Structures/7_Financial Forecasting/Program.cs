using System;

class FinancialForecast
{
    // Recursive function to calculate future value
    public static double PredictFutureValue(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;
        
        return PredictFutureValue(initialValue, growthRate, years - 1) * (1 + growthRate);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter initial amount: ");
        double initial = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual growth rate (e.g. 0.05 for 5%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of years to forecast: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureValue = PredictFutureValue(initial, rate, years);
        Console.WriteLine($"\nPredicted value after {years} years: {futureValue:F2}");
    }
}
