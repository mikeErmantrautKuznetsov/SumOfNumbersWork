using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    static void Main(string[] args)
    {
        // �������� ���������, ������� ����� ����������� �� ��� ���, ���� �� ����� ������� ����� exit.
        //�������, � ����� ������ ���� �������, ������� �������� �� ��, ����� ���� ������ �����������.
        //��� �����, ����� ����� ����������� �������� �� ��� ���, ����� ������ ������� ������ �����.

        int cicleContinion = 0;
        string codWordStart = "Start";
        string codWordEnd = "Exit";
        Console.WriteLine("��� ������ ������ ���������, �������� Start");
        string endProgram = Console.ReadLine();

        switch (endProgram)
        {
            case "Start":
                Console.WriteLine("������ �����! ��� ������ �������� Exit.");
                CicleForever(codWordStart, cicleContinion, codWordEnd, endProgram);
                break;
            case "Exit":
                Console.WriteLine("����� �� ���������");
                break;
            default:
                Console.WriteLine("������ �����");
                break;
        }

    }
    static void CicleForever(string codWordStart, int cicleContinion, string codWordEnd, string endProgram)
    {
        while (endProgram == codWordStart)
        {
            Console.WriteLine("����������� ����!");
            endProgram = Console.ReadLine();
        }
    }
}

