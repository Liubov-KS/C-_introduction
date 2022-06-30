/*
    Напишите программу, которая на вход принимает трехзначное число
    и выходе показывает вторую цифру этого числа
*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = 0; // можно было бы и сразу считать, но пусть будет красиво
secondDigit = (number / 10) % 10;

Console.WriteLine($"Вторая цифра числа {number} это {secondDigit}");