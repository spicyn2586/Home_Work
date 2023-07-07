/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine($"{number} ->");
while (i <= number)
{
    Square(i);
    i++;
}

int Square (int sqr)
{
    double sqrs = Math.Pow(sqr, 3);
    Console.WriteLine($"{sqr} | {sqrs}");
    return sqr;
}