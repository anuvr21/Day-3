using System;
namespace SumOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int result;
            Console.WriteLine("Enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = int.Parse(Console.ReadLine());
            result = Sum(a, b);
            Console.WriteLine("Sum is " + result);
        }
        static int Sum(int a, int b)
        {
            int result = 0;
            if (a == b)
            {
                result = (3 * (a + b));
            }
            else
            {
                result = a + b;
            }
            return result;
        }
    }
}

