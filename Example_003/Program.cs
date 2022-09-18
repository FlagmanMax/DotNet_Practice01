using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели: ");
            int DayNum = Convert.ToInt32(Console.ReadLine());

            if (DayNum == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (DayNum == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (DayNum == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (DayNum == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (DayNum == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (DayNum == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (DayNum == 7)
            {
                Console.WriteLine("Воскресенье");
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
