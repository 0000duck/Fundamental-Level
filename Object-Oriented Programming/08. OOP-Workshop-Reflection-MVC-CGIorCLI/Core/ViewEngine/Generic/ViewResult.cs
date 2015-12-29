namespace WebPage.Core.ViewEngine.Generic
{
    using System;
    using Interfaces.Generic;

    public class ViewResult<T> : IViewResult<T>
    {
        public ViewResult(string viewFullQualifiedName, T model)
        {
            this.Action =
                (IRenderable<T>)Activator.CreateInstance(Type.GetType(viewFullQualifiedName));

            this.Action.Model = model;
        }
        public void Invoke()
        {
           this.Action.Render();
        }

        public IRenderable<T> Action { get; set; }
    }
}
