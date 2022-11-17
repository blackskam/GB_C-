/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным значениями элементов массива.

[3 7 22 2 78] -> 76 */

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}

double[] NewArray(double[] number, int size, int min, int max)
{  
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (new Random().Next(min, max + 1)) + (new Random().NextDouble());
    }
    return array;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    return max;
}

int size = 5;
int min = 0;
int max = 10;
double[] array = new double[size];
array = NewArray(array, size, min, max);
WriteArray(array);
Console.WriteLine(GetMax(array) - GetMin(array));