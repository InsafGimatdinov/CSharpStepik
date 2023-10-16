/* Рейнджер: Пока я веду огонь, можешь решить еще одну задачку. Аврора будет отправлять тебе числа, 
если вдруг число не делится на 7, выведи последнее отправленное число и останови программу. */

using System;
public class WhileWeShare
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; ; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number % 7 != 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}