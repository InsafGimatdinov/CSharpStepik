/* Рейнджер: Отлично! Теперь твоя задача написать программу, которая по тем же координатам астероида определит, 
коснется ли астероид защитного поля. 
*Защитное поле представляет собой окружность радиусом 5.
Программа должна вывести Да , если астероид попадет в поле, и Нет в противном случае.
Подсказка: уравнение окружности выглядит так:
x * x + y * y = r * r
где x и y - это координаты астероида, а r - радиус защитного поля. */

using System;
public class TouchShield
{
    public static void Main()
    {   
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double rShield = 5;
        double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (rShield >= r)
        {
            Console.WriteLine("Да");
        }
        else{
            Console.WriteLine("Нет");
        }
    }
}