// Напишите программу, которая реализует метод, который принимает на вход число N и выдаёт произведение чисел от 1 до N.
using static System.Console;

Clear();
Write("Введите число: ");
int N = int.Parse(ReadLine()!);
int result = GetMultiProduct(N);
WriteLine($"Произведение чисел от 1 до N равно {result}");



int GetMultiProduct(int number)
{
    int MultyProduct = 1;
    for (int i = 1; i <= number; i++)
    {
        MultyProduct = MultyProduct * i;
    }
    return MultyProduct;
}