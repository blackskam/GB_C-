/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

int m = 5;
int n = 4;
int max = 10;
double[,] array = NewArray(m, n, max);
WriteArray(array);


void WriteArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
                Console.Write("{0:F2}  ", array[i, j]);
            else
                Console.Write(" {0:F2}  ", array[i, j]);
        }
        Console.WriteLine();
    }
}


double[,] NewArray(int m, int n, int max)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (new Random().Next(-max, max)) + (new Random().NextDouble());
        }
    return array;
}