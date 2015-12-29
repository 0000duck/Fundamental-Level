namespace WebPage.Core.Controllers
{
    using System.Runtime.CompilerServices;
    using Interfaces;
    using Interfaces.Generic;
    using ViewEngine;
    using ViewEngine.Generic;

    public class Controller
    {

        protected IViewResult View([CallerMemberName]string callee = "")
        {
            string controllerName = this.GetType().Name.Replace("Controller", "");
            string fullQualifedName
                = MvcContext.Current.AssemblyName
                  + "."
                  + MvcContext.Current.ViewsFolder
                  + "."
                  + controllerName
                  + "."
                  + callee;
            
            return new ViewResult(fullQualifedName);
        }

        protected IViewResult View(string controller, string action)
        {
            string fullQualifedName
               = MvcContext.Current.AssemblyName
                 + "."
                 + MvcContext.Current.ViewsFolder
                 + "."
                 + controller
                 + "."
                 + action;

            return new ViewResult(fullQualifedName);
        }

        protected IViewResult<T> View<T>(T model, [CallerMemberName]string callee = "")
        {
            string controllerName = this.GetType().Name.Replace("Controller", "");
            string fullQualifedName
                = MvcContext.Current.AssemblyName
                  + "."
                  + MvcContext.Current.ViewsFolder
                  + "."
                  + controllerName
                  + "."
                  + callee;

            return new ViewResult<T>(fullQualifedName, model);
        }

        protected IViewResult<T> View<T>(T model, string controller, string action)
        {
            string fullQualifedName
                = MvcContext.Current.AssemblyName
                  + "."
                  + MvcContext.Current.ViewsFolder
                  + "."
                  + controller
                  + "."
                  + action;

            return new ViewResult<T>(fullQualifedName, model);
        }
    }
}
