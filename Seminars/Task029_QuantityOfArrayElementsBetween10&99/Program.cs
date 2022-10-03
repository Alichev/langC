// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
using static System.Console;

Clear();
int[] Array = GetArray(20);
WriteLine($"[{String.Join(", ", Array)}]");
FindQuantityInArray(Array);


int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-500, 500);
    }
    return result;
}

void FindQuantityInArray(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] >= 10 && inArray[i] <= 99)
        {
            count++;
        }
    }
    WriteLine($"В интервал от 10 до 99 попадает {count} элементов массива");
}