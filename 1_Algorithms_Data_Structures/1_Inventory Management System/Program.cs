using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    // Product class
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }

        public Product(int id, string name, int qty, double price)
        {
            ProductId = id;
            ProductName = name;
            Quantity = qty;
            ProductPrice = price;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Quantity: {Quantity}, Price: {ProductPrice}";
        }
    }

    // Inventory Manager class
    class InventoryManager
    {
        private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

        public void AddProduct(Product product)
        {
            if (!inventory.ContainsKey(product.ProductId))
            {
                inventory[product.ProductId] = product;
                Console.WriteLine("✅ Product added successfully.");
            }
            else
            {
                Console.WriteLine("⚠️ Product already exists.");
            }
        }

        public void UpdateProduct(int id, int qty, double price)
        {
            if (inventory.ContainsKey(id))
            {
                inventory[id].Quantity = qty;
                inventory[id].ProductPrice = price;
                Console.WriteLine("✅ Product updated successfully.");
            }
            else
            {
                Console.WriteLine("❌ Product ID not found.");
            }
        }

        public void DeleteProduct(int id)
        {
            if (inventory.Remove(id))
            {
                Console.WriteLine("🗑️ Product deleted from inventory.");
            }
            else
            {
                Console.WriteLine("❌ Product ID not found.");
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n📦 Current Inventory:");
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            foreach (var product in inventory.Values)
            {
                Console.WriteLine(product);
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();

            manager.AddProduct(new Product(101, "Soap", 10, 50));
            manager.AddProduct(new Product(102, "Shampoo", 5, 280));

            manager.DisplayInventory();

            manager.UpdateProduct(102, 12, 270);
            manager.DisplayInventory();

            manager.DeleteProduct(101);
            manager.DisplayInventory();
        }
    }
}

