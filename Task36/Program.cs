/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Укажите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(number);
PrintArray(arr);
Console.Write($" -> {SumOddNumbers(arr)}");

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int SumOddNumbers(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2) // Счет вел с 0, в случае если счет начинается с 1 "int i = 1" заменить на "int i = 0"
    {
        count += array[i];
    }
    return count;
}