/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */


int m = 4;
int max = 100;
int[,] array = NewArray(m, max);
WriteArray(array);


void WriteArray(int[,] warray)
{
    for (int i = 0; i < warray.GetLength(0); i++)
    {
        for (int j = 0; j < warray.GetLength(1); j++)
        {
            {
                if (array[i, j] < 10)
                    Console.Write("0" + warray[i, j] + " ");
                else
                    Console.Write(warray[i, j] + " ");
            }

        }
        Console.WriteLine();
    }
}


int[,] NewArray(int m, int n)
{
    int[,] array = new int[m, m];
    int number = 1;
    int col = m;
    int max = 0;
    while ((col / 2) > 0)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (i == 0 && j < col - max)
                {
                    array[i + max, j + max] = number++;
                }
                if (j != 0)
                {
                    if (i == 2 && j < col - max)
                    {
                        array[col - 1, col - (j + 1)] = number++;
                    }
                    if (i == 1 && j < col - max)
                    {
                        array[j + max, col - 1] = number++;
                    }
                    if (i == 3 && j < col - (max + 1))
                    {
                        array[col - (j + 1), max] = number++;
                    }
                }
            }
        }
        col--;
        max++;
    }
    return array;
}