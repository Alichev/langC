// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
using static System.Console;

Clear();
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine()!);
int num1 = 1;

while (num1 <= num)
{
    if (num1 % 2 == 0)
    {
        Write($"{num1} ");
    }
    num1++;
}