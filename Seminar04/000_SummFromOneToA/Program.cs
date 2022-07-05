Console.WriteLine("Введите число для суммирования: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {  
        summ += i;
    }
    return summ;
}

int result = Sum(num);
Console.Write(result);