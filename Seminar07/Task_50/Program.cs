/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7] -> такого числа в массиве нет
*/


Console.WriteLine("Давайте создадим таблицу из случайных чисел. Cколько в таблице будет строк?");
int amountOfStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cколько в таблице будет колонок?");
int amountOfCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое минимальное значение элемента будет в таблице?");
int lowerBound = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А максимальное?");
int upperBound = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Посмотрим, какие у нас есть элементы. Укажите номер строки: ");
int strPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А теперь номер колонки: ");
int colPosition = Convert.ToInt32(Console.ReadLine());

int[,] MatrixOfRandomInt(int lines, int columns, int min , int max)
{
    int[,] matrix = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}

// Пользователь - не программист, считает от 1, не от 0.
void ElemSearcher (int i, int j, int[,] matrix)
{
    try
    {
        Console.WriteLine($"В строке {i}, в колонке {j} находится элемент '{matrix[i-1,j-1]}'.");
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine($"Упс! Мы попали за пределы таблицы.");
        Console.WriteLine($"Попробуйте задать номер строки в пределах от 1 до {amountOfStr}, а номер колонки - от 1 до {amountOfCol}.");
    }
}

// И у меня вопрос - нормально ли пытаться думать в сторону метода, 
// который может в зависимости от результатов вычислений выдавать результаты с разными типами?
// Вот в этом задании, мне бы хотелось, что бы метод отдавал скажем string если index out of range и int/double 
// (опять же, что бы не писать разные методы для массивов с разными типами элементов) если всё ок.
// или это не C#-way?

void PrinterMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i,j]}]");    
        }
        Console.WriteLine();
    }
}


int[,] result = MatrixOfRandomInt(amountOfStr, amountOfCol,lowerBound, upperBound);
ElemSearcher(strPosition, colPosition, result);
PrinterMatrix(result);