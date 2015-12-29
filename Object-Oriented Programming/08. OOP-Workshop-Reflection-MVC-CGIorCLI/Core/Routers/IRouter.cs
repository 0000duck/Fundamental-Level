namespace WebPage.Core.Routers
{
    using System.Reflection;
    using Controllers;
    using Interfaces;

    public interface IRouter : IDispatchable
    {
        void ParseInput();
        Controller GetController();
        MethodInfo GetMethod();
    }
}
