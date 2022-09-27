// Напишите программу, которая реализует метод, который принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
using static System.Console;

Clear();
Write("Введите число: ");
int A = int.Parse(ReadLine()!);
int result = GetSum(A);
WriteLine($"Сумма чисел от 1 до А равна {result}");



// int GetSum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number; // sum+=number;
//         number--;
//     }
//     return sum;
// }

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum += i;
    }
    return sum;
}