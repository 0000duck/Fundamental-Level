using System;

namespace BookShop
{
    public class BookShopMain
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90);
            Console.WriteLine(book);

            GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 29.77);
            Console.WriteLine(goldenBook);
        }
    }
}