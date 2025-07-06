using System;
using System.Linq;
using System.Threading.Tasks;
using Lab2_DbContextInit;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // 1. Filter and Sort Products
        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        Console.WriteLine("Filtered Products (Price > 1000):");
        foreach (var p in filtered)
        {
            Console.WriteLine($"{p.Name} - Rs{p.Price}");
        }

        // 2. Project into DTO
        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        Console.WriteLine("\nProduct DTOs:");
        foreach (var dto in productDTOs)
        {
            Console.WriteLine($"{dto.Name} - Rs{dto.Price}");
        }
    }
}

