// Циклы - взаимозаменяемы.

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string result = Method4(10, "Zzz");
Console.WriteLine(result);

// Циклы могут быть вложены друг в друга.

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}