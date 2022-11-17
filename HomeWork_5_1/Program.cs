/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  */

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

int GetCountEven(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                k++;
            }
        }
    return k;
}

int size = 10;
int min = 100;
int max = 999;
int[] numbers = new int[size];
numbers = NewArray(numbers, size, min, max);
WriteArray(numbers);
Console.WriteLine(GetCountEven(numbers));