using System;
using System.Text;

namespace BookShop
{
    public class Book
    {

        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double Price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = Price;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title cannot be empty.");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Author cannot be empty.");
                }

                author = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be greater than zero");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", author, Environment.NewLine);
            output.AppendFormat("-Price: {0:F2}{1}", price, Environment.NewLine);
            return output.ToString();
        }
    }
}
