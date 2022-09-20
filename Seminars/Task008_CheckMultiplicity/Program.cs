// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
using static System.Console;

Clear();
Write("Введите первое число: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите второе число: ");
int num2 = Convert.ToInt32(ReadLine()!);

if (num1 == 0)
{
    WriteLine("На ноль делить нельзя");
}
else
{
    int reminder = num2 % num1;
    if (reminder == 0)
    {
        WriteLine($"Второе число {num2} кратно первому числу {num1}");
    }
    else
    {
        WriteLine($"Второе число {num2} не кратно первому числу {num1}, остаток от деления составляет {reminder}");
    }
}