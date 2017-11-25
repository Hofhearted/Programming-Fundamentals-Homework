using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculatingTriange(a, h));
            }
            else if (figureType == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculatingSquare(a));
            }
            else if (figureType == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculatingRectangle(a, b));
            }
            else
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculatingCircle(r));
            }
        }
        static double CalculatingTriange(double a, double h)
        {
            double triangleArea = (a * h) / 2;
            return triangleArea;
        }
        static double CalculatingSquare(double a)
        {
            double squareArea = a * a;
            return squareArea;
        }
        static double CalculatingRectangle(double a, double b)
        {
            double rectangleArea = a * b;
            return rectangleArea;
        }
        static double CalculatingCircle(double r)
        {
            double circleArea = Math.PI * r * r;
            return circleArea;
        }
    }
}