object MaxDigit(int num)
{
    int left = num / 10;
    int right = num % 10;
    if (left == right)
    {
        string equal = "Цифры одниковые";
        return equal;
    }
    return left > right ? left : right;
}

Console.Write(MaxDigit(10));