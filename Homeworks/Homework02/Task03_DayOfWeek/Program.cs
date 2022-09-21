// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
using static System.Console;

Clear();
Write("Введите цифру дня недели от 1 до 7: ");
int number = Convert.ToInt32(ReadLine()!);

if (number < 1 || number > 7)
{
    WriteLine($"День недели может принимать значение от 1 до 7");
    return;
}

WriteLine(number == 6 || number == 7 ? "Это выходной день" : "Это рабочий день");