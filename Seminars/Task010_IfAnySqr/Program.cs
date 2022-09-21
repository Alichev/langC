// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
using static System.Console;

Clear();
Write("Введите первое число: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите второе число: ");
int num2 = Convert.ToInt32(ReadLine()!);

if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

int sqr = Convert.ToInt32(Math.Pow(num1, 2));

if (num2 == sqr)
{
    WriteLine($"ДА, число {num2} является квадратом числа {num1}");
}
else
{
    WriteLine($"НЕТ, число {num2} не является квадратом числа {num1}");
}