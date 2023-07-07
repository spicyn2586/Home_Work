/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координату X точки 1");
int numberX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 1");
int numberY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 1");
int numberZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки 2");
int numberX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 2");
int numberY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 2");
int numberZ2 = Convert.ToInt32(Console.ReadLine());
double distance = Distance(numberX1, numberY1, numberZ1, numberX2, numberY2, numberZ2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({numberX1},{numberY1},{numberZ1}); B ({numberX2},{numberY2},{numberZ2} -> {distanceRound})");
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
   double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
   return distance;
}