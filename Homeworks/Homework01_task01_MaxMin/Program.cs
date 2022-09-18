// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;

Clear();
Write("Введите первое число: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите второе число: ");
int num2 = Convert.ToInt32(ReadLine()!);

if (num1 > num2)
{
    WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 == num2)
{
    WriteLine("Введенные числа равны");
}
else
{
    WriteLine($"Число {num1} меньше числа {num2}");
}