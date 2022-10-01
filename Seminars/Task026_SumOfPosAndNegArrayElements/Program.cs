// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
using static System.Console;

Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);

int[] Array = GetArray(length, min, max);
//string strArray = String.Join(", ", Array);
WriteLine($"[{String.Join(", ", Array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in Array)
{
    // positiveSum+=element>0?element:0 //тернарный оператор - если элемент >0 - добавляем к сумме его, а иначе 0
    // negativeSum+=element<0?element:0
    if (element > 0)
    {
        positiveSum += element;
    }
    if (element < 0)
    {
        negativeSum += element;
    }
}
WriteLine($"Сумма положительных элементов: {positiveSum}");
WriteLine($"Сумма отицательных элементов: {negativeSum}");


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
