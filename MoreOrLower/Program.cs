/* ГП Авроры: Раз ты так хорошо справляешься, вот еще одно задание. 
Я отправлю тебе 2 числа, твоя задача вывести на экран результат их сравнения *число 1 результат сравнения число 2*. */

using System;
public class MoreOrLower
{
    public static void Main()
    {
        Console.Clear();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b) 
        {
            Console.WriteLine(a + " больше " + b);
        }
        if (a == b)
        {
            Console.WriteLine(a + " равно " + b);
        }
        if (a < b) 
        {
            Console.WriteLine(a + " меньше " + b);
        }
    }
}