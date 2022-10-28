/* 1. 2. Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается */

/* 4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля */

/* 1. WriteName можно ввести пока еще не установлены имя и пароль, что немного нелогично 
2. Получилось прям очень простенько, давай еще усложним команду ввода пароля. Если пароль уже установлен, то сначала нужно ввести старый пароль */

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string passwordUser = " ";
string nameUser = " ";
bool exitTrue = true;

while (exitTrue)
{
    string inputUser = ReadString("Введите команду: ").ToLower();
    switch (inputUser)
    {
        case "exit":
        {
             exitTrue = false;
             break;
        }
        case "help":
            {
                Console.WriteLine("exit -> выход");
                Console.WriteLine("help -> вывести список комманд");
                Console.WriteLine("setname -> установить имя и пароль");
                Console.WriteLine("changepassword -> сменить пароль");
                Console.WriteLine("writename -> вывести имя после ввода пароля");
                Console.WriteLine("changename -> сменить имя после ввода пароля");
                break;
            }
        case "setname":
            {
                nameUser = ReadString("Введите имя: ");
                passwordUser = ReadString("Введите пароль: ");
                break;
            }
        case "changepassword":
            {
                if (nameUser != " ")
                {
                    string chekNameUser = ReadString("Введите имя: ");
                    if (chekNameUser == nameUser)
                    {
                        string chekPasswordUser = ReadString("Введите пароль: ");
                        if (chekPasswordUser == passwordUser)
                        {
                            passwordUser = ReadString("Введите новый пароль: ");
                        }
                        else
                        {
                            Console.WriteLine("Пароль неверный!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого имени не существует!");
                    }
                }
                else
                {
                    Console.WriteLine("Имя не установлено!");
                }
                break;
            }
        case "writename":
            {
                if (nameUser != " ")
                {
                    string inputPasswordUser = ReadString("Введите пароль: ");
                    if (inputPasswordUser == passwordUser)
                    {
                        Console.WriteLine(nameUser);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Имя не установлено!");
                }
                break;
            }
        case "changename":
            {
                if (nameUser != " ")
                {
                    string chekNameUser = ReadString("Введите имя: ");
                    if (chekNameUser == nameUser)
                    {
                        string chekPasswordUser = ReadString("Введите пароль: ");
                        if (chekPasswordUser == passwordUser)
                        {
                            nameUser = ReadString("Введите новое имя: ");
                        }
                        else
                        {
                            Console.WriteLine("Пароль неверный!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого имени не существует!");
                    }
                }
                else
                {
                    Console.WriteLine("Имя не установлено!");
                }
                break;
            }
    }
}
           