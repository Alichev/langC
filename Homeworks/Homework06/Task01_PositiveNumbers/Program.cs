// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
using static System.Console;

Clear();
WriteLine("Введите 5 чисел через пробел: ");
string[] pars = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = { int.Parse(pars[0]), int.Parse(pars[1]), int.Parse(pars[2]), int.Parse(pars[3]), int.Parse(pars[4]) };
WriteLine($"Вы ввели {CountPositiveNumbers(array)} чисел больше нуля");





int CountPositiveNumbers(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}