namespace ConsoleApp_CoffeeMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            List<Powder> powders = new List<Powder> { new Powder(50, "Coffee"), new Powder(60, "Tea") };

            coffeeMachine.PowerOn();
            foreach (Powder powder in powders)
            {
                coffeeMachine.InsertFilter();
                coffeeMachine.Input(650, powder);
                coffeeMachine.Activate();
                Print(coffeeMachine.Output());
                coffeeMachine.Deactivate();
                coffeeMachine.RemoveFilter();
            }

            Powder powderForEsspresso = new Powder(50, "Coffee");
            coffeeMachine.InsertFilter();
            coffeeMachine.Input(650, powderForEsspresso);
            coffeeMachine.MachineSettings(1, "Espresso");
            coffeeMachine.Activate();
            Print(coffeeMachine.Output());

        }

        private static void Print(string[] output)
        {
            Console.WriteLine($"Cups: {output[0]} of {output[1]} - Cup Strength: {output[2]}%");
        }
    }
}