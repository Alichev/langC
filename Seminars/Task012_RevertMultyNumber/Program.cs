// развернуть многоразрядное число
using static System.Console;

Clear();
WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
string result = string.Empty;
while (number > 0)
{
    result += number % 10;
    number /= 10;
}
int newNumber = int.Parse(result);
WriteLine(newNumber);
