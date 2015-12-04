using System;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private decimal price;

        public Laptop(string model, decimal price, string manufacturer, string screen, string processor, string ram, string hdd, string graphicsCard, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public Laptop(string model, decimal price, string manufacturer, string screen, string processor, string ram, string hdd)
                : this(model, price, manufacturer, screen, processor, ram, hdd, null, null)
        {
        }

        public Laptop(string model, decimal price, string manufacturer, string screen)
            : this(model, price, manufacturer, screen, null, null, null, null, null)
        {
        }

        public Laptop(string model, decimal price)
            : this(model, price, null, null, null, null, null, null, null)
        {
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Model info cannot be empty!");
                }

                model = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public string Manufacturer { get; set; }

        public string Processor { get; set; }

        public string Ram { get; set; }

        public string GraphicsCard { get; set; }

        public string Hdd { get; set; }

        public string Screen { get; set; }

        public Battery Battery { get; set; }

        public override string ToString()
        {
            return $"Model: {Model}\n Price: {Price}\n Manufacturer: {Manufacturer}\n Processor: {Processor}\n Ram: {Ram}\n GraphicsCard: {GraphicsCard}\n Hdd: {Hdd}\n Screen: {Screen}\n Battery: {Battery}\n";
        }
    }
}