// Разверните трехзначное число
using static System.Console;

Clear();
Write("Введите трехзначеное число: ");
int number = Convert.ToInt32(ReadLine()!);

if (number < 100 || number > 999)
{
    WriteLine("Число должно быть трехзначным!");
    return;
}

int a0 = number % 10;
int a2 = number / 100;
int a1 = number - a2 * 100 - a0;

int result = a0 * 100 + a1 + a2;
WriteLine(result);