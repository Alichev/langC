// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
using static System.Console;

Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] Array = GetArray(length);
WriteLine($"[{String.Join(", ", Array)}]");
Write("Введите число: ");
int num = int.Parse(ReadLine()!);
CheckNumberInArray(Array, num);




int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 11);
    }
    return result;
}

void CheckNumberInArray(int[] inArray, int number)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] == number)
        {
            WriteLine($"Да, число {number} есть в массиве");
            return;
        }
    }
    WriteLine($"Нет, числа {number} нет в массиве");
}