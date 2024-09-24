using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript4 : MonoBehaviour
{
    //    Написать конвертер валют(3 валюты).

    //У пользователя есть баланс в каждой из представленных валют.Он может попросить сконвертировать часть баланса с одной валюты в другую.
    //Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.
    //Курс конвертации должен быть просто прописан в программе.
    //По имени переменной курса конвертации должно быть понятно, из какой валюты в какую валюту конвертируется.
    //Должна выполняться однотипная операция или везде умножение "*" или деление "/". Для чего это нужно подробнее позже узнаете в разделе "Функции".
    //Но придётся объявить коэффициенты на все случаи.

    //Программа должна завершиться тогда, когда это решит пользователь.

    //Дополнительно: Если решение строится на switch, то принято работать с константами (в остальных случаях объявляются переменные).
    //Для каждого case следует объявить константу.
    //Пример:
    //const string CommandExit = "exit";

    //case CommandExit:
    //break;

    //Константы объявляются перед блоком переменных и отделяются от них пустой строкой.Константы именуются с большой буквы.
    //Если константа создана для связки консольное меню + switch (case) к имени константы добавляется
    //Command или Menu - это передает суть константы, превращая ее в существительное, а не глагол и улучшает читаемость кода.


    private static void Main(string[] args)
    {
        string dollarsMoney = "доллар";
        float cursDollar = 90f;
        string euroMoney = "евро";
        float cursEuro = 100f;
        string rubMoney = "рубль";
        string clientCurrency;
        string convertCurrency;
        string moneyConvert;
        float dollarsBalance = 1000f;
        float euroBalance = 1000f;
        float rubBalance = 100000f;


        while (true)
        {
            Console.WriteLine($"Баланс Рубль: {rubBalance}");
            Console.WriteLine($"Баланс Евро: {euroBalance}");
            Console.WriteLine($"Баланс Доллар: {dollarsBalance}");

            Console.WriteLine("Введите валюту: ");
            clientCurrency = Console.ReadLine().ToLower();

            Console.WriteLine("Выберите валюту для конвертации: ");
            convertCurrency = Console.ReadLine().ToLower();

            Console.WriteLine("Сколько хотите конвертировать? ");
            moneyConvert = Console.ReadLine().ToLower();

            if (float.TryParse(moneyConvert, out float moneyConvertCurrency))
            {
                Console.WriteLine($"Вы хотите конвертировать {moneyConvert}");
            }

            if (clientCurrency == dollarsMoney && convertCurrency == rubMoney && dollarsBalance > moneyConvertCurrency)
            {
                float resultConvertMoney = moneyConvertCurrency * cursDollar;
                rubBalance += resultConvertMoney;
                dollarsBalance -= moneyConvertCurrency;
                ConvertMoneyMethodScreenOutput(dollarsMoney, rubMoney, dollarsBalance, rubBalance, resultConvertMoney);
            }
            else if (clientCurrency == euroMoney && convertCurrency == rubMoney && euroBalance > moneyConvertCurrency)
            {
                float resultConvertMoney = moneyConvertCurrency * cursEuro;
                rubBalance += resultConvertMoney;
                euroBalance -= moneyConvertCurrency;
                ConvertMoneyMethodScreenOutput(euroMoney, rubMoney, euroBalance, rubBalance, resultConvertMoney);
            }
            else if (clientCurrency == rubMoney && convertCurrency == dollarsMoney && rubBalance > moneyConvertCurrency)
            {
                float resultConvertMoney = moneyConvertCurrency / cursDollar;
                dollarsBalance += resultConvertMoney;
                rubBalance -= moneyConvertCurrency;
                ConvertMoneyMethodScreenOutput(rubMoney, dollarsMoney, rubBalance, dollarsBalance, resultConvertMoney);
            }
            else if (clientCurrency == rubMoney && convertCurrency == euroMoney && rubBalance > moneyConvertCurrency)
            {
                float resultConvertMoney = moneyConvertCurrency / cursEuro;
                euroBalance += resultConvertMoney;
                rubBalance -= moneyConvertCurrency;
                ConvertMoneyMethodScreenOutput(rubMoney, euroMoney, rubBalance, euroBalance, resultConvertMoney);
            }
            else if (clientCurrency == euroMoney && convertCurrency == dollarsMoney && euroBalance > moneyConvertCurrency)
            {
                float convertDollarEuro = cursEuro / cursDollar;
                float resultConvertMoney = moneyConvertCurrency * convertDollarEuro;
                dollarsBalance += resultConvertMoney;
                euroBalance -= moneyConvertCurrency;
                ConvertMoneyMethodScreenOutput(euroMoney, dollarsMoney, euroBalance, dollarsBalance, resultConvertMoney);
            }
            else if (clientCurrency == dollarsMoney && convertCurrency == euroMoney && dollarsBalance > moneyConvertCurrency)
            {
                float convertEuroDollar = cursDollar / cursEuro;
                float resultConvertMoney = moneyConvertCurrency * convertEuroDollar;
                euroBalance += resultConvertMoney;
                dollarsBalance -= moneyConvertCurrency;
                ConvertMoneyMethodScreenOutput(dollarsMoney, euroMoney, dollarsBalance, euroBalance, resultConvertMoney);
            }
            else
            {
                Console.WriteLine("При конвертации произошла ошибка. Прошу проверить баланс и наличие валюты. ");
            }
        }

    }
    private static void ConvertMoneyMethodScreenOutput(string euroMoney, string dollarsMoney, float euroBalance, float dollarsBalance, float resultConvertMoney)
    {
        Console.WriteLine($"Вы конвертировали {euroMoney} в {dollarsMoney} {resultConvertMoney}");
        Console.WriteLine($"Осталось {euroMoney} {euroBalance}, Осталось {dollarsMoney} {dollarsBalance}");
        Console.ReadKey();
        Console.Clear();
    }

}
