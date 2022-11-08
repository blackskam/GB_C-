/* Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите размер массива: ");

int[] array = new int[numberA];
 
for (int i = 0; i < numberA; i++)
{
    Console.WriteLine("Введите {0} элемент массива: ", i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Ваш введенный массив: [");
for (int i = 0; i < numberA; i++)
{
    Console.Write(array[i]);
    if (i < (numberA - 1))
    {
        Console.Write(", ");
    }
}
Console.Write("]");