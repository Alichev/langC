// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
using static System.Console;

Clear();
Write("Введите координаты ПЕРВОЙ точки по оси Х: ");
int x1 = int.Parse(ReadLine()!);
Write("Введите координаты ПЕРВОЙ точки по оси Y: ");
int y1 = int.Parse(ReadLine()!);
Write("Введите координаты ПЕРВОЙ точки по оси Z: ");
int z1 = int.Parse(ReadLine()!);
Write("Введите координаты ВТОРОЙ точки по оси Х: ");
int x2 = int.Parse(ReadLine()!);
Write("Введите координаты ВТОРОЙ точки по оси Y: ");
int y2 = int.Parse(ReadLine()!);
Write("Введите координаты ВТОРОЙ точки по оси Z: ");
int z2 = int.Parse(ReadLine()!);

int sqrForX = Convert.ToInt32(Math.Pow(x2 - x1, 2));
int sqrForY = Convert.ToInt32(Math.Pow(y2 - y1, 2));
int sqrForZ = Convert.ToInt32(Math.Pow(z2 - z1, 2));
int sqrForDist = sqrForX + sqrForY + sqrForZ;

double dist = Math.Sqrt(sqrForDist);
WriteLine($"Расстояние между точками равно: {dist:f2}");
