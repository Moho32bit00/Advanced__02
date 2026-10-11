using System.Collections;
using System.Net;
using System.Xml.Linq;

namespace Advanced__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
            new Product
            { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10
            },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150 , Stock = 6}

            };

            #region Task 01 : Smart Product Search
            Console.WriteLine("--- Uder 50$ ---");
            filter<Product> f = FilterHelper.Cheaper_50;
            List <Product> result = ProtuctHelper<Product>.SearchProducts(catalog, f);
            foreach (Product p in result)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("--- All Elctro ---");
            f = FilterHelper.All_elctro;
            result = ProtuctHelper<Product>.SearchProducts(catalog, f);
            foreach (Product p in result)
            {
                Console.WriteLine(p);
            }
            #endregion

            #region task3 -1 
            Console.WriteLine();
            Console.WriteLine("--- Short Report ---");
            Action<Product> a1 = product => Console.WriteLine($"->Name: {product.Name} | Price: {product.Price}");
            ProtuctHelper<Product>.printa(catalog, a1);
            Console.WriteLine();
            Console.WriteLine("--- Detailed Report ---");
            Action<Product> a2 = product => Console.WriteLine($"->Name: {product.Name} | Category: {product.Category} | Price: {product.Price} | Stock: {product.Stock}");
            ProtuctHelper<Product>.printa(catalog, a2);
            Console.WriteLine();
            #endregion 





        }
    }
}
