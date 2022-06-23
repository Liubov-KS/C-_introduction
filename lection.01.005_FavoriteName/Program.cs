Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вася")
{
    Console.WriteLine("Ура, это Вася!");
}
else
{
    Console.WriteLine("Привет");
}