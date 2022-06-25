Console.Write("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine());
int[] Massive ={1, 2, 3, 4, 5, 6, 7, 8};

void ElemFind(int[] array, int elem)
{
    int i = 0;
    while (i < array.Length-1)
    {
        if (array[i] == elem)
        {
            Console.Write($"{elem} есть в массиве");
            break;
        }
        i++;
    }
    
}

ElemFind(Massive, find);