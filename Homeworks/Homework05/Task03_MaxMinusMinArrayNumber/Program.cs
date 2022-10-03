// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
double[] Array = GetArray(length);
WriteLine($"[{String.Join(", ", Array)}]");
WriteLine($"Максимальное число: {GetMaxNumber(Array)}");
WriteLine($"Минимальное число: {GetMinNumber(Array)}");
WriteLine($"Разница между ними: {GetMaxNumber(Array) - GetMinNumber(Array)}");



double[] GetArray(int size)
{
    Random rnd = new Random();
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 100);
    }
    return result;
}

double GetMaxNumber(double[] inArray)
{
    double maxNumber = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > maxNumber)
        {
            maxNumber = inArray[i];
        };
    }
    return maxNumber;
}

double GetMinNumber(double[] inArray)
{
    double minNumber = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] < minNumber)
        {
            minNumber = inArray[i];
        };
    }
    return minNumber;
}