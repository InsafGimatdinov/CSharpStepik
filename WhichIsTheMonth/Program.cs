/* Рейнджер: Неплохо! Вот задача посложнее. Составь программу, которая в зависимости от порядкового 
номера месяца (1, 2 ... 12) выводит на экран его название с заглавной буквы (Январь, Февраль ... Декабрь). */

using System;
public class WhichIsTheMonth
{
    public static void Main() 
    {
        int numbreOfMonths = int.Parse(Console.ReadLine());
        switch (numbreOfMonths)
        {
            case 1:
                Console.WriteLine("Январь");
            break;
            case 2:
                Console.WriteLine("Февраль");
            break;
            case 3:
                Console.WriteLine("Март");
            break;
            case 4:
                Console.WriteLine("Апрель");
            break;
            case 5:
                Console.WriteLine("Май");
            break;
            case 6:
                Console.WriteLine("Июнь");
            break;
            case 7:
                Console.WriteLine("Июль");
            break;
            case 8:
                Console.WriteLine("Август");
            break;
            case 9:
                Console.WriteLine("Сентябрь");
            break;
            case 10:
                Console.WriteLine("Октябрь");
            break;
            case 11:
                Console.WriteLine("Ноябрь");
            break;
            case 12:
                Console.WriteLine("Декабрь");
            break;
        }
    }
}