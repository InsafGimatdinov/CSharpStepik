/* Рейнджер: Ты хорошо поработал, самое время немного вздремнуть, вряд ли это удастся сделать в ближайшее время...
Если есть проблемы со сном, не переживай. Аврора отправит тебе число - количество овец. Так, например, 
если она отправит 3 - просто выведи строку с бормотанием "1 sheep...2 sheep...3 sheep...". */

using System;
public class CountTheSleep
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 1; i <= count; i++)
        {
            Console.Write(i + " sheep...");
        }
    }
}