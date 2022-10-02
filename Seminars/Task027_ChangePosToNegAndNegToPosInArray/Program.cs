// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
using static System.Console;

Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);

int[] Array = GetArray(length, min, max);
WriteLine($"[{String.Join(", ", Array)}]");
ChangeArray(Array);
WriteLine($"[{String.Join(", ", Array)}]");





int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void ChangeArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = -inArray[i];
    }
}