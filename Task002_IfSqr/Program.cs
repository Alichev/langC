using static System.Console;

Clear();
Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);

int sqr = Convert.ToInt32(Math.Pow(num2, 2));

if (num1 == sqr)
{
    WriteLine($"ДА, число {num1} является квадратом числа {num2}");
}
else
{
    WriteLine($"НЕТ, число {num1} не является квадратом числа {num2}");
}