namespace ConsoleApp_Geometry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //HardCodedTest();
            SoftCodedTest();
        }

        private static void HardCodedTest()
        {
            double a1 = 43.32;
            double a2 = 52.323;
            double a3 = 16.144;
            double a4 = 192.2;

            Square square1 = new Square(a1);
            Square square2 = new Square(a2);
            Square square3 = new Square(a3);
            Square square4 = new Square(a4);

            Parallelogram parallelogram1 = new Parallelogram(12.30, 15.20, 12.00);

            Console.WriteLine(square1.Perimeter());
            Console.WriteLine(square2.Perimeter());
            Console.WriteLine(square3.Perimeter());
            Console.WriteLine(square4.Perimeter());
            Console.WriteLine("");
            Console.WriteLine(square1.Area());
            Console.WriteLine(square2.Area());
            Console.WriteLine(square3.Area());
            Console.WriteLine(square4.Area());

            Console.WriteLine(parallelogram1.Area());
        }

        private static void SoftCodedTest()
        {
            double a = 10;
            double b = 9;
            double c = 8;
            double d = 9;

            double angle = 23.3;

            List<Square> figures = new List<Square>();

            figures.Add(new Square(a));
            figures.Add(new Rectangle(a, b));
            figures.Add(new Trapezoid(a, b, c, d));
            figures.Add(new Parallelogram(a, b, angle));
            figures.Add(new Triangle(a, b, c));

            foreach (Square item in figures)
            {
                Console.WriteLine(item + " - Area: " + item.Area());
                Console.WriteLine(item + " - Perimeter: " + item.Perimeter());
            }
        }
    }
}