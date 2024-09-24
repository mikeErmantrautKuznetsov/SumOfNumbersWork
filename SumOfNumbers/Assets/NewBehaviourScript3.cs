using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class NewBehaviourScript3 : MonoBehaviour
{
    //С помощью Random получить число number, которое не больше 100.
    //Найти сумму всех положительных чисел меньше number(включая число),
    //которые кратные 3 или 5.
    //(К примеру, это числа 3, 5, 6, 9, 10, 12, 15 и т.д.)


    static void Main(string[] args)
    {
        int stepNumberthree = 3;
        int stepNumberfive = 5;

        Random randomNumbers = new Random();
        int value = randomNumbers.Next(0, 101);

        Console.WriteLine($"Число = {value}");
        for (int i = 0; i <= value; i += stepNumberthree)
        {
            Console.WriteLine($"{i} -" + " Кратное 3");
        }

        Console.WriteLine($"Число = {value}");
        for (int j = 0; j <= value; j += stepNumberfive)
        {
            Console.WriteLine($"{j} -" + " Кратное 5");
        }
    }
}
