using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class NewBehaviourScript3 : MonoBehaviour
{
    //� ������� Random �������� ����� number, ������� �� ������ 100.
    //����� ����� ���� ������������� ����� ������ number(������� �����),
    //������� ������� 3 ��� 5.
    //(� �������, ��� ����� 3, 5, 6, 9, 10, 12, 15 � �.�.)


    static void Main(string[] args)
    {
        int stepNumberthree = 3;
        int stepNumberfive = 5;

        Random randomNumbers = new Random();
        int value = randomNumbers.Next(0, 101);

        Console.WriteLine($"����� = {value}");
        for (int i = 0; i <= value; i += stepNumberthree)
        {
            Console.WriteLine($"{i} -" + " ������� 3");
        }

        Console.WriteLine($"����� = {value}");
        for (int j = 0; j <= value; j += stepNumberfive)
        {
            Console.WriteLine($"{j} -" + " ������� 5");
        }
    }
}
