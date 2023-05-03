//Area of the circle
using System;


namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 0.0, area;
            Console.WriteLine("Enter the radius of the circle");
            radius=double.Parse(Console.ReadLine());
            area=CalcArea(radius); //Function call
            Console.WriteLine($"Area of circle {area}");
        }
        static double CalcArea(double radius) //Function definition
        {
            double area = 0.0;
            area = 3.14 * radius * radius;
            return area;
        }
    }
}
