using Lab2_DbContextInit;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("EF Core Lab 6 - Update and Delete");

using var context = new AppDbContext();

// ✅ Update Product
var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
if (product != null)
{
    product.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine("Laptop price updated.");
}
else
{
    Console.WriteLine("Laptop not found.");
}

// ❌ Delete Product
var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
if (toDelete != null)
{
    context.Products.Remove(toDelete);
    await context.SaveChangesAsync();
    Console.WriteLine("Rice Bag deleted.");
}
else
{
    Console.WriteLine("Rice Bag not found.");
}
