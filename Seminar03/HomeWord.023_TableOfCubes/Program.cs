Console.WriteLine("Введите число для вычисления набора кубов: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
double cube = 0; // потому что Math хочет double.

while (count <= num)
{
    cube = Math.Pow(count, 3); // можно было бы count 3 раза сам на себя умножить, но таким способом я квардраты считал.
    Console.WriteLine($"{count, 3} -> {cube, 3} ");
    count++;
}