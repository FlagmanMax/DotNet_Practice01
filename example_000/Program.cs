using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value x : ");
            double inputValue = 0;
            double square = 0;
            inputValue = Convert.ToDouble(Console.ReadLine());
            square = inputValue*inputValue;
            Console.WriteLine($"{inputValue} * {inputValue} = {square}");
        }
    }
}
