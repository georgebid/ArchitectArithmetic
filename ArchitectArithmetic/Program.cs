using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("There are 3 floor plans to chose from!");
            Console.Write("What floor plan would you like? (Teothuacan - 1, Taj Mahal - 2, Mosque of Mecca - 3): ");

            string choice = Console.ReadLine();
            double totalArea;

            switch (choice)
            {
                case "1":

                    totalArea = Rectangles(2500, 1500) + Triangle(750, 500) + 0.5 * Circles(375);
                    break;

                case "2":

                    totalArea = Rectangles(90.5, 90.5) - 2 * Rectangles(24, 24);
                    break;

                case "3":

                    totalArea = Rectangles(180, 106) * Rectangles(284, 264) - Triangle(264, 84);
                    break;

                default:

                    totalArea = 0;
                    break;
            }
            double totalCost = totalArea * 180;
            Console.WriteLine($"The total cost for this building will be {Math.Round(totalCost, 2)}.");

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
}


