using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double totalArea = Rectangles(2500, 1500) + Triangle(750, 500) + 0.5 * Circles(375);
            double totalCost = totalArea * 180;

            // Calculating the material cost for the floor plan of Taj Mahal, India.
            double tajTotalArea = Rectangles(90.5, 90.5) - 2 * Rectangles(24, 24);
            double tajTotalCost = tajTotalArea * 180;

            // Calculating the material cost for the floor plan of the Great Mosque of Mecca.
            double meccaTotalArea = Rectangles(180, 106) * Rectangles(284, 264) - Triangle(264, 84);
            double meccaTotalCost = meccaTotalArea * 180;

            Console.WriteLine("There are 3 floor plans to chose from!");
            Console.Write("What floor plan would you like?( Teothuacan - 1, Taj Mahal - 2, Mosque of Mecca - 3: ");
            string choice = Console.ReadLine();
            string floorPlanChoice = choice.ToUpper();

            switch (floorPlanChoice)
            {
                case "1":
                    {
                        Console.WriteLine($"Your floor area is {totalArea}, and the cost of the flooring material is 180 pesos, therefore the total cost for this building will be ${Math.Round(totalCost, 2)}.");
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine($"Your floor area is {tajTotalArea}, and the cost of the flooring material is 180 pesos, therefore the total cost for this building will be ${Math.Round(tajTotalCost, 2)}.");
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine($"Your floor area is {meccaTotalArea}, and the cost of the flooring material is 180 pesos, therefore the total cost for this building will be ${Math.Round(meccaTotalCost, 2)}.");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Sorry, we haven't planned that building yet.");
                        break;
                    }
            }

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
