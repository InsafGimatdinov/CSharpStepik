/* Рейнджер: Неплохо справляемся, вот тебе дополнительная задачка. 
Аврора отправит на твой M.O.V.E четырехзначное число, твоя задача - проверить делится ли первая цифра этого числа на 2. 
Если цифра делится, выведи True, иначе - False. */

using System;
public class CheckingTheDivision
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int firstDigit = (number / 1000) % 10;
        bool truth = true;
        if (firstDigit % 2 == 0) 
        {
            Console.WriteLine(truth);
        }
        else
        {
            truth = false;
            Console.WriteLine(truth);
        }
    }
}