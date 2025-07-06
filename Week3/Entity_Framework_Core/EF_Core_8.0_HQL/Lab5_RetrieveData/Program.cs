using Lab2_DbContextInit;

using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

// 1. Retrieve all products
Console.WriteLine("All Products:");
var products = await context.Products.ToListAsync();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - Rs{p.Price}");
}

// 2. Find by ID
Console.WriteLine("\nProduct with ID 1:");
var productById = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {productById?.Name}");

// 3. FirstOrDefault with condition
Console.WriteLine("\nExpensive Product (Price > Rs50000):");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");

