using System;

namespace _03.PCCatalog
{
    public class Component
    {
        private string name;
        private decimal price;

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component(string name, decimal price) : this(name, price, null)
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty!");
                }

                name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0.0m)
                {
                    throw new Exception("Price cannot be negative");
                }

                price = value;
            }
        }

        public string Details { get; set; }

        public int CompareTo(object obj)
        {
            var component = (Component) obj;
            return Price.CompareTo(component.Price);
        }
    }
}