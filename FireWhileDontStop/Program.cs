/* Рейнджер: Итак, используя цикл for, тебе нужно написать программу, которая будет совершать выстрел "Выстрел совершен", 
а также писать количество израсходованных боезапасов, при этом, после каждой итерации, 
программа должна осуществлять возможность остановки огня, как только мы введем "Стоп". */

using System;
public class FireWhileDontStop
{
    public static void Main()
    {
        int count = 0;
        bool condit = true;
        string empty = Console.ReadLine();
        for (int i = 0; i < 1000; i++)
        {
            empty = Console.ReadLine();
            Console.WriteLine("Выстрел совершен");
            count++;
            Console.WriteLine(count);
            if (empty == "Стоп")
            {
                condit = false;
                break;
            }
        } 
    }
}