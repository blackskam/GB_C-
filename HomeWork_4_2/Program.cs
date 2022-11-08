/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите число: ");

int count = 0;
while (numberA > 9)
{
    count += numberA % 10;
    numberA /= 10;
}
count += numberA;
Console.WriteLine("Сумма цифр равна " + count);