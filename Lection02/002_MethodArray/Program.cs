Console.Write("Введите число: ");
int elem = Convert.ToInt32(Console.ReadLine());
int[] Massive ={1, 2, 3, 4, 5, 6, 7, 8};

int ElemFind(int[] array, int elem)
{
    foreach (int i in array)
    {
        if (i == elem)
        {
            Console.Write($"{elem} есть в массиве");
            break;
        }
        Console.Write($"{elem} не найден в массиве");    
    }
    return;
}

ElemFind(Massive, elem);