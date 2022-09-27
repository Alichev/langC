// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int result = GetSum(number);
WriteLine($"Сумма цифр числа {number} составляет {result}");



int GetSum(int num)
{
    int sum = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;
}