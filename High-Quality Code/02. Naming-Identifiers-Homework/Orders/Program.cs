using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            dataMapper dataMapper = new dataMapper();
            var Categories = dataMapper.GetAllCategories();
            var Products = dataMapper.GetAllProducts();
            var Orders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpProducts = Products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpProducts));

            Console.WriteLine(new string('-', 10));

            // Number of products in each Category
            var numberProdCategory = Products
                .GroupBy(p => p.Category_ID)
                .Select(grp => new { Category = Categories.First(c => c.ID == grp.Key).Name, Count = grp.Count() })
                .ToList();
            foreach (var item in numberProdCategory)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by Order quantity)
            var topProducts = Orders
                .GroupBy(o => o.Product_ID)
                .Select(grp => new { Product = Products.First(p => p.ID == grp.Key).Name, Quantities = grp.Sum(grpgrp => grpgrp.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in topProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable Category
            var profitableCategory = Orders
                .GroupBy(o => o.Product_ID)
                .Select(g => new { catId = Products.First(p => p.ID == g.Key).Category_ID, price = Products.First(p => p.ID == g.Key).UnitPrice, quantity = g.Sum(p => p.Quantity) })
                .GroupBy(gg => gg.catId)
                .Select(grp => new { category_name = Categories.First(c => c.ID == grp.Key).Name, total_quantity = grp.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", profitableCategory.category_name, profitableCategory.total_quantity);
        }
    }
}
