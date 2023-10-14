/* Рейнджер: Неплохо справляешься, вот еще одна задачка. 
У меня есть вот такое уравнение x^2 + 4x + 4 = 0 твоя задача написать программу, 
которая найдет первый подходящий корень уравнения и выведет его на экран.
P.S Бери диапазон поиска от -10 до 10 */

using System;
public class SelectionOfRoots
{
    public static void Main()
    {
        for (int i = -10; i < 10; i++)
        {
            double equal = Math.Pow(i, 2) + 4 * i + 4;
            if (equal == 0)
            {
                Console.WriteLine(i);
                break;
            }
        } 
    }
}