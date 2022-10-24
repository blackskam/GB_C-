/* 1. 2. Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается */

/* 4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля */

string passwordUser = " ";
string nameUser = " ";
bool exitTrue = true;

while (exitTrue)
{
    string inputUser = Console.ReadLine().ToLower();
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
                Console.WriteLine("setname -> установить имя");
                Console.WriteLine("setpassword -> установить пароль");
                Console.WriteLine("writename -> вывести имя после ввода пароля");
                break;
            }
        case "setname":
            {
                nameUser = Console.ReadLine();
                break;
            }
        case "setpassword":
            {
                passwordUser = Console.ReadLine();
                break;
            }
        case "writename":
            {
                Console.WriteLine("Введите пароль:");
                string inputPasswordUser = Console.ReadLine();
                if (inputPasswordUser == passwordUser)
                {
                    Console.WriteLine(nameUser);
                }
                break;
            }
    }
}
           