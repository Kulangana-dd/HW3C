/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.WriteLine("Введите координаты точки A:");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z3 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

int dx = x2 - x1;
int dy = y2 - y1;
int dz = z2 - z1;
double distance = Math.Round(Math.Sqrt(dx * dx + dy * dy + dz * dz), 2);

Console.WriteLine($"Расстояние между точками A и B в 3D пространстве = {distance}");