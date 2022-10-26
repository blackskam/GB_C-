/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (Использовать только математические операции, нельзя использовать число как строку по типу number[1])
14212 -> нет
12821 -> да
23432 -> да */


int GetIntConsole() // функция считывания и конвертирования строки в число
{
    return Convert.ToInt32(Console.ReadLine());
}

int IntPow(int x, int pow) // функция возводит в степень число
{
    int ret = 1;
    while (pow != 0)
    {
        if ((pow & 1) == 1)
            ret *= x;
        x *= x;
        pow >>= 1;
    }
    return ret;
}


int GetNum(int index, int number, int digit) // функция выдает цифру из числа по индексу
{
    return (number % (IntPow(10, (digit - index)))) / ((IntPow(10, (digit - index))) / 10);
}

Console.WriteLine("Введите пятизначное число:");
int dig = 5; //разрядность числа по условию
int numA = GetIntConsole();

if (GetNum(4, numA, dig) == GetNum(0, numA, dig) & GetNum(3, numA, dig) == GetNum(1, numA, dig))
{
    Console.WriteLine("Да, введенное число палиндром!");
}
else
{
    Console.WriteLine("Нет, введенное число не палиндром!");
}