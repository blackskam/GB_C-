/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Использовать только математические операции, нельзя использовать число как строку по типу number[2])

645 -> 5

78 -> третьей цифры нет

32679 -> 6  */

int GetIntConsole() // функция считывания и конвертирования строки в число
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите число:");
int numA = GetIntConsole();

while (true) 
{
    if ( numA < 100)
    {
        Console.WriteLine("Третьей цифры нет, повторите ввод или введите цифру 0 для выхода");
        numA = GetIntConsole();
        if (numA == 0)
        {
            break;
        }
    }
    else
    {
        while (numA > 999)
        {
            numA = numA / 10;
        }
        int rezult = (numA % 100) % 10;
        Console.WriteLine(rezult);
        break;
    }
}


