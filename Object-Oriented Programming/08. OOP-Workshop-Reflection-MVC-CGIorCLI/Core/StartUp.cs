namespace WebPage.Core
{
    using System;
    using System.Reflection;
    using Routers;

    class StartUp
    {
        static void Main(string[] args)
        {
            RegisterAssemblyName();
            RegisterControllers();
            RegisterViews();
            RegisterModels();

            /**
            /// There are two type of routers so far:
            ///    1. CLI router: Parses console input and dispatches requests 
            ///     from format {requestMethod} {controller}/{action}?{getRequest} {postRequest}
            ///     constructor accepts a string
            ///    2. CGI router: Parses input from CGI via Environment variables 
            ///     optionally if POST is present reads the standard input
            **/
            IRouter router = new CliRouter(Console.ReadLine());
            try
            {
                router.ParseInput();
                router.Dispatch();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void RegisterAssemblyName()
        {
            MvcContext.Current.AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }

        static void RegisterControllers(string controllersFolder = "Controllers", string controllerSuffix = "Controller")
        {
            MvcContext.Current.ControllersFolder = controllersFolder;
            MvcContext.Current.ControllersSuffix = controllerSuffix;
        }

        static void RegisterViews(string viewsFolder = "Views")
        {
            MvcContext.Current.ViewsFolder = viewsFolder;
        }

        static void RegisterModels(string modelsFolder = "Models")
        {
            MvcContext.Current.ModelsFolder = modelsFolder;
        }
    }
}
