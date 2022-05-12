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
                Print(coffeeMachine.Output(), powder);
                coffeeMachine.Deactivate();
                coffeeMachine.RemoveFilter();
            }
        }

        private static void Print(int[] output, Powder powder)
        {
            Console.WriteLine($"Cups: {output[0]} of {powder.Type} - Cup Strength: {output[1]}%");
        }
    }
}