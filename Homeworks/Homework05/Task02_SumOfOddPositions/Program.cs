// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
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
WriteLine($"Сумма элементов на нечетных позициях: {GetSumOfOddPositions(Array)}");



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

int GetSumOfOddPositions(int[] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + inArray[i];
        };
    }
    return sum;
}