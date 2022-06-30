/* 
    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    является ли оно палиндромом.
    14212 -> нет
    23432 -> да
    12821 -> да 
*/

// писать будем общий алгоритм, который будет работать не только для пятизначных чисел.

Console.WriteLine("Введите число для проверки на палиндромность: ");
int num = Convert.ToInt32(Console.ReadLine());

object ToListConvertor(int a)
{
    int index = 0;
    List<int> number = new List<int> {};
    while (a / 10 != 0)
    {
        number.Add(a%10);
        a = a / 10;
        index ++;
    }
    int [] number2 = number.ToArray<int>();
    return number2;    
}

var resultlist = ToListConvertor(num);
Console.WriteLine(resultlist);