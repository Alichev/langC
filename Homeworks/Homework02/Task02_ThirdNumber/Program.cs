// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
using static System.Console;

Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine()!);
if (number / 100 < 1)
{
    WriteLine("Третьей цифры справа в числе нет, в нем меньше 3 разрядов");
    return;
}

int result = (number - (number / 1000) * 1000 - number % 100) / 100;
WriteLine($"Третья цифра справа в числе: {result}");