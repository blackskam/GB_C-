/* Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int m = 2;
int n = 2;
int l = 2;
int max = 100;
int[,,] array3d = NewArray(m, n, l, max);
WriteArray(array3d);


void WriteArray(int[,,] warray)
{
    for (int i = 0; i < warray.GetLength(0); i++)
    {
        for (int j = 0; j < warray.GetLength(1); j++)
        {
            for (int k = 0; k < warray.GetLength(2); k++)
            {
                Console.Write($"{warray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] NewArray(int m, int n, int l, int max)
{
    int[,,] array3 = new int[m, n, l];
    List<int> list = new List<int>();
    for (int i = 0; i < array3.GetLength(0); i++)
        for (int j = 0; j < array3.GetLength(1); j++)
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                list.Add(NewNoRepeatNumber(list));
                array3[i,j,k] = list.Last();
            }
    return array3;
}


int NewNoRepeatNumber(List<int> list)
{
    int number = new Random().Next(0, max);
    while (true)
    {
        if (list.Contains(number))
        {
            number = new Random().Next(0, max);
            continue;
        }
        else
        {
            break;
        }

    }
    return number;
}


