// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

using static System.Console;

Clear();
WriteLine("Введите пятизначное число: ");
int number = int.Parse(ReadLine()!);
int sameNumber = number;

if (number / 10000 < 1 || number / 10000 >= 10)
{
    WriteLine("Введенное число не является пятизначным");
    return;
}

string result = string.Empty;
while (number > 0)
{
    result += number % 10;
    number /= 10;
}
int newNumber = int.Parse(result);
if (newNumber == sameNumber)
{
    WriteLine($"Введенное число {sameNumber} является палиндромом");
}
else
{
    WriteLine($"Введенное число {sameNumber} - не палиндром");
}

