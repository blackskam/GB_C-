/* 5. Конвертер валют. У пользователя есть баланс в каждой из представленных валют. С помощью команд он может попросить сконвертировать одну валюту в другую. Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент, когда решит пользователь. */


Dictionary<string, decimal> balans = new Dictionary<string, decimal>()
{
    { "RUB", 0},
    { "EUR", 0},
    { "USD", 0},
    { "JPY", 0},
    { "CHF", 0},
    { "GBR", 0},
};

Dictionary<string, decimal> rate = new Dictionary<string, decimal>()
{
    { "RUB", 1M},
    { "EUR", 61.07M},
    { "USD", 61.61M},
    { "JPY", 0.4157M},
    { "CHF", 61.67M},
    { "GBR", 71.43M},
};

bool isWork = true;

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

decimal ReadDecimal(string message)
{
    Console.Write(message);
    return Convert.ToDecimal(Console.ReadLine());
}

void Balans()
{
    Console.WriteLine("Ваш баланс валют: ");
    foreach (var money in balans)
    {
        Console.Write(" {0:F2} = {1:F2},", money.Key, money.Value);
        Console.WriteLine();
    }
}

void Rate()
{
    Console.WriteLine("Ваш курс валют: ");
    foreach (var course in rate)
    {
        Console.Write(" 1 {0} = {1:F2},", course.Key, course.Value);
    }
}

void Setbalans()
{
    Balans();
    Console.WriteLine("Ваш баланс валют: ");
    foreach (var money in balans)
    {
        Console.Write("Введите баланс {0}: ", money.Key);
        balans[money.Key] += Convert.ToDecimal(Console.ReadLine());
        if (balans[money.Key] < 0)
        {
            balans[money.Key] = 0;
        }
    }
    Balans();
}

void Setrate()
{
    Rate();
    Console.WriteLine("");
    foreach (var course in rate)
    {
        Console.Write("Введите курс {0}: ", course.Key);
        decimal rate_temp = Convert.ToDecimal(Console.ReadLine());
        if (rate_temp <= 0)
        {
            Console.WriteLine("Курс не может быть отрицательным или равным 0");
        }
        else
        {
            rate[course.Key] = rate_temp;
        }
    }
    Rate();
}

void Help()
{
    Console.WriteLine("exit -> выход из обменника");
    Console.WriteLine("help -> вывести список комманд");
    Console.WriteLine("balans -> вывести баланс валют");
    Console.WriteLine("setbalans -> установить баланс валют");
    Console.WriteLine("rate -> вывести курс валют к рублю");
    Console.WriteLine("setrate -> установить курс валют к рублю");
    Console.WriteLine("convert -> конвертировать валюту");
}


while (isWork)
{
    //Balans();
    Console.WriteLine(" для вызова списка команд введите help");
    string inputUser = ReadString("Введите команду: ").ToLower();
    switch (inputUser)
    {
        case "exit":
        {
             isWork = false;
             break;
        }
        case "help":
            {
                Help();
                break;
            }
        case "balans":
            {
                Balans();
                break;
            }
        case "setbalans":
            {
                Setbalans();
                break;
            }
        case "rate":
            {
                Rate();
                break;
            }
        case "setrate":
            {
                Setrate();
                break;
            }
        case "convert":
            {
                string inputСurrency1 = ReadString("Из какой валюты конвертировать?(RUB, EUR, USD, JPY, CHF, GBR):");
                string inputСurrency2 = ReadString("В какую валюту конвертировать?(RUB, EUR, USD, JPY, CHF, GBR):");
                inputСurrency1 = inputСurrency1.ToUpper();
                inputСurrency2 = inputСurrency2.ToUpper();
                if ((!balans.ContainsKey(inputСurrency1)) || (!balans.ContainsKey(inputСurrency2)))
                {
                    Console.WriteLine("Вы ввели недоопустимую валюту!");
                    break;
                }
                if (inputСurrency1 == inputСurrency2)
                {
                    Console.WriteLine("Валюты идентичны");
                    break;
                }
                else
                {
                    if (balans[inputСurrency1] == 0)
                    {
                        Console.WriteLine("Баланс нулевой, конвертация невозможна");
                    }
                    else
                    {
                        Console.WriteLine("Ваш баланс {0} = {1:f2}", inputСurrency1, balans[inputСurrency1]);
                        decimal moneyСurrency = ReadDecimal("Укажите сколько конвертировать: ");
                        if (balans[inputСurrency1] < moneyСurrency)
                        {
                            Console.WriteLine("Ваш баланс {0} меньше указанного, повторите команду", inputСurrency1);
                            break;
                        }
                        else
                        {
                            balans[inputСurrency2] += moneyСurrency * rate[inputСurrency1] / rate[inputСurrency2];
                            balans[inputСurrency1] -= balans[inputСurrency1];
                            Balans();
                        }
                    } 
                    break;
                }
            }
    }
}
