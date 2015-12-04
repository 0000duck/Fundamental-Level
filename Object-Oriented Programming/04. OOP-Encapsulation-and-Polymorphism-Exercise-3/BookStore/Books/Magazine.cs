using BookStore.Interfaces;

namespace BookStore.Books
{
    public class Magazine : IBook
    {
        public Magazine(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }

        public string Title { get; }

        public decimal Price { get; }
    }
}