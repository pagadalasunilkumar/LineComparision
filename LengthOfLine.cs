using System;
namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on .Net");
            int x1, x2, y1, y2;
            double length;
            Console.WriteLine("------------Calculating Length of the Line-------------");
            Console.WriteLine("Enter X1 Value");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y1 Value");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 Value");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y2 Value");
            y2 = Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the Line is--" + length);

        }
    }
}