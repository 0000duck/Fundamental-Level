namespace WebPage.Views.Home
{
    using System;
    using Core.Interfaces;

    public class Index : IRenderable
    {

        public void Render()
        {
            Console.WriteLine("MY FIRST VIEW");
        }

    }
}
