using System;


namespace AbsoluteDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, result;
            Console.WriteLine("Enter number:");
            n=int.Parse(Console.ReadLine());
            result = AbsDif(n);
            Console.WriteLine("Absolute Difference is " + result);
        }
        static int AbsDif(int n)
        {
            int result = 0;
            if(n>51)
            {
                result = Math.Abs(3 * (n - 51));
            }
            else 
            {
                result = Math.Abs(n - 51);
            }
            return result;
        }
    }
}
