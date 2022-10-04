// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using static System.Console;
Clear();
WriteLine("Введите размер массива, мин и макс значение через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
WriteLine($"[{String.Join(", ", array)}]");
WriteLine($"[{String.Join(", ", reverseArray1(array))}]");
reverseArray2(array);
WriteLine($"[{String.Join(", ", array)}]");



int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(MinValue, MaxValue + 1);
    }
    return result;
}

int[] reverseArray1(int[] inArray) // метод создания нового массива
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }

    return result;
}


void reverseArray2(int[] inArray) // метод разворачивания текущего массива
{
    for (int i = 0; i < inArray.Length / 2; i++) // идем до середины массива, чтобы развернуть его 1 раз
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}