/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
while (number > 1000)
{
    number = number /10;
}
if (-100 < number & number < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    number = number % 10;
    Console.Write($"{number}");
}