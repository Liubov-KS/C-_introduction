/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
k1 = 5, b1 = 2, k2 = 9, b2 = 4,-> (-0,5; -0,5)
*/

Console.WriteLine("Введите первый коэфициент первого уравнения (k1): ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй коэфициент первого уравнения (b1): ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый коэфициент второго уравнения (k2): ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй коэфициент второго уравнения (b2): ");
double b2 = Convert.ToInt32(Console.ReadLine());

void CrossPoint(double y1, double x1, double y2, double x2)
{
    double x = 0;
    double y = 0;

    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны, нет общих точек пересечения.");
    if (k1 == k2 && b1 == b2) Console.WriteLine("Коэфициенты равны, прямые совпадают друг с другом.");

    x = (b2-b1)/(k1-k2);
    y = k2*x+b2;

    Console.WriteLine($"Координаты точки пересения: х = {x}, y = {y}.");
}

CrossPoint(k1, b1, k2, b2);