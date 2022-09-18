using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x1 == x2^2? : ");
            if (x1 == (x2*x2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
