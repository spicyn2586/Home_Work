/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 0)
{
    Console.Write($"N = {number} -> ");
    NaturalNumbers(number);
}
else
{
    Console.WriteLine("Число не является натуральным");
}


void NaturalNumbers(int number)
{
    if (number == 0) return;
    if (number != 1)
    {
        Console.Write($"{number}, ");
    }
    else
    {
        Console.Write($"{number}");
    }
    NaturalNumbers(number - 1);
}