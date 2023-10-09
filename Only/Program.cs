/* ГП Авроры: А вот тебе еще одно задание. Я отправлю тебе 4 числа, твоя задача вывести сумму только отрицательных чисел. */

using System;
public class Only
{
    public static void Main() 
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int sum = 0;
        if (a < 0) {
            sum += a;
        }
        if (b < 0) 
        {
            sum += b;
        }
        if (c < 0) 
        {
            sum += c;
        }
        if (d < 0) 
        {
            sum += d;
        }
        Console.WriteLine(sum);
    }
}