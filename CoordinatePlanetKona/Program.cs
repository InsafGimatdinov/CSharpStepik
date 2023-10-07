/*
Рейнджер: А ты неплохо справился, мы успешно вышли на орбиту. 
Теперь рассчитай координаты планеты арконцев «Кона».
Для расчета координат напиши программу, которая выводит сначала сумму, 
а потом на новой строке частное введённых построчно с консоли дробных чисел.
*/
using System;
public class CoordinatePlanetKona
{
    public static void Main() 
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double sum = x + y;
        double div = x / y;

        Console.WriteLine(sum);
        Console.WriteLine(div);

    }
}