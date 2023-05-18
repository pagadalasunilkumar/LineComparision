using System;

namespace LineComparison
{
    internal class UC_2CheckEquality
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program in C#");

            double[] line1 = ReadLineCoordinates("Enter the coordinates of the first line");
            double[] line2 = ReadLineCoordinates("Enter the coordinates of the second line");

            double length1 = CalculateLength(line1[0], line1[1], line1[2], line1[3]);
            double length2 = CalculateLength(line2[0], line2[1], line2[2], line2[3]);

            Console.WriteLine("Length of the First Line is: " + length1);
            Console.WriteLine("Length of the Second Line is: " + length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("Both Line Lengths are Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        private static double[] ReadLineCoordinates(string message)
        {
            Console.WriteLine(message);
            double[] coordinates = new double[4];

            Console.WriteLine("Enter x-coordinate of the first point:");
            coordinates[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate of the first point:");
            coordinates[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x-coordinate of the second point:");
            coordinates[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate of the second point:");
            coordinates[3] = Convert.ToDouble(Console.ReadLine());

            return coordinates;
        }

        private static double CalculateLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
