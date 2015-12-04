using System.Globalization;
using System.Threading;
using BookStore.Interfaces;
using BookStore.UI;

namespace BookStore
{
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            IInputHandler inputHandler = new ConsoleInputHandler();
            IRenderer renderer = new FileRenderer();

            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);

            engine.Run();
        }
    }
}
