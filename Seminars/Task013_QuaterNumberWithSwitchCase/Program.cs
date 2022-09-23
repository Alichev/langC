// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)
using static System.Console;

Clear();
WriteLine("Введите номер четверти в системе координат: ");
int number = int.Parse(ReadLine()!);

// if (number < 1 || number > 4)
// {
//     WriteLine("ERROR!");
//     return;
// }
// if (number == 1)
// {
//     WriteLine("X>0, Y>0");
// }
// if (number == 2)
// {
//     WriteLine("X<0, Y>0");
// }
// if (number == 3)
// {
//     WriteLine("X<0, Y<0");
// }
// if (number == 4)
// {
//     WriteLine("X>0, Y<0");
// }

switch (number)
{
    case 1:
        {
            WriteLine("X>0, Y>0");
            break;
        }
    case 2:
        {
            WriteLine("X<0>, Y>0");
            break;
        }
    case 3:
        {
            WriteLine("X<0, Y<0");
            break;
        }
    case 4:
        {
            WriteLine("X>0, Y<0");
            break;
        }
    default:
        {
            WriteLine("ERROR!");
            break;
        }
}