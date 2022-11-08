/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите перове число: ");
int numberB = ReadInt("Введите второе число: ");
if (numberB == 0)
{
    Console.WriteLine(" {0} в степени {1} равно 1 ", numberA, numberB);
}
else
{
    int numberC = numberA;
    for (int i = 1; i < numberB; i++)
    {
        numberC *= numberA;
    }
    Console.WriteLine(" {0} в степени {1} равно {2} ", numberA, numberB, numberC);
}
