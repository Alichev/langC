// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем

using static System.Console;
Clear();
WriteLine("Введите значение b1: ");
int b1 = int.Parse(ReadLine()!);
WriteLine("Введите значение k1: ");
int k1 = int.Parse(ReadLine()!);
WriteLine("Введите значение b2: ");
int b2 = int.Parse(ReadLine()!);
WriteLine("Введите значение k2: ");
int k2 = int.Parse(ReadLine()!);
WriteLine($"Координаты точки пересечения: ({String.Join(", ", GetCrossPoint(b1, k1, b2, k2))})");


double[] GetCrossPoint(double bb1, double kk1, double bb2, double kk2)
{
    double[] result = new double[2];
    result[0] = (bb2 - bb1) / (kk1 - kk2);
    result[1] = kk1 * (bb2 - bb1) / (kk1 - kk2) + bb1;
    return result;
}