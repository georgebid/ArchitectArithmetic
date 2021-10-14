using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double totalArea = Rectangles(2500, 1500) + Triangle(750, 500) + 0.5 * Circles(375);
            double totalCost = totalArea * 180;
            Console.WriteLine(totalArea);
            Console.WriteLine($"Your floor area is {totalArea}, and the cost of the flooring material is 180 pesos, therefore the total cost for this building will be {Math.Round(totalCost, 2)}.");
        }
        static double Rectangles(double length, double width)
        {
            return length * width;
        }
        static double Circles(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
