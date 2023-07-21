/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Укажите количество строк в дмумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в дмумерном массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows,colums,min,max);
double[] ArithmeticMean = ArithmeticMeanColums(array);
PrintMatrixInt(array);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArrayDouble(ArithmeticMean);

double[] ArithmeticMeanColums(int[,] array)
{
    double[] array1 = new double[array.GetLength(1)];
    double summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i,j];
        }

        array1[j] = summ / array.GetLength(0);
        summ = 0;
    }
    return array1;
}
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
void PrintArrayDouble(double[] array, int round = 1)
{
    for (int i = 0; i < array.Length; i++)
    {
        double num = Math.Round(array[i], round);
        if (i < array.Length - 1) Console.Write($"{num}; ");
        else Console.Write($"{num}");
    }
}