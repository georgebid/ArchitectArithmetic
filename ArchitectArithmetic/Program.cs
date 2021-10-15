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

            Console.WriteLine(".................");
            // Calculating the material cost for the floor plan of Taj Mahal, India.
            double tajTotalArea = Rectangles(90.5, 90.5) - Triangle(24, 24);
            double tajTotalCost = tajTotalArea * 180;
            Console.WriteLine(tajTotalArea);
            Console.WriteLine($"Your floor area is {tajTotalArea}, and the cost of the flooring material is 180 pesos, therefore the total cost for this building will be ${Math.Round(tajTotalCost, 2)}.");

            Console.WriteLine(".................");
            // Calculating the material cost for the floor plan of the Great Mosque of Mecca.
            double meccaTotalArea = Rectangles(180, 106) * Rectangles(284, 264) - Triangle(264, 84);
            double meccaTotalCost = meccaTotalArea * 180;
            Console.WriteLine(meccaTotalArea);
            Console.WriteLine($"Your floor area is {meccaTotalArea}, and the cost of the flooring material is 180 pesos, therefore the total cost for this building will be ${Math.Round(meccaTotalCost, 2)}.");

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
