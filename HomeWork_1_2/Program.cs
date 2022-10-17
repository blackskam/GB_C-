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
 
if (numA > numB && numA > numC)
{
    Console.WriteLine("Максимальное число = " + numA);
}
else if (numB > numA && numB > numC)
{
    Console.WriteLine("Максимальное число = " + numB);
}
else if (numC > numA && numC > numB)
{
    Console.WriteLine("Максимальное число = " + numC);
}
else
{
    Console.WriteLine("Вы ввели одинаковые числа");
}