/* Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int m = 5;
int n = 4;
int max = 10;
int[,] array = NewArray(m, n, max);
WriteArray(array);
Console.WriteLine((GetRow(array) + 1) + " строка");



int GetRow(int[,] tarray)
{
    int[] sumrowarray = new int[tarray.GetLength(0)];
    for (int i = 0; i < tarray.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < tarray.GetLength(1); j++)
        {
            sumrow += tarray[i,j];
        }
        sumrowarray[i] = sumrow;
        Console.WriteLine(sumrow);
    }
    int min = 0;
    for (int i = 1; i < sumrowarray.Length; i++)
    {
        if (sumrowarray[min] > sumrowarray[i])
        {
            min = i;
        }
    }
    return min;
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