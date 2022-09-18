// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).


Console.Write("Введите число a: ");
int var1 = Convert.ToInt32(Console.ReadLine());

if (var1 % 2 == 0)
{
    Console.WriteLine("Число "+var1 + " четное");
}
else
{
    Console.WriteLine("Число "+var1 + " не четное");
}

