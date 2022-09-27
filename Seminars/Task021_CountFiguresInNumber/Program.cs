// Напишите программу, которая реализует метод, который принимает на вход число и выдаёт количество цифр в числе.
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int result = CountFigures(number);
WriteLine($"Количестов цифр в числе {number} = {result}");



int CountFigures(int N)
{
    int i = 0;
    while (N > 0)
    {
        N = N / 10;
        i++;
    }
    return i;
}