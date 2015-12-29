namespace Orders
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Category_ID { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
