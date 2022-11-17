/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}

int[] NewArray(int[] number, int size, int min, int max)
{  
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetCount(int[] array)
{
    int k = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        {
            k = k + array[i];
        }
    return k;
}

int size = 7;
int min = -99;
int max = 99;
int[] numbers = new int[size];
numbers = NewArray(numbers, size, min, max);
WriteArray(numbers);
Console.WriteLine(GetCount(numbers));