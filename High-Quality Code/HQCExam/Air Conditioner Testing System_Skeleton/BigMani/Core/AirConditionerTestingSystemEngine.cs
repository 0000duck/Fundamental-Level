namespace AirConditionerTestingSystem.Core
{
    using System;
    using Infrastructure;
    using Interfaces;
    using Views;

    public class AirConditionerTestingSystemEngine
    {
        private AirConditionerView airConditioner;

        private IUserInterface userInterface;       

        public AirConditionerTestingSystemEngine(IUserInterface userInterface)
        {
            this.airConditioner = new AirConditionerView(this);
            this.userInterface = userInterface;
        }

        public Command Command { get; set; }

        public void Run()
        {
            while (true)
            {
                string line = this.userInterface.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                line = line.Trim();
                try
                {
                    this.Command = new Command(line);
                    this.airConditioner.ExecuteCommands();
                }
                catch (InvalidOperationException ex)
                {
                    this.userInterface.WriteLine(ex.Message);
                }
            }
        }
    }
}
