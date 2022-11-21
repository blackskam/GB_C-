/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4 */


string numbers = ReadInt("Введите числа через запятую:");
string[] strlist = numbers.Split(new char[] {','});
Console.WriteLine(CountPositiv(strlist));

int CountPositiv(string[] strlst)
{
    int k = 0;
    for (int i = 0; i < strlist.Length; i++)
    {
        if (Convert.ToInt32(strlist[i]) > 0)
        k++;
    }
    return k;
}
string ReadInt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}