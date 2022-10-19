/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8  */


Console.WriteLine("Введите натуральное число:");
int numA = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (numA < 1 )
{
    Console.WriteLine("Вы ввели ноль или отрицательное число!");
}
else
{
    while (count <= numA)
    {
        Console.Write(count + ", ");        
        count = count + 2;
    }
}