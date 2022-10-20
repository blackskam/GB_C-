/* 1. В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение */

string secretMessage = "Hello!";
string passwrd = "Hi";
int count = 3;

while (count != 0)
{
    Console.Write("Введите пароль:");
    string inputUser = Console.ReadLine();
    if (inputUser == passwrd)
    {
        Console.Write(secretMessage);
        break;
    }
    else
    {
        count--;
    }
}