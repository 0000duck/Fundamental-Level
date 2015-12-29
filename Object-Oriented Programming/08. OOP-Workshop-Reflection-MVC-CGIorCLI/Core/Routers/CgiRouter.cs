namespace WebPage.Core.Routers
{
    using System;

    public class CgiRouter : RouterAbstract
    {
        private readonly string[] controllerActionParams;
        private readonly string[] controllerAction;

        public CgiRouter() : base()
        {
            Console.WriteLine("Content-type:text/html\r\n\r\n");
            this.controllerActionParams = Environment.GetEnvironmentVariable("QUERY_STRING").Split('&');
            this.controllerAction = controllerActionParams[0].Split('/');
        }

        protected override void InitRequestMethod()
        {          
            this.requestMethod = Environment.GetEnvironmentVariable("REQUEST_METHOD");
        }

        protected override void InitControllerName()
        {
            this.controllerName = this.controllerAction[0];
            this.controllerName = (this.controllerName[0] + "").ToUpper() +
                             this.controllerName.Substring(1, this.controllerName.Length - 1);
        }

        protected override void InitActionName()
        {
            this.actionName = this.controllerAction[1];
            this.actionName = (this.actionName[0] + "").ToUpper() +
                         this.actionName.Substring(1, this.actionName.Length - 1);
        }

        public override void ParseInput()
        {
            if (this.controllerActionParams.Length >= 1)
            {
                int i = 0;
                foreach (var pair in this.controllerActionParams)
                {
                    if (i == 0)
                    {
                        i++;
                        continue;
                    }
                    string[] keyValue = pair.Split('=');
                    this.getParams.Add(keyValue[0], keyValue[1]);
                }
            }

            string[] pairs = Console.ReadLine().Split('&');
            foreach (var pair in pairs)
            {
                string[] keyValue = pair.Split('=');
                this.postParams.Add(keyValue[0], keyValue[1]);
            }

            base.ParseInput();
        }
    }
}
