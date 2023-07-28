/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());
int count;
if (number1 > 0 && number2 > 0)
{
    if (number1 > number2)
    {
        count = number1;
        number1 = number2;
        number2 = count;
    }
    int sum = SumNaturalNambers(number1, number2);
    Console.Write($"N = {number1}; M = {number2} -> {sum}");
}
else
{
    Console.WriteLine("Одно или несколько чисел не являются натуральными");
}

int SumNaturalNambers(int number1, int number2)
{
    int sum;
    if (number1 > number2) return 0;
    sum = number1 + SumNaturalNambers(number1 + 1, number2);
    return sum;
}