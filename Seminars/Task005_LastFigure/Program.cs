using static System.Console;

Clear();
Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write(num1 % 10);