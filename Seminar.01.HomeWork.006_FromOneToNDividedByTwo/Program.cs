// Должно ли работать в отрицательных числах?
Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) // Почему-то с правильными отступами для for программа решила не запускаться. Оставил, как есть. Работает - не трогай.
for (int i = 1; i <= number; i++)
{
    if (i%2 == 0)
    {
        Console.Write($"{i} ");
    }
}
else
for (int i = number; i <= 1; i++)
{
    if (i%2 == 0)
    {
        Console.Write($"{i} ");
    }
}