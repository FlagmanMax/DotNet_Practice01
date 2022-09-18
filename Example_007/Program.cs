using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if ( n<=0)
            {
                Console.Write("Ошибка ввода!");  
            }
            else
            {
                int i = -n;
                while (i<=n)
                {
                    Console.Write(i+" ");
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
