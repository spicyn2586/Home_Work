/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Укажите количество строк в дмумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в дмумерном массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите количество строк в дмумерном массиве: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в дмумерном массиве: ");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows, colums, min, max);
int[,] array1 = CreateMatrixRndInt(rows1, colums1, min1, max1);
if (array.GetLength(1) == array1.GetLength(0))
{
    int[,] array2 = ProductMatrixRndInt(array, array1);
    PrintMatrixInt(array);
    Console.WriteLine("");
    PrintMatrixInt(array1);
    Console.WriteLine("Результирующая матрица будет:");
    PrintMatrixInt(array2);
}
else
{
    Console.WriteLine("Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");
}


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

int[,] ProductMatrixRndInt(int[,] multiplier1, int[,] multiplier2)
{
    int count = 0;
    int[,] product = new int[multiplier1.GetLength(0), multiplier2.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            for (int k = 0; k < multiplier1.GetLength(1); k++)
            {
                count += multiplier1[i, k] * multiplier2[k, j];
            }
            product[i, j] = count;
            count = 0;
        }
    }
    return product;
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