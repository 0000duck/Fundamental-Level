namespace WebPage.Core.Attributes.HttpRequestMethods
{
    using System;

    [AttributeUsage(AttributeTargets.All)]
    public abstract class HttpMethodAttribute : Attribute
    {
        public abstract bool IsValid(string requestMethod);
    }
}
