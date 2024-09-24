using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript4 : MonoBehaviour
{
    //    �������� ��������� �����(3 ������).

    //� ������������ ���� ������ � ������ �� �������������� �����.�� ����� ��������� ��������������� ����� ������� � ����� ������ � ������.
    //����� � ���� � ������� ����� ������ �������� X � ���������� �� ������ ������ Y.
    //���� ����������� ������ ���� ������ �������� � ���������.
    //�� ����� ���������� ����� ����������� ������ ���� �������, �� ����� ������ � ����� ������ ��������������.
    //������ ����������� ���������� �������� ��� ����� ��������� "*" ��� ������� "/". ��� ���� ��� ����� ��������� ����� ������� � ������� "�������".
    //�� ������� �������� ������������ �� ��� ������.

    //��������� ������ ����������� �����, ����� ��� ����� ������������.

    //�������������: ���� ������� �������� �� switch, �� ������� �������� � ����������� (� ��������� ������� ����������� ����������).
    //��� ������� case ������� �������� ���������.
    //������:
    //const string CommandExit = "exit";

    //case CommandExit:
    //break;

    //��������� ����������� ����� ������ ���������� � ���������� �� ��� ������ �������.��������� ��������� � ������� �����.
    //���� ��������� ������� ��� ������ ���������� ���� + switch (case) � ����� ��������� �����������
    //Command ��� Menu - ��� �������� ���� ���������, ��������� �� � ���������������, � �� ������ � �������� ���������� ����.


    private static void Main(string[] args)
    {
        string dollarsMoney = "������";
        float cursDollar = 90f;
        string euroMoney = "����";
        float cursEuro = 100f;
        string rubMoney = "�����";
        string clientCurrency;
        string convertCurrency;
        string moneyConvert;
        float dollarsBalance = 1000f;
        float euroBalance = 1000f;
        float rubBalance = 100000f;


        while (true)
        {
            Console.WriteLine($"������ �����: {rubBalance}");
            Console.WriteLine($"������ ����: {euroBalance}");
            Console.WriteLine($"������ ������: {dollarsBalance}");

            Console.WriteLine("������� ������: ");
            clientCurrency = Console.ReadLine().ToLower();

            Console.WriteLine("�������� ������ ��� �����������: ");
            convertCurrency = Console.ReadLine().ToLower();

            Console.WriteLine("������� ������ ��������������? ");
            moneyConvert = Console.ReadLine().ToLower();

            if (float.TryParse(moneyConvert, out float moneyConvertCurrency))
            {
                Console.WriteLine($"�� ������ �������������� {moneyConvert}");
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
                Console.WriteLine("��� ����������� ��������� ������. ����� ��������� ������ � ������� ������. ");
            }
        }

    }
    private static void ConvertMoneyMethodScreenOutput(string euroMoney, string dollarsMoney, float euroBalance, float dollarsBalance, float resultConvertMoney)
    {
        Console.WriteLine($"�� �������������� {euroMoney} � {dollarsMoney} {resultConvertMoney}");
        Console.WriteLine($"�������� {euroMoney} {euroBalance}, �������� {dollarsMoney} {dollarsBalance}");
        Console.ReadKey();
        Console.Clear();
    }

}
