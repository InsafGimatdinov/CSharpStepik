/* Рейнджер: А сейчас твои знания по новой теме сильно пригодятся. 
Составь программу, которая будет принимать на вход первое число - количество сигналов, 
затем каждый сигнал с новой строки. Если сигнал представляет четное число - на экран выводится "Ошибка", 
в противном случае "Ошибок нет".
При решении лучше использовать цикл for. */

using System;
public class FindFails
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int signal = int.Parse(Console.ReadLine());
            if (signal % 2 == 0)
            {
                Console.WriteLine("Ошибка");
            }
            else if (signal % 2 != 0) 
            {
                Console.WriteLine("Ошибок нет");
            }
        }
    }
}