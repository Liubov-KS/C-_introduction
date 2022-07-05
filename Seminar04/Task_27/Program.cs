/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число для нарезки в салат: ");
int num = Convert.ToInt32(Console.ReadLine());

int ChopAndSum(int a)
{                                       
    int salad = 0;
    if (a < 0) a = -a;
    while (a != 0)
    {
        salad += a%10;
        a /= 10;
    }
    return salad;
}

int choped = ChopAndSum(num);
Console.Write($"Если нарезать {num} на цифры и найти сумму этих цифр, то получится {choped}.");