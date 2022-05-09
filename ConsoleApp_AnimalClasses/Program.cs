

namespace ConsoleApp_AnimalClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Elephant ele = new Elephant();
            Goat gt = new Goat();
            Spider spidy = new Spider();
            Hammerhead sharky = new Hammerhead();
            Squid squidy = new Squid();
            Crab crabby =  new Crab();

            ele.Move();
            ele.FillTrunk();

            gt.Ram();
            gt.Move();

            spidy.Bite();
            spidy.Move();
            spidy.Climb();

            sharky.Move();
            sharky.Eat();
            sharky.Pound();

            squidy.Move();
            squidy.Eat();

            crabby.Move();
            crabby.Swim();
        }    
    }
}