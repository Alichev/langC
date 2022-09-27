// Напишите метод, который посчитает количество заданных цифр (0 или 1) в бинарном массиве
using static System.Console;

Clear();
Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
Write("Введите цифру 0 или 1: ");
int digit = int.Parse(ReadLine()!);
int[] finalArray = GetBinaryArray(size);
PrintArray(finalArray);
WriteLine($"Количество цифр {digit} в массиве: {CountDigits(finalArray, digit)}");


int[] GetBinaryArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}

int CountDigits(int[] inArray, int dig)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] == dig)
        {
            count++;
        }
    }
    return count;
}