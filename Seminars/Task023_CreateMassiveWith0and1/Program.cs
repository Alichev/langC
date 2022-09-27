// Напишите программу, которая вызывает метод, который выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
using static System.Console;

Clear();
Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
int[] finalArray = GetBinaryArray(size);
PrintArray(finalArray);


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
    Write($"{inArray[inArray.Length - 1]}]");
}