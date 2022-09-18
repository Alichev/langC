Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша")
{
    Console.WriteLine("Бааа, да это же наша Маша!");
}
else
{
    Console.Write("Привет, " + username + "!");
}