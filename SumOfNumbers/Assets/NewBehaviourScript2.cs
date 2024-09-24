using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ведите сообщение: ");
        string messageRepeat = Console.ReadLine();
        Console.WriteLine("Сколько нужно повторить? ");
        string repeatMany = Console.ReadLine();
        bool isSuccess = int.TryParse(repeatMany, out int resultInputMany);
        int startPosition = 0;


        while (startPosition < resultInputMany)
        {
            Console.WriteLine(messageRepeat);
            startPosition++;
            if (startPosition == resultInputMany)
                break;
        }

        foreach (var item in messageRepeat)
        {
            if (startPosition == resultInputMany && isSuccess == true)
                Console.WriteLine("Сообщение вывелось " + resultInputMany);
            else if (startPosition == resultInputMany && !isSuccess)
                Console.WriteLine("Ошибка ввода");
            break;

        }
    }
}
