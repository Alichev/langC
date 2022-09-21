// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine()!);

if (num1 == 0)
{
    WriteLine("Введите число, отличное от нуля");
    return;
}

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    WriteLine($"Число {num1} кратно 7 и 23");
}
else
{
    WriteLine($"Число {num1} НЕ кратно 7 и 23");
}
