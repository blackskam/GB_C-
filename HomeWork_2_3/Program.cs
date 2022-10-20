/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет  */

int GetIntConsole() // функция считывания и конвертирования строки в число
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите день недели:");
int numA = GetIntConsole();

if (numA == 6 || numA == 7)
{
    Console.WriteLine($"{numA} -> Да - день недели выходной!");
}
else
{
    Console.WriteLine($"{numA} -> Нет - день недели не выходной!");
}