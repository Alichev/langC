// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
using static System.Console;

Clear();
Write("Введите число: ");
int num = int.Parse(ReadLine()!);
int i = 1;

while (i < num + 1)
{
    Write($"{Math.Pow(i, 2)}, ");
    i++;
}