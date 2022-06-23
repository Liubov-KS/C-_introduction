Console.Write("Введите номер дня: ");
int daynumber = Convert.ToInt32(Console.ReadLine());
var days = new Dictionary<int, string>()
{
    {1, "понедельник"},
    {2, "вторник"},
    {3, "среда"},
    {4, "четверг"},
    {5, "пятница"},
    {6, "суббота"},
    {7, "воскресенье"}
};
if (days.ContainsKey(daynumber) == true)
{
    Console.Write($"{daynumber} день недели - это {days[daynumber]}");
}
else
{
    Console.Write("В неделе 7 дней. Введите число от 1 до 7.");
}