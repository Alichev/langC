// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
using static System.Console;

Clear();
int[] Array = GetArray(11);
WriteLine($"[{String.Join(", ", Array)}]");


int[] resultArray = GetMultiplyNumbers(Array);
WriteLine($"[{String.Join(", ", resultArray)}]");








int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-5, 6);
    }
    return result;
}

int[] GetMultiplyNumbers(int[] inArray)
{
    int newArrLength = inArray.Length % 2 == 0 ? inArray.Length / 2 : inArray.Length / 2 + 1;
    int[] newArr = new int[newArrLength];

    for (int i = 0; i < inArray.Length / 2; i++)
    {
        newArr[i] = inArray[i] * inArray[inArray.Length - 1 - i];
    }
    if (inArray.Length % 2 != 0)
    {
        newArr[newArrLength - 1] = inArray[inArray.Length / 2];
    }
    return newArr;
}