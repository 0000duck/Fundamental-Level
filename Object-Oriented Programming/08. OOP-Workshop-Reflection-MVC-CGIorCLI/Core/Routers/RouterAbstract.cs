namespace WebPage.Core.Routers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Attributes.HttpRequestMethods;
    using Controllers;
    using Interfaces;

    public abstract class RouterAbstract : IRouter
    {
        protected IDictionary<string, object> getParams;
        protected IDictionary<string, object> postParams;
        protected string requestMethod;
        protected string controllerName;
        protected string actionName;
        protected object[] methodParams;

        protected RouterAbstract()
        {
            this.getParams = new Dictionary<string, object>();
            this.postParams = new Dictionary<string, object>();
        }

        protected abstract void InitRequestMethod();
        protected abstract void InitControllerName();
        protected abstract void InitActionName();

        protected IEnumerable<MethodInfo> GetSuitableMethods()
        {
            return this.GetController()
                .GetType()
                .GetMethods()
                .Where(m => m.Name == this.actionName);
        }

        public Controller GetController()
        {
            return (Controller)Activator.CreateInstance(Type.GetType(
                MvcContext.Current.AssemblyName
                + "."
                + MvcContext.Current.ControllersFolder
                + "."
                + this.controllerName + MvcContext.Current.ControllersSuffix
                ));
        }

        public MethodInfo GetMethod()
        {
            MethodInfo method = null;
            foreach (MethodInfo methodInfo in this.GetSuitableMethods())
            {
                IEnumerable<Attribute> attributes = methodInfo
                    .GetCustomAttributes()
                    .Where(a => a is HttpMethodAttribute);

                if (!attributes.Any())
                {
                    method = methodInfo;
                    break;
                }

                foreach (HttpMethodAttribute attribute in attributes)
                {
                    if (attribute.IsValid(requestMethod))
                    {
                        method = methodInfo;
                        break;
                    }
                }
            }

            return method;
        }

        public void Dispatch()
        {
            IInvocable result
                = (IInvocable)this
                    .GetMethod()
                    .Invoke(this.GetController(), this.methodParams);

            result.Invoke();
        }

        public virtual void ParseInput()
        {
            this.InitRequestMethod();
            this.InitControllerName();
            this.InitActionName();

            var method = this.GetMethod();

            if (method == null)
            {
                throw new NotSupportedException("No such method");
            }

            IEnumerable<ParameterInfo> parameters
                = method.GetParameters();

            this.methodParams
                = new object[parameters.Count()];
            int index = 0;
            foreach (ParameterInfo param in parameters)
            {
                if (param.ParameterType.IsPrimitive)
                {
                    object value = this.getParams[param.Name];
                    this.methodParams[index] = Convert.ChangeType(
                        value,
                        param.ParameterType
                        );
                    index++;
                }
                else
                {
                    Type bindingModelType = param.ParameterType;
                    object bindingModel =
                        Activator.CreateInstance(bindingModelType);

                    IEnumerable<PropertyInfo> properties
                        = bindingModelType.GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        property.SetValue(
                            bindingModel,
                            Convert.ChangeType(
                                postParams[property.Name],
                                property.PropertyType
                                )
                            );
                    }

                    this.methodParams[index] = Convert.ChangeType(
                        bindingModel,
                        bindingModelType
                        );
                    index++;
                }
            }
        }

        private void Main()
        {
            Dictionary<string, object> getParams = new Dictionary<string, object>();
            Dictionary<string, object> postParams = new Dictionary<string, object>();


            Controller controller = this.GetController();
        }

    }
}
