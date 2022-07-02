// Метод, который ничего не принимает и не возвращает.

void Method1()
{
    Console.WriteLine("Автор программы Николай Беляев");
}

Method1();

// Метод, который что-то принимает, но ничего не возвращает.

void Method2(string msg)
{
    Console.WriteLine($"Автор программы {msg}");
}

Method2("Иван Петров");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine($"Это сообщение: {msg} выведено на экран {count} раз");
        i++;
    }
}

Method21("Помой посоду", 3);

// Методы, которые ничего не принимают, но что-то возвращают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Методы, которые что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string result = Method4(10, "Zzz");
Console.WriteLine(result);