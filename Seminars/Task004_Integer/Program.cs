using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine()!);
int num2 = -num1;

while (num2 <= num1)
{
    Write($"{num2} ");
    num2++;
}
