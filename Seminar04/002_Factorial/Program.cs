Console.WriteLine("Введите число для умножения: ");
int num = Convert.ToInt32(Console.ReadLine());

int Multi(int a)
{
    int multi = 1;
    for (int i = 1; i <= a; i++)
    {  
        multi = multi * i;
    }
    return multi;
}

int result = Multi(num);
Console.Write(result);