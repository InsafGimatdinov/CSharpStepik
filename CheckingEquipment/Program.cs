/* Рейнджер: А вот и новая задачка, посмотрим, как ты усвоил тему. Аврора отправит тебе число n - это количество снаряжения, 
которое мы взяли. Затем n строк, на каждой названия снаряжения. 
Твоя задача построчно вывести каждый элемент, возможно, удастся найти что-то, что поможет в это ситуации. */

using System;
public class CheckingEquipment
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string equip = Console.ReadLine();
            Console.WriteLine(equip);
        }
    }
}