using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string FigureType = Console.ReadLine();
            switch (FigureType)
            {
                case "triangle":
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalcTriangleArea(width, height));
                    break;

                case "rectangle":
                    double h = double.Parse(Console.ReadLine());
                    double w = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalcRectangleArea(w, h));
                    break;

                case "square":
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalcSquareArea(a));
                    break;

                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CalcCircleArea(r));
                    break;
            }
        }
        static double CalcSquareArea(double a)
        {
            return a * a;
        }
        static double CalcTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        static double CalcRectangleArea(double w, double h)
        {
            return w * h;
        }
        static double CalcCircleArea(double r)
        {
            return Math.PI * r * r;
        }

    }
}
