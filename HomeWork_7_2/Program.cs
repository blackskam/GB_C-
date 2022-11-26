/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4 */

int m = 5;
int n = 4;
int max = 10;
int[,] array = NewArray(m, n, max);
WriteArray(array);
int ij = ReadInt("Введите позицию элемента:");
int i = ij / 10;
int j = ij % 10;
GetElementAray(i, j, array);


void GetElementAray(int i, int j, int[,] array)
{
    if ((i > array.GetLength(0)) || (j > array.GetLength(1)))
        Console.WriteLine("Такого числа в массиве нет");
    else
        Console.WriteLine(array[(i - 1), (j - 1)]);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] NewArray(int m, int n, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (new Random().Next(0, max));
        }
    return array;
}