/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.WriteLine("Укажите количество строк в дмумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в дмумерном массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows,colums,min,max);
PrintMatrixInt(array);
Console.WriteLine($"В итоге получается вот такой массив: ");
array = SortColumsMatrix(array);
PrintMatrixInt(array);

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
int[,] SortColumsMatrix(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    count = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = count;
                 }
         } 
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