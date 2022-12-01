/* Доп. задача 55**: Задайте двумерный массив. Напишите программу,
 которая заменяет строки на столбцы. В случае, если это невозможно,
  программа должна вывести сообщение для пользователя. Решить НЕ используя второй массив */



int m = ReadInt("Введите число строк дмвуерного массива:");
int n = ReadInt("Введите число столбцов дмвуерногомассива:");
if (m != n)
{
    Console.Write("Заменить строки на столбцы, не изменив размерность массива, в таком массиве невозможно!");
}
else
{
    int max = 100;
    int[,] array = NewArray(m, n, max);
    WriteArray(array);
    Console.WriteLine();
    WriteArray(ReplaceRowsColumns(array));
}



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] ReplaceRowsColumns(int[,] array)
{
    for (int i = 0; i < n; ++i)
    {
        for (int j = i + 1; j < n; j++)
        {
            int tmp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = tmp;
        }
    }
    return array;
}



void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write(" " + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
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
            array[i, j] = new Random().Next(0, max);
        }
    return array;
}