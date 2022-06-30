/*
    Напишите программу, которая выводит третью цифру заданного числа
    или сообщает, что третьей цифры нет.
*/

/*
    Ви гона ду ит хард вей
*/

// Блок ввода.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Шаг 1. Считаем количество цифр в числе для преобразования числа в массив.
int digitsCount(int a)                                          
{
    int digitsCounter = 0;
    if (a < 0) a = -a;
    while (a != 0)
    {
        a /= 10;
        digitsCounter++;
    }
    return digitsCounter;
}
int amountOfDigits = (digitsCount(num));

// Шаг 2. Превращаем число в массив цифр из которых оно состоит.
int[] ToArrayConvertor(int number, int length)                  
{
    int[] array = new int[length];
    for (int index = 0; index < length; index++)
    {
        array[index] = number % 10;
        number /= 10;
    }
    Array.Reverse(array); // Надо развернуть массив, "набивка" производилась с последний цифры числа.
    return array;
} 
int[] resultArray = ToArrayConvertor(num, amountOfDigits);


// Шаг 3. Проверяем, есть ли третья цифра и выводим соответветствующее сообщение.
if (resultArray.Length < 3)     
{
    Console.WriteLine($"There's no third digit, Neo");
}
else
{
    Console.WriteLine(resultArray[2]);
}