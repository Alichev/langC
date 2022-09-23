// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
using static System.Console;

Clear();
Write("Введите координаты ПЕРВОЙ точки по оси Х: ");
int x1 = int.Parse(ReadLine()!);
Write("Введите координаты ПЕРВОЙ точки по оси Y: ");
int y1 = int.Parse(ReadLine()!);
Write("Введите координаты ВТОРОЙ точки по оси Х: ");
int x2 = int.Parse(ReadLine()!);
Write("Введите координаты ВТОРОЙ точки по оси Y: ");
int y2 = int.Parse(ReadLine()!);

// if (x1 > x2)
// {
//     int temp1 = x1;
//     x1 = x2;
//     x2 = temp1;
// }
// if (y1 > y2)
// {
//     int temp2 = y1;
//     y1 = y2;
//     y2 = temp2;
// }

int sqrForX = Convert.ToInt32(Math.Pow(x2 - x1, 2));
int sqrForY = Convert.ToInt32(Math.Pow(y2 - y1, 2));
int sqrForDist = sqrForX + sqrForY;

// WriteLine($"Квадрат первого катета: {sqrForX}");
// WriteLine($"Квадрат первого катета: {sqrForY}");
// WriteLine($"Квадрат гипотенузы: {sqrForDist}");

double dist = Math.Sqrt(sqrForDist);

WriteLine($"Расстояние между точками равно: {dist:f2}");
