namespace ConsoleApp_CoffeeMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            TeaMachine teaMachine = new TeaMachine();
            EspressoMachine espressoMachine = new EspressoMachine();

            coffeeMachine.PowerOn();
            coffeeMachine.InsertFilter();
            coffeeMachine.Input(650, 50);
            coffeeMachine.Activate();
            Print(coffeeMachine.Output());
            coffeeMachine.Deactivate();
            coffeeMachine.RemoveFilter();
            coffeeMachine.PowerOff();

            teaMachine.PowerOn();
            teaMachine.Input(650, 50);
            teaMachine.Activate();
            Print(teaMachine.Output());
            teaMachine.Deactivate();
            teaMachine.PowerOff();

            espressoMachine.PowerOn();
            espressoMachine.Input(650);
            espressoMachine.Settings(1, "Espresso");
            espressoMachine.Activate();
            Print(espressoMachine.Output());
            espressoMachine.Deactivate();
        }

        private static void Print(string[] output)
        {
            Console.WriteLine($"Cups: {output[0]} of {output[1]} - Cup Strength: {output[2]}%");
        }
    }
}