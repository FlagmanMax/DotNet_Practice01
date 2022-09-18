// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите число a: ");
int var1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int var2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int var3 = Convert.ToInt32(Console.ReadLine());

int max = 0;


if (var1 > max)
{
    max = var1;
}

if (var2 > max)
{
    max = var2;
}

if (var3 > max)
{
    max = var3;
}

Console.WriteLine("max = " +max);
