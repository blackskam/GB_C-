/* Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму натуральных элементов в промежутке
  от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */



int numM = 4;
int numN = 8;
GetNumberSum(numM, numN);


void GetNumberSum(int numM, int numN, int sum = 0)
{
    if (numM > numN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum += numM++;
    GetNumberSum(numM, numN, sum);
}

