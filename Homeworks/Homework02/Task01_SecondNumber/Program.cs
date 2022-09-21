// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
using static System.Console;

Clear();
int number = new Random().Next(100, 999 + 1);
WriteLine(number);

int a0 = number % 10;
int a2 = number / 100;

int a1 = (number - (a2 * 100 + a0)) / 10;
WriteLine(a1);
