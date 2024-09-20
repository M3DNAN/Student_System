using EF_BikeStoreDB.Data;
using EF_BikeStoreDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Linq;

namespace EF_BikeStoreDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //Retrieve all categories from the production.categories table
            var r1 = context.Categories.Select(e => new { e.CategoryId ,e.CategoryName }).ToList();
            foreach (var item in r1)
            {
                Console.WriteLine($" Category ID : {item.CategoryId} , Category Name : {item.CategoryName}");
            }

            Console.WriteLine("----------------------\n----------------------");
            //Retrieve the first product from the production.products table.
            var r2 = context.Products.First();
            Console.WriteLine($" Product ID : {r2.ProductId} , Product Name : {r2.ProductName}");

            Console.WriteLine("----------------------\n----------------------");
            //Retrieve a specific product from the production.products table by ID.
            var r3 = context.Products.Find(8);
            Console.WriteLine($" Product ID : {r3.ProductId} , Product Name : {r3.ProductName}");

            Console.WriteLine("----------------------\n----------------------");
            //Retrieve all products from the production.products table with a certain model year.
            var r4 = context.Products.Where(e => e.ModelYear == 2018);
            foreach (var item in r4)
            {
                Console.WriteLine($" Product ID : {item.ProductId} , Product Name : {item.ProductName} , Model Year : {item.ModelYear} ");
            }

            Console.WriteLine("----------------------\n----------------------");
            //Retrieve a specific customer from the sales.customers table by ID.
            var r5 = context.Customers.First(e => e.CustomerId == 4);
            Console.WriteLine($" Customer ID : {r5.CustomerId} , Customer Name : {r5.FirstName + ' ' + r5.LastName}");

            Console.WriteLine("----------------------\n----------------------");
            //Retrieve a list of product names and their corresponding brand names.
            var r6 = context.Products.Include(e => e.Brand).ToList();
            foreach (var item in r6)
            {
                Console.WriteLine($"  Product Name : {item.ProductName} , brand Name : {item.Brand.BrandName}");
            }

            Console.WriteLine("----------------------\n----------------------");
            //Count the number of products in a specific category.
            var r7 = context.Products.Count(e => e.Category.CategoryName == "Electric Bikes");
            Console.WriteLine(r7);

            Console.WriteLine("----------------------\n----------------------");
            //Calculate the total list price of all products in a specific category.
            var r8 = context.Products.Where(e => e.Category.CategoryName == "Road Bikes").Sum(e => e.ListPrice);
            Console.WriteLine(r8);

            Console.WriteLine("----------------------\n----------------------");
            //Calculate the average list price of products.     
            var r9 = context.Products.Average(e => e.ListPrice);
            Console.WriteLine(r9);

            Console.WriteLine("----------------------\n----------------------");
            //Retrieve orders that are completed.
            var r10 = context.Orders.Where(e => e.OrderStatus == 4);
            foreach (var item in r10)
            {
                Console.WriteLine($" Order ID : {item.OrderId} , Order Status : {item.OrderStatus}");
            }
        }
    }
}
