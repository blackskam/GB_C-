/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
if (max < numB)
{
    max = numB;
}
if (max < numC)
{
    max = numC;
}
Console.WriteLine("Максимальное число: " + max);
