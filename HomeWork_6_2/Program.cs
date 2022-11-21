/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double b1 = ReadDouble("Введите b1: ");
double k1 = ReadDouble("Введите k1: ");
double b2 = ReadDouble("Введите b2: ");
double k2 = ReadDouble("Введите k2: ");
CrossPoint(k1,b1,k2,b2);


double ReadDouble(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
    if (k1 == k2)
    {
        Console.Write("Прямые не пересекаются!");
    } 
    else
    {
        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}

