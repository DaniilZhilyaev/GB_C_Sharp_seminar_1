/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ои первое число квадратом второго

a = 25; b = 5 -> yes
a = 2; b = 10 -> no */

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);

if(number_1 == Convert.ToInt32(Math.Pow(number_2, 2)))
{
    Console.WriteLine("Yes");
}
else
{
        Console.WriteLine("No");
}
