using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Orders
{
    public class dataMapper
    {
        private readonly string categoriesFileName;
        private readonly string productsFileName;
        private readonly string ordersFileName;

        public dataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public dataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            List<string> categories = readFileLines(this.categoriesFileName, true);
            return categories
                .Select(c => c.Split(','))
                .Select(c => new Category
                {
                    ID = int.Parse(c[0]),
                    Name = c[1],
                    Description = c[2]
                });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            List<string> products = readFileLines(this.productsFileName, true);
            return products
                .Select(p => p.Split(','))
                .Select(p => new Product
                {
                    ID = int.Parse(p[0]),
                    Name = p[1],
                    Category_ID = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitsInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            List<string> orders = readFileLines(this.ordersFileName, true);
            return orders
                .Select(p => p.Split(','))
                .Select(p => new Order
                {
                    ID = int.Parse(p[0]),
                    Product_ID = int.Parse(p[1]),
                    Quantity = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        private List<string> readFileLines(string filename, bool hasHeader)
        {
            List<string> allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}
