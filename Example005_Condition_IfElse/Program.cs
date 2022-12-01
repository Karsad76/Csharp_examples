Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Привет, Маша!");
}
else
{
    Console.Write("Здарова, "); Console.Write(username); Console.WriteLine("!");
}
