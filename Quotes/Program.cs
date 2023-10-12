/* Рейнджер: Я отправлю на твой M.O.V.E строку (какие-то очень древние цитаты),
 а на следующей строке количество раз, которое нужно ее вывести, твоя задача написать программу, 
которая выведет заданную строку заданное количество раз. */

using System;
public class Quotes
{
    public static void Main()
    {
        string qoute = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(qoute);
        }
    }   
    
}