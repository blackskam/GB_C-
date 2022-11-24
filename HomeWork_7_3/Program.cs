/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */


int m = 5;
int n = 4;
int max = 10;
int[,] array = NewArray(m, n, max);
WriteArray(array);
Console.WriteLine();
GetMean(array);


void GetMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            mean += array[i,j];
        Console.Write(mean / array.GetLength(0) + " ");
    }
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