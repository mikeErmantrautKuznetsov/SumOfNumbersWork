using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    static void Main(string[] args)
    {
        // Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
        //Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
        //Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.

        int cicleContinion = 0;
        string codWordStart = "Start";
        string codWordEnd = "Exit";
        Console.WriteLine("Для начала работы программы, наберите Start");
        string endProgram = Console.ReadLine();

        switch (endProgram)
        {
            case "Start":
                Console.WriteLine("Начала цикла! Для выхода наберите Exit.");
                CicleForever(codWordStart, cicleContinion, codWordEnd, endProgram);
                break;
            case "Exit":
                Console.WriteLine("Выход из программы");
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }

    }
    static void CicleForever(string codWordStart, int cicleContinion, string codWordEnd, string endProgram)
    {
        while (endProgram == codWordStart)
        {
            Console.WriteLine("Безконечный цикл!");
            endProgram = Console.ReadLine();
        }
    }
}

