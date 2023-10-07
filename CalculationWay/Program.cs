/*
Рейнджер: Супер, теперь мы знаем координаты, давай рассчитаем расстояние, которые мы должны преодолеть. 
На M.O.V.E аврора отправит тебе наши координаты x1 на 1 строке, y1 на 2 строке, 
и координаты планеты Кона x2 на 3 строке, y2 на 4 строке. Твоя задача рассчитать квадрат пути в а. е.
P.S Используй формулу нахождения длины отрезка через координаты: d^2 = (х2 – х1)^2 + (y2 – y1)^2, 
где d - длина пути; x1,y1 - координаты Авроры; x2,y2 - координаты планеты Кона.
*/
using System;
public class CalculationWay
{
    public static void Main()
    {
        Console.Clear();
        double x1 = double.Parse(Console.ReadLine()); // Наша координата 
        double y1 = double.Parse(Console.ReadLine()); // Наша координата
        double x2 = double.Parse(Console.ReadLine()); // Планета Кона координата
        double y2 = double.Parse(Console.ReadLine()); // Планета Кона координата
        double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); // Расстояние между Авророй и Коной
        Console.WriteLine(Math.Pow(d, 2));
    }
}


