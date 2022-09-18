using static System.Console;

Clear();
Write("Введите номер дня недели: ");
int num1 = Convert.ToInt32(ReadLine()!);

if (num1 == 1)
{
    WriteLine("Понедельник");
}
else if (num1 == 2)
{
    WriteLine("Вторник");
}
else if (num1 == 3)
{
    WriteLine("Среда");
}
else if (num1 == 4)
{
    WriteLine("Четверг");
}
else if (num1 == 5)
{
    WriteLine("Пятница");
}
else if (num1 == 6)
{
    WriteLine("Суббота");
}
else if (num1 == 7)
{
    WriteLine("Воскресенье");
}
else
{
    WriteLine("Нет дня недели с таким номером");
}
