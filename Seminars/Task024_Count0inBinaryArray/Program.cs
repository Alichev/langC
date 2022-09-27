// Напишите метод, который посчитает количество нулей в бинарном массиве
using static System.Console;

Clear();
Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
int[] finalArray = GetBinaryArray(size);
PrintArray(finalArray);
WriteLine($"Количество нулей в массиве: {CountZeroes(finalArray)}");


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

int CountZeroes(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] == 0)
        {
            count++;
        }
    }
    return count;
}