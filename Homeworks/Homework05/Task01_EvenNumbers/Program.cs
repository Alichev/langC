// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве
using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] Array = GetArray(length);
WriteLine($"[{String.Join(", ", Array)}]");
WriteLine($"Количество четных чисел в массиве: {GetEvenNumbers(Array)}");



int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}

int GetEvenNumbers(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] % 2 == 0)
        {
            count++;
        };
    }
    return count;
}