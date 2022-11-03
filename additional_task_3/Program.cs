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
//decimal balansRub = 0M;
//decimal balansEur = 0M;
//decimal balansUsd = 0M;
//decimal balansJpy = 0M;
//decimal balansChf = 0M;
//decimal balansGbr = 0M;

Dictionary<string, decimal> rate = new Dictionary<string, decimal>()
{
    { "EUR", 61.07M},
    { "USD", 61.61M},
    { "JPY", 0.4157M},
    { "CHF", 61.67M},
    { "GBR", 71.43M},
};

//decimal rateEur = 61.07M;
//decimal rateUsd = 61.61M;
//decimal rateJpy = 0.4157M;
//decimal rateChf = 61.67M;
//decimal rateGbr = 71.43M;

bool exitTrue = true;
//string passwordUser = " ";
//string nameUser = " ";


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
    }
    //Console.Write("RUB = {0:F2} , EUR = {1:F2} , USD = {2:F2} , ", balansRub, balansEur, balansUsd);
    //Console.WriteLine("JPY = {0:F2} , CHF = {1:F2} , GBR = {2:F2}", balansJpy, balansChf, balansGbr);
}

void Rate()
{
    Console.WriteLine("Ваш курс валют: ");
    foreach (var course in rate)
    {
        Console.Write(" 1 {0} = {1:F2},", course.Key, course.Value);
    }
    //Console.Write("1 EUR = {0:F2} ₽, 1 USD = {1:F2} ₽, ", rateEur, rateUsd);
    //Console.WriteLine("1 JPY = {0:F4} ₽, 1 CHF = {1:F2} ₽, 1 GBR = {2:F2} ₽", rateJpy, rateChf, rateGbr);
}

void Setbalans()
{
    Console.WriteLine("Ваш баланс валют: ");
    foreach (var money in balans)
    {
        Console.Write("Введите баланс {0}: ", money.Key);
        balans[money.Key] = Convert.ToDecimal(Console.ReadLine());
        //Console.Write(" {0} = {1:F2},", money.Key, money.Value);
    }
}

void Setrate()
{
    Console.WriteLine("");
    foreach (var course in rate)
    {
        Console.Write("Введите курс {0}: ", course.Key);
        rate[course.Key] = Convert.ToDecimal(Console.ReadLine());
        //Console.Write(" {0} = {1:F2},", money.Key, money.Value);
    }
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


while (exitTrue)
{
    //Balans();
    Console.WriteLine(" для вызова списка команд введите help");
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
                Rate();
                Setrate();
                break;
            }
        case "convert":
            {
                string inputСurrency1 = ReadString("Из какой валюты конвертировать?(RUB, EUR, USD, JPY, CHF, GBR):");
                string inputСurrency2 = ReadString("В какую валюту конвертировать?(RUB, EUR, USD, JPY, CHF, GBR):");
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
                            if (inputСurrency1 == "RUB")
                            {
                                decimal tempCurency1 = balans[inputСurrency1];
                                decimal tempCurency2 = balans[inputСurrency2];
                                decimal rateCurency = rate[inputСurrency2];
                                balans[inputСurrency2] = (moneyСurrency / rateCurency) + tempCurency2;
                                balans[inputСurrency1] = tempCurency1 - moneyСurrency;
                                break;
                            }
                            else
                            {
                                decimal tempCurency1 = balans[inputСurrency1];
                                decimal tempCurency2 = balans[inputСurrency2];
                                decimal rateCurency = rate[inputСurrency2];
                                decimal rateRub = rate[inputСurrency1];
                                decimal tempRub = moneyСurrency * rateRub;
                                balans[inputСurrency2] = (tempRub / rateCurency) + tempCurency2;
                                balans[inputСurrency1] = tempCurency1 - moneyСurrency;
                                break;
                            }
                        }
                    } 
                    break;
                }
            }
    }
}
