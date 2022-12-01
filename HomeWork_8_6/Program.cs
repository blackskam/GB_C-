/* Доп. задача 61*: Вывести первые N строк треугольника Паскаля.
 Сделать вывод в виде равнобедренного треугольника */



int n = ReadInt("Введите нужное количество строк треугольника Паскаля:");
PascalTriangle(n);


void PascalTriangle(int n)
{
    long pascal;
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++)
        {
            Console.Write("     ");
        }
        for (int c = 0; c <= i; c++)
        {
            pascal = factorial(i) / (factorial(c) * factorial(i - c));
            if (pascal< 10)
            {
                Console.Write("         ");
            } 
            else
            {
                Console.Write("        ");
            }
            Console.Write(pascal);
        }
        Console.WriteLine();
        //Console.WriteLine();
    }
}


long factorial(int n)
{
    long i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
