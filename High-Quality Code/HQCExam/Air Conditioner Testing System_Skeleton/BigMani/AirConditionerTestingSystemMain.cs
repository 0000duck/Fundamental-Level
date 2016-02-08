namespace AirConditionerTestingSystem
{
    using Core;
    using Core.UI;

    public class AirConditionerTestingSystemMain
    {
        public static void Main()
        {
            var engine = new AirConditionerTestingSystemEngine(new ConsoleUserInterface());
            engine.Run();
        }
    }
}
