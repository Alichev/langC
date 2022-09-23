// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка
using static System.Console;

Clear();
Write("Введите координаты точки по оси Х: ");
int numX = int.Parse(ReadLine()!);
Write("Введите координаты точки по оси Y: ");
int numY = int.Parse(ReadLine()!);

if (numX == 0 && numY == 0)
{
    WriteLine("Это точка начала осей координат: (0,0)");
    return;
}
if (numX == 0 || numY == 0)
{
    WriteLine("Точка находится на оси");
    return;
}
if (numX > 0 && numY > 0)
{
    WriteLine("Точка находится в I четверти");
    return;
}
if (numX > 0 && numY < 0)
{
    WriteLine("Точка находится в IV четверти");
    return;
}
if (numX < 0 && numY > 0)
{
    WriteLine("Точка находится во II четверти");
    return;
}
if (numX < 0 && numY < 0)
{
    WriteLine("Точка находится в III четверти");
    return;
}