/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите x1");
int y1 = ReadInt("Введите y1");
int z1 = ReadInt("Введите z1");
int x2 = ReadInt("Введите x2");
int y2 = ReadInt("Введите y2");
int z2 = ReadInt("Введите z2");

int z = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);
double rezult = Math.Sqrt(z);
string rezult2 = string.Format("{0:F2}", rezult);
Console.WriteLine(rezult2);