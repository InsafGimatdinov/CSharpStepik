/* Рейнджер: Напиши программу, которая будет давать нам ответ на вопрос "Стоит ли активировать щит?". 
Аврора отправит тебе два параметра:
1 - Совершено ли в нас попадание астероидом (True - да, False - нет);
2 - Активирован ли щит на данный момент (True - да, False - нет).
Если в нас попал астероид и щит не активирован, следовательно, 
нужно активировать щит (True - активировать щит), в других случаях щит активировать не нужно 
(False - щит активировать не нужно). */

using System;
public class ActivateShield
{
    public static void Main()
    {
        bool isHit = bool.Parse(Console.ReadLine());
        bool isActShield = bool.Parse(Console.ReadLine());
        bool shield = true;
        if (isHit == true && isActShield == false)
        {
            Console.WriteLine(shield);
        }
        else 
        {
            shield = false;
            Console.WriteLine(shield);
        }
    }
}