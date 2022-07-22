SpirallyArray();

DateTime date1 = DateTime.Now;
static void SpirallyArray()
{
    int row = 4;
    int col = 6;

    int count = 1;

    int[,] array = new int[row, col];

    for (int j = 0; j < col; j++)
    {
        array[0, j] = count;
        count++;
    }
    for (int i = 1; i < row; i++)
    {
        array[i, col - 1] = count;
        count++;
    }
    for (int j = col - 2; j >= 0; j--)
    {
        array[row - 1, j] = count;
        count++;
    }
    for (int i = row - 2; i > 0; i--)
    {
        array[i, 0] = count;
        count++;
    }

    int firstCoordPoint = 1;
    int secondCoordPoint = 1;

    while (count < row * col)
    {
        while (array[firstCoordPoint, secondCoordPoint + 1] == 0)
        {
            array[firstCoordPoint, secondCoordPoint] = count;
            count++;
            secondCoordPoint++;
        }

        while (array[firstCoordPoint + 1, secondCoordPoint] == 0)
        {
            array[firstCoordPoint, secondCoordPoint] = count;
            count++;
            firstCoordPoint++;
        }

        while (array[firstCoordPoint, secondCoordPoint - 1] == 0)
        {
            array[firstCoordPoint, secondCoordPoint] = count;
            count++;
            secondCoordPoint--;
        }

        while (array[firstCoordPoint - 1, secondCoordPoint] == 0)
        {
            array[firstCoordPoint, secondCoordPoint] = count;
            count++;
            firstCoordPoint--;
        }
    }
    for (int x = 0; x < row; x++)
    {
        for (int y = 0; y < col; y++)
        {
            if (array[x, y] == 0) array[x, y] = count;
        }
    }
    PrintArray(array, row, col);
}
static void PrintArray(int[,] arrPrint, int rowPrint, int colPrint)
{
    for (int i = 0; i < rowPrint; i++)
    {
        for (int j = 0; j < colPrint; j++)
        {
            if (arrPrint[i, j] < 10) Console.Write(arrPrint[i, j] + ",  ");
            else Console.Write(arrPrint[i, j] + ", ");
        }
        Console.WriteLine("");
    }
}

DateTime date2 = DateTime.Now;

var diff = date2-date1;
Console.Write($"{diff}");