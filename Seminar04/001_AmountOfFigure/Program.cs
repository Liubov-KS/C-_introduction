Console.WriteLine("Введите число для подсчета кол-ва чисел в нем: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitsCount(int a)                                          
{
    int digitsCounter = 0;
    while (a != 0)
    {
        a /= 10;
        digitsCounter++;
    }
    return digitsCounter;
}
int amountOfDigits = DigitsCount(num);
Console.Write($"Количество цифр в числе {num} = {amountOfDigits}.");