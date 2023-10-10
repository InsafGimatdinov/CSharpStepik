﻿/* Рейнджер: Внимание, я активировал защитное поле. Теперь твоя задача написать программу, 
которая по приблизительным координатам астероида через 30 секунд 
(мы считаем эти координаты по примерной траектории движения астероида) определит, 
попадет ли астероид строго во внутрь защитного поля.
*Защитное поле представляет собой окружность радиусом 5.
Программа должна вывести Да , если астероид попадет в поле, и Нет в противном случае.
Подсказка: уравнение окружности выглядит так: x * x + y * y = r * r
где x и y - это координаты астероида (подаются на вход в Input), а r - радиус защитного поля. */

using System;
public class HitAsteroid
{
    public static void Main() 
    {
        double x = int.Parse(Console.ReadLine());
        double y = int.Parse(Console.ReadLine());
        double rShield = 5;
        double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (r < rShield) 
        {
            Console.WriteLine("Да");
        } 
        else
        {
            Console.WriteLine("Нет");
        }
    }
}