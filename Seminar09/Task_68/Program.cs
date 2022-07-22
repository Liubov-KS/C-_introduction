// Я вообще не понял, зачем эта задача. Я просто переписал определение функции из Вики.

int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}
int res = Akkerman(3, 2);
Console.Write(res);