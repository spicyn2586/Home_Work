/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение :");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i= 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max + 1);
    Console.Write($"{array[i]}, ");
}
Console.Write("-> [");
for (int i= 0; i < array.Length; i++)
{
    if (i < array.Length - 1)Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
}
Console.Write("]");