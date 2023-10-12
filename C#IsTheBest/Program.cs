/* Рейнджер: Напиши программу, которая 15 раз выведет "C# is the BEST!". */

using System;
public class IsTheBest
{
    public static void Main()
    {
        string text = "C# is the BEST!";
        for (int i = 0; i <= 15; i++)
        {
            Console.WriteLine(text);
        }
    }
}