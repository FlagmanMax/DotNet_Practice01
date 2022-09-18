// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
Console.Write("Введите число a: ");
int var1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int var2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (var1 > var2)
{
    max = var1;
    min = var2;
}
else if (var1 < var2)
{
    max = var2;
    min = var1;
}
else
{
    max = var1;
    min = var1;
}

Console.WriteLine("max = " +max);
Console.WriteLine("min = " +min);
