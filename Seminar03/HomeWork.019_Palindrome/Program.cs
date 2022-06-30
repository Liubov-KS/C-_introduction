/* 
    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    является ли оно палиндромом.
    14212 -> нет
    23432 -> да
    12821 -> да 
*/

/* 
    Напишем общий алгоритм, который будет работать не только для пятизначных чисел. 
    С пятизначными числами не нужен шаг 1, размер массива на шаге 2 будет известен сразу.
    Можно избежать Шага 1 использую List<T>, но это в контексте учебной задачи читы.
*/

Console.WriteLine("Введите число для проверки на палиндромность: ");
int num = Convert.ToInt32(Console.ReadLine());

// Шаг 1. Считаем количество цифр в числе для преобразования числа в массив без использования List<T>.
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
    return array;
} 
int[] resultArray = ToArrayConvertor(num, amountOfDigits);

// Шаг 3. Проверяем элементы массива на "палиндромность".
bool PalindromeChecker(int[] array)                             
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] != array[array.Length-(1+index)])
        {
            return false;
        }
    }
    return true;
}
bool palindromeness = PalindromeChecker(resultArray);           

// Шаг 4. Выводим результат.
if (palindromeness == true)
{
    Console.WriteLine("Ура, введенное число - палиндром.");
}
else
{
    Console.WriteLine("Увы, введенное число - не палиндром.");
}