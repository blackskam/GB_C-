/* Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18   */

int m = 2;
int n = 2;
int l = 2;
int h = 2;
int max = 10;
int[,] array1 = NewArray(m, n, max);
int[,] array2 = NewArray(l, h, max);
if (n == l)
{
    WriteArray(array1);
    Console.WriteLine();
    WriteArray(array2);
    int[,] array3 = GetMultiArray(array1, array2);
    Console.WriteLine();
    WriteArray(array3);
}
else
{
    Console.WriteLine("Данные матрицы нельзя перемножить!");
}



int[,] GetMultiArray(int[,] tarray1, int[,] tarray2)
{
    int[,] tarray3 = new int[tarray1.GetLength(0), tarray2.GetLength(1)];
    for (int i = 0; i < tarray1.GetLength(0); i++)
    {
        for (int j = 0; j < tarray2.GetLength(1); j++)
        {
            for (int k = 0; k < tarray1.GetLength(1); k++)
            {
                tarray3[i, j] += tarray1[i, k] * tarray2[k, j];
            }
        }
    }
    return tarray3;
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

