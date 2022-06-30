Console.WriteLine("Введите координату X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

double distance =                // расстояние между точками AB = √(xb - xa)2 + (yb - ya)2
(Math.Round(                     // округляем результат до 2 знаков после запятой
 Math.Sqrt                       // квадратный корень
(Math.Pow((xa-xb), 2) +          // (xb - xa)^2
 Math.Pow((ya-yb), 2)), 2));     // (yb - ya)^2, 2 знака после запятой для Math.Round

Console.WriteLine(distance);