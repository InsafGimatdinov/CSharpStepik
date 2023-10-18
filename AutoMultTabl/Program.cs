/* Рейнджер: Ты отлично справился. Пока я буду чистить ошибки, напиши программу, которая на входе принимает два числа. 
Первое - число, с которого начинается операция, второе - количество операций.
Затем она должна вывести на экран результат умножения первого числа на два (см. примеры). 
С каждым повторением число должно увеличиваться на единицу. */

using System;
public class AutoMultTabl
{
    public static void Main()
    {
        int startNumb = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int multRes = startNumb * 2;
            Console.WriteLine(startNumb + " * " + 2 + " = " + multRes);
            startNumb++;
        }
    }
}