/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет */

Console.WriteLine("Укажите количество строк в дмумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в дмумерном массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки :");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца :");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows,colums,min,max);
int rows1 = number1 - 1;
int colums1 = number2 - 1;
PrintMatrixInt(array);
if (rows1 >= 0 & rows1 < array.GetLength(0))
    {
        if (colums1 >= 0 & colums1 < array.GetLength(1)) Console.WriteLine($"{number1, 4}, {number2} -> {array[rows1,colums1]}");
        else Console.WriteLine($"{number1, 4}, {number2} -> такого элемента в массиве нет");
    }
else Console.WriteLine($"{number1, 4}, {number2} -> такого элемента в массиве нет");

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i,j] = new Random().Next(min, max);
        } 
    }
    return array;
}
void PrintMatrixInt(int[,] array, int round = 1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 4} ");
        }
        Console.WriteLine();
    }
}