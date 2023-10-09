/* Рейнджер: А теперь небольшая практика, Аврора отправит на твой M.O.V.E 3 числа, 
каждое с новой строки, выведи наибольшее из этих чисел (гарантируется, что повторы чисел отсутствуют) */

using System;
public class MaxFromThree
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.WriteLine(max);
    }
}