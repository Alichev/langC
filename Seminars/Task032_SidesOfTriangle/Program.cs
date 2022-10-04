// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
using static System.Console;

Clear();
WriteLine("Введите длины сторон треугольника через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(parameters[0]);
int b = int.Parse(parameters[1]);
int c = int.Parse(parameters[2]);
CheckTriangle(a, b, c);


void CheckTriangle(int x, int y, int z)
{
    if (x + y > z && x + z > y && y + z > x)
    {
        WriteLine($"Треугольник со сторонами {x}, {y} и {z} может существовать");
    }
    else
    {
        WriteLine($"Треугольник со сторонами {x},{y} и {z} НЕ МОЖЕТ существовать");
    }
}