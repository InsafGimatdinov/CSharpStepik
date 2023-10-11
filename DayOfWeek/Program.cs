/* Рейнджер: Отлично! Пока идет диагностика реши-ка следующую задачу. 
Составь программу, которая в зависимости от порядкового номера дня недели (1, 2 ... 7) 
выводит на экран его название с заглавной буквы (Понедельник, Вторник ... Воскресенье). */

using System;
public class DayOfWeek
{
    public static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
            Console.WriteLine("Понедельник");
            break;
            case 2:
                Console.WriteLine("Вторник");
            break;
            case 3:
                Console.WriteLine("Среда");
            break;
            case 4:
                Console.WriteLine("Четверг");
            break;
            case 5:
                Console.WriteLine("Пятница");
            break;
            case 6:
                Console.WriteLine("Суббота");
            break;
            case 7:
                Console.WriteLine("Воскресенье");
            break;
        } 
    }
}