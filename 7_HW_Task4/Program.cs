/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine()!);

int maximum = number_1;

if (number_2 > maximum) maximum = number_2;
if (number_3 > maximum) maximum = number_3;
Console.WriteLine($"Большее число: {maximum}");