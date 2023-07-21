/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
double[,] a = CreateMatrixRnddouble(4,4,-10,10);
PrintMatrixDouble(a);

double[,] CreateMatrixRnddouble(int rows, int colums, int min, int max)
{
    double[,] array = new double[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.NextDouble() * (max - min) + min;
        }
        
    }
    return array;
}
void PrintMatrixDouble(double[,] array, int round = 1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double num = Math.Round(array[i,j], round);
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}