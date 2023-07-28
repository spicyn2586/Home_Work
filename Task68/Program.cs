/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите число M");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > 0 && number2 > 0)
{
    int Ackerman = AckermanFunctions(number1, number2);
    Console.Write($"M = {number1}; N = {number2} -> {Ackerman}");
}
else
{
    Console.WriteLine("Одно или несколько чисел не являются натуральными");
}


int AckermanFunctions(int number1, int number2)
{
    while (number1 != 0)
    {
        if (number2 == 0) number2 = 1;
        else number2 = AckermanFunctions(number1, number2 - 1);
        number1--;
    }
    return number2 + 1;
}