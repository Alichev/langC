// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла
using static System.Console;

Clear();
Write("Введите число, которое будем возводить в степень: ");
int A = int.Parse(ReadLine()!);
Write("Введите значение степени: ");
int B = int.Parse(ReadLine()!);
int result = GetExpon(A, B);
WriteLine($"Число {A} в степени {B} равно {result}");



int GetExpon(int x, int y)
{
    int total = Convert.ToInt32(Math.Pow(x, y));
    return total;
}