/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
в условиях задачи не сказано, что основание степени обязательно натуральное число. 
пользователь коварен, так что найдейся на лучшее, готовься к худшему - используй double!
*/

Console.WriteLine("Введите основание степени: ");
double b = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите показатель степени: ");
int p =  Convert.ToInt32(Console.ReadLine());

double Pow(double basis, int power)
{
    double result = 1;
    if (power == 0)
    {
        return result;
    }
    else
    {
        for (int i = 1; i <= power; i++)
        {
            result *= basis;
        }
        return result;
    }

}

double final = Pow(b, p);
Console.Write($"Если {b} возвести в степень {p}, то получится {final}.");