/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98 */

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int firstDigit = (num / 100) * 10; 
int thirdDigit = (num % 10);
Console.WriteLine(firstDigit + thirdDigit);