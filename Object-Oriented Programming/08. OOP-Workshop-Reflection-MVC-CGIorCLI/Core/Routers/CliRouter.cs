namespace WebPage.Core.Routers
{
    using System;

    public class CliRouter : RouterAbstract
    {
        private readonly string[] tokens;
        private readonly string[] controllerActionParams;
        private readonly string[] actionAndParams;
        
        public CliRouter(string line) : base()
        {
            this.tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.controllerActionParams = this.tokens[1].Split('/');
            this.actionAndParams = this.controllerActionParams[1].Split('?');
        }

        protected override void InitRequestMethod()
        {
            this.requestMethod = tokens[0];
        }

        protected override void InitControllerName()
        {
            this.controllerName
                    = controllerActionParams[0];
            this.controllerName = (this.controllerName[0] + "").ToUpper() +
                             this.controllerName.Substring(1, this.controllerName.Length - 1);
        }

        protected override void InitActionName()
        {
            this.actionName = actionAndParams[0];
            this.actionName = (this.actionName[0] + "").ToUpper() +
                             this.actionName.Substring(1, this.actionName.Length - 1);
        }

        public override void ParseInput()
        {
            if (this.actionAndParams.Length >= 2)
            {
                string[] pairs = this.actionAndParams[1].Split('&');
                foreach (var pair in pairs)
                {
                    string[] keyValue = pair.Split('=');
                    this.getParams.Add(keyValue[0], keyValue[1]);
                }
            }

            if (this.tokens.Length >= 3)
            {
                string[] pairs = tokens[2].Split('&');
                foreach (var pair in pairs)
                {
                    string[] keyValue = pair.Split('=');
                    this.postParams.Add(keyValue[0], keyValue[1]);
                }
            }
            base.ParseInput();
        }
    }
}
