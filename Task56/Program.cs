/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Укажите количество строк в дмумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в дмумерном массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows, colums, min, max);
int minRows= MinRowsMatrix(array) + 1;
PrintMatrixInt(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRows}");

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}
int MinRowsMatrix(int[,] array)
{
    int min = 0;
    int count = 0;
    int countRows = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min += array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count += array[i, j];
        }
        if (min > count)
        {
            min = count;
            countRows = i;
        }
        count = 0;
    }
    return countRows;
}
void PrintMatrixInt(int[,] array, int round = 1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}