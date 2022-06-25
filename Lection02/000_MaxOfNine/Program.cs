int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 11;
int b = 85;
int c = 35;
int d = 17;
int e = 72;
int f = 84;
int g = 12;
int h = 45;
int j = 33;

int max1 = Max(a, b, c);
int max2 = Max(d, e, f);
int max3 = Max(g, h, j);

int maxfinal = Max(max1, max2, max3);
Console.Write(maxfinal);