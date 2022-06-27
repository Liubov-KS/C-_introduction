Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());


string Multiplicity(int num1, int num2)
{
        if (num1 % num2 == 0)
    {
        string result = $"{firstNum} делится на {secondNum} без остатка.";
        return result;
    }
    else
    {
        int leftover = firstNum % secondNum;
        string result = $"Остаток от деления {firstNum} на {secondNum} = {leftover}.";
        return result;
    }
}

Console.WriteLine(Multiplicity(firstNum, secondNum));