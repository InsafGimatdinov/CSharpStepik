/* Рейнджер: Что никак не можешь уснуть? Ладно, есть еще один способ)
Аврора отправит тебе число - количество овец. Твоя задача посчитать их в обратном порядке. 
Так, например, если она отправит 3 - просто выведи строку с бормотанием "3 sheep...2 sheep...1 sheep...".
P.S Примени знания по новой теме "Цикл for в обратном порядке" */

using System;
public class CountTheSleep2
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = count; i >= 1; i--)
        {
            Console.Write(i + " sheep...");
        }
    }
}