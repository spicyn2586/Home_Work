/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.WriteLine("Укажите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение :");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(number, max, min);
double difference = SearchMax(array) - SearchMin(array);
PrintArrayDouble(array);
Console.Write($" -> {Math.Round(SearchMax(array), 1)} - {Math.Round(SearchMin(array), 1)} = {Math.Round(difference, 1)}");

double[] CreateArrayRndDouble(int size, int max, int min)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArrayDouble(double[] array, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        double num = Math.Round(array[i], round);
        if (i < array.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }
    Console.Write("]");
}

double SearchMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double SearchMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
