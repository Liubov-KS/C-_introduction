Console.WriteLine("Введите число для вычисления набора квадратов: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int square = 0;

while (count <= num)
{
    square = count*count;
    Console.WriteLine($"{count, 3} -> {square, 3} ");
    count++;
}