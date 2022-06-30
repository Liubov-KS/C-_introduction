/*
    Напишите программу, которая принимает на вход 
    координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

// блок ввода координат точки А
Console.WriteLine("Введите координату X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());

// блок ввода координат точки В
Console.WriteLine("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

// расстояние между точками AB = √(xb - xa)^2 + (yb - ya)^2 + (zb-za)^2
double distance =                
(Math.Round(                     // округляем результат до 2 знаков после запятой
 Math.Sqrt                       // квадратный корень
(Math.Pow((xb-xa), 2) +          // (xb - xa)^2
 Math.Pow((yb-ya), 2) +          // (yb - ya)^2
 Math.Pow((zb-za), 2)),          // (zb - za)^2
 2));                            // 2 знака после запятой для Math.Round

Console.WriteLine(distance);