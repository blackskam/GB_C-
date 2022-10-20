/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Использовать только математические операции, нельзя использовать число как строку по типу number[1])

456 -> 5
782 -> 8
918 -> 1 */

int GetIntConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите трехзначное число:");
int numA = GetIntConsole();

while (true) 
{
    if (numA < 100 || numA > 1000)
    {
        Console.WriteLine("Вы ввели не трехзначное число, повторите ввод или введите цифру 0 для выхода");
        numA = GetIntConsole();
        if (numA == 0)
        {
            break;
        }
    }
    else
    {
        int rezult = (numA % 100) / 10;
        Console.WriteLine(rezult);
        break;
    }
}
