namespace ConsoleApp_CoffeeMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            coffeeMachine.PowerOn();
            coffeeMachine.InsertFilter();
            coffeeMachine.Input(650, 50);
            coffeeMachine.Activate();

            int[] output = coffeeMachine.Output();

            Console.WriteLine("Cups: " + output[0] + " - Cup Strength: " + output[1] + "%" );
        }
    }
}