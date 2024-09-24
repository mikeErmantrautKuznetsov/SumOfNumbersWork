using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    static void Main(string[] args)
    {
        //Ќужно написать программу(использу€ циклы, об€зательно по€снить выбор вашего цикла),
        //чтобы она выводила следующую последовательность
        //5 12 19 26 33 40 47 54 61 68 75 82 89 96
        //Ќужны переменные дл€ обозначени€ чисел в условии цикла.

        int stepCicleI = 6;
        int startCicle = 5;
        int endCicle = 96;

        cicleForever(endCicle, startCicle, stepCicleI);
    }

    static void cicleForever(int endCicle, int startCicle, int stepCicleI)
    {
        for (int i = startCicle; i <= endCicle; i++)
        {
            Console.WriteLine(i);
            i = i + stepCicleI;
        }
    }
}
