namespace KvadratickaRovnice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double D;
            double x1, x2;

            Console.Write("Zadej koeficient a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Zadej koeficient b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Zadej koeficient c: ");
            c = double.Parse(Console.ReadLine());

            D = b * b - 4 * a * c;

            Console.WriteLine($"Diskriminant = {D}");

            if (D < 0 )
            {
                Console.WriteLine("Nemá řešení");
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(D))/(2*a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            Console.ReadLine();
        }
    }
}