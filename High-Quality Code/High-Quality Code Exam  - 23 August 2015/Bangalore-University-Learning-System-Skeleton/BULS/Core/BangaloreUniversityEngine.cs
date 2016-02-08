using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using BangaloreUniversityLearningSystem.Data;
using BangaloreUniversityLearningSystem.Models;
using BangaloreUniversityLearningSystem.Interfaces;
using BangaloreUniversityLearningSystem.Controllers;

namespace BangaloreUniversityLearningSystem.Core
{
    public class BangaloreUniversityEngine : IBangaloreUniversityEngine
    {
        public void Run()
        {
            var database = new BangaloreUniversityData();
            User currentUser = null;

            while (true)
            {
                string routeUrl = Console.ReadLine();
                if (routeUrl == null)
                {
                    break;
                }

                var route = new Route(routeUrl);
                var expectedController = route.ControllerName;
                var controllerType = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .FirstOrDefault(type => type.Name == expectedController);

                var controller = Activator.CreateInstance(controllerType, database, currentUser) as Controller;

                var action = controllerType.GetMethod(route.ActionName);
                var argumentsToPass = MapParameters(route, action);
                try
                {
                    var view = action.Invoke(controller, argumentsToPass) as IView;

                    var output = view.Display();
                    Console.WriteLine(output);

                    currentUser = controller.CurrentUser;
                }
                catch (Exception ex)
                {
                    if (ex.InnerException is ArgumentException || ex.InnerException is AuthorizationFailedException)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }
                    else
                    {
                        throw ex.InnerException;
                    }
                }
            }
        }

        private static object[] MapParameters(Route route, MethodInfo action)
        {
            // return action.GetParameters()
            //    .Select<ParameterInfo, object>(p =>
            //    {
            //        if (p.ParameterType == typeof(int))
            //            return int.Parse(route.Parameters[p.Name]);
            //        else
            //            return route.Parameters[p.Name];
            //    })
            ////    .ToArray();

            var expectedMethodParameters = action.GetParameters();
            var argumentsToPass = new List<object>();
            foreach (ParameterInfo param in expectedMethodParameters)
            {
                var currentArgument = route.Parameters[param.Name];
                if (param.ParameterType == typeof(int))
                {
                    argumentsToPass.Add(int.Parse(currentArgument));
                }
                else
                {
                    argumentsToPass.Add(currentArgument);
                }
            }

            return argumentsToPass.ToArray();
        }
    }
}
