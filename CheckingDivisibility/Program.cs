/* Рейнджер: Отлично, может еще задачку? Аврора отправит на твой M.O.V.E четырехзначное число, 
твоя задача - проверить делится ли первая цифра этого числа на 2 и последняя на 3. 
Если цифры делятся, выведи True, иначе - False. */

using System;
public class CheckingDivisibility
{
    public static void Main() 
    {
        int number = int.Parse(Console.ReadLine());
        int firstDigit = ((number / 1000) % 10) % 2;
        int lastDigit = (number % 10) % 3;
        bool isTrue = true;
        if (firstDigit == 0 && lastDigit == 0)
        {
            Console.WriteLine(isTrue);
        }
        else 
        {
            Console.WriteLine(!isTrue);
        }
    }
}