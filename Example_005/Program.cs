using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            int Power(int x)
            {
                return x*x;
            }

            Console.WriteLine("x^2 = "+Power(x));
        }
    }
}