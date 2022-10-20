/* 1. 2. Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается */

while (true)
{
    string inputUser = Console.ReadLine();
    if (inputUser == "exit")
    {
        break;
    }
}