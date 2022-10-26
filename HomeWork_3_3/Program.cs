/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int ReadInt(string message)
{
    Console.WriteLine(message);
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

int numN = ReadInt("Введите натуральное число:");
int numPow = ReadInt($"Введите степень в которую нужно возвести последовательность от 1 до {numN}:");
int numX = 1;
while (numX <= numN)
{
    if (numX != numN)
    {
        Console.Write(IntPow(numX,numPow) + ", ");
    }    
    else
    {
        Console.Write(IntPow(numX,numPow));
    }
    numX ++;
}

