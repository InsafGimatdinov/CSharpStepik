/* Рейнджер: Слушай, а у тебя неплохо получается, может ты сможешь мне помочь? 
Мой друг Ксенолотлоаксель создал для меня цветок. Да-да, именно создал, используя материализацию 
(подробнее об этом тут). Так вот, я знаю его изначальный рост (a) и скорость роста по дням в % (b), 
ты сможешь написать программу, которая будет определять рост цветка каждый день до n-ого дня?
Аврора отправит тебе данные a, b и n каждое с новой строки. При выводе нужно сообщать номер дня и текущий рост.
P.S Для входных данных используй тип double */

using System;

public class LidoforeanFlow
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double result = a;
        for (double i = 1; i <= n; i++)
        {
            double percent = b / 100;
            Console.WriteLine(i + " " + result);
            result += result * percent;
        }
    }
}