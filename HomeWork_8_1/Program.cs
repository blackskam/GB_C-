/* Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int m = 4;
int n = 5;
int max = 10;
int[,] array = NewArray(m, n, max);
WriteArray(array);
int[,] sortarray = GetSortAray(array);
Console.WriteLine();
WriteArray(sortarray);


int[,] GetSortAray(int[,] tarray)
{
    for (int i = 0; i < tarray.GetLength(0); i++)
    {
        for (int j = 0; j < tarray.GetLength(1); j++)
        {
            for (int k = (tarray.GetLength(1) - j - 1); k >= 0; --k)
            {
                if (tarray[i, tarray.GetLength(1) - j - 1] > tarray[i, k])
                {
                    int temp = tarray[i, tarray.GetLength(1) - j - 1];
                    tarray[i, tarray.GetLength(1) - j - 1] = tarray[i, k];
                    tarray[i, k] = temp;
                }
            }
        }
    }
    return tarray;
}

void WriteArray(int[,] warray)
{
    for (int i = 0; i < warray.GetLength(0); i++)
    {
        for (int j = 0; j < warray.GetLength(1); j++)
        {
            Console.Write(warray[i, j] + " ");
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
