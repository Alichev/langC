// Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран
using static System.Console;

Clear();
int[] Array = GetArray();
PrintArray(Array);

int[] GetArray()
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {
        result[i] = new Random().Next(0, 100);
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