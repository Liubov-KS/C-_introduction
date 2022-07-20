/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)
*/


// Сделать неповторяющиеся элементы можно несколькими способами.
// 1. генерить элементы по возрастанию от 10 до 99. Все они, что характерно, будут неповторяющимися. Скучно.
// 2. после каждой генерации очередного rnd пробегать по матрице и смотреть, есть ли такой элемент, а если есть - генерить новый. 
//    можно наверное даже через рекурсию. Много for, плохо читается, кое-как масштабируется 
// 3. сгенирить все 2-значные числа в массив в случайном порядке и тянуть оттуда по очереди. Норм вариант, но с недостатком.


int[,,] MatrixOfUnrepeatedInt3D(int x, int y, int z)
{
    // нам понадобится: трехмерная матрица, одномерный массив, счетчик для массива, генератор рандома.
    int[,,] matrix = new int[x, y, z];
    int[] uniquesInRandomOrder = new int[90];
    int indexOfuniques = 0;
    Random rnd = new Random();

    // заполните одномерный массив числами от 10 до 99, вставляя числа в случайные места массива.
    for (int l = 10; l < 100; l++)
    {
        // если случайный индекс в массиве уже заполнен - сгенерите новый случайный индекс
        // плохо, что чем ближе к концу, тем чаще будут встречаться заполненные индексы
        while (uniquesInRandomOrder[indexOfuniques] != 0)
        {
            indexOfuniques = rnd.Next(0, 90);
        }
        uniquesInRandomOrder[indexOfuniques] = l;
    }

    // добавьте 1 счетчик для вытягивания элементов из вашего одномерного массива
    int indexFormatrix = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = uniquesInRandomOrder[indexFormatrix];
                indexFormatrix++;
            }
        }
    }
    return matrix;
}


void PrinterMatrix3D(int[,,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                count++;
                if (count < 10)
                {
                    Console.Write($"0{count} элемент матрицы =");
                }
                else
                {
                    Console.Write($"{count} элемент матрицы =");
                }
                Console.WriteLine($" {matrix[i, j, k]} и имеет индекс ({i}, {j} ,{k}).");


            }
        }
    }
}

int[,,] res = MatrixOfUnrepeatedInt3D(9, 5, 2);
PrinterMatrix3D(res);