/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
if (1 <= number & number <= 7)
{
    if (number == 6)
    {
        Console.Write($"{number} -> Да");
    }
    else if (number == 7)
    {
        Console.Write($"{number} -> Да");
    }
    else
    {
        Console.Write($"{number} -> Нет");
    }
}
else
{
     Console.Write($"{number} -> Это не день недели");
}