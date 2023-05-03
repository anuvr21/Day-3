using System;


namespace EligibleToVote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age=int.Parse(Console.ReadLine());
             if(age>=18)
            {
                Console.WriteLine("You're eligible to vote");
            }
             else { Console.WriteLine("You're not eligible"); }
        }
    }
}
