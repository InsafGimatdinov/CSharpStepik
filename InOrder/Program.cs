/* Рейнджер: А получится у тебя написать такую программу, которая вначале примет значение, 
после чего построчно выведет все числа от одного до этого значения (включительно)? */

using System;
public class InOrder
{
    public static void Main() 
    {
        int number = int.Parse(Console.ReadLine());
        int count = 1;
        while (count <= number)
        {
            Console.WriteLine(count);
            count++;
        }
    }
}