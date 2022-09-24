//Девочка и 2 мальчика делают кораблики. Девочка делает в 2 раза больше, чем оба мальчика вместе.
// Дается общая сумма корабликов, определить, кто сколько сделал.
using static System.Console;

Clear();
Write("Общее количество сделанных корабликов: ");
int num = int.Parse(ReadLine()!);


double boy = Math.Round((Convert.ToDouble(num)) / 6, 2);
double girl = Math.Round(4 * boy, 2);


WriteLine($"Девочка сделала {girl} корабликов");
WriteLine($"Мальчики сделали по {boy} корабликов");
