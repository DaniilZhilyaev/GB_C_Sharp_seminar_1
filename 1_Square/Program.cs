// напишите программу, которая на вход принимает число и выдает его квадрат

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

// Математический способ:
int sqr = number * number;
Console.WriteLine($"Квадрат числа: {sqr}");

// Библиотечый способ:
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа: {sqr1}");