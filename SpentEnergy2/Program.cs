﻿/* ГП «Авроры»:  Я приняла сигнал от неизвестного источника, задача похожа на прошлую. 
Пока рейнджер разбирается с космическим мусором, попробуй ее решить ; )
----------------------------------------------------------------------------------
Навстречу кораблю летят астероиды разных диаметров, для уничтожения которых оружию требуется разное количество энергии.
 Чтобы уничтожить астероид диаметром до 100км оружию необходим запас энергии 20 ед. для уничтожения 
 астероида от 100км до 300км потребуется запас энергии 70 ед., и для уничтожения астероида 
 диаметром более 300км потребуется запас энергии 200ед. Аврора будет отправлять тебе диаметр ближайшего астероида, 
 находящегося на твоём пути. Выведи запас энергии, необходимый для его уничтожения. */

using System;
public class SpentEnergy2
{
    public static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());
        if (diameter < 100 && diameter > 0) 
        {
            Console.WriteLine(20);
        }
        else if (diameter >= 100 && diameter < 300)
        {
            Console.WriteLine(70);
        }
        else if (diameter >= 300)
        {
            Console.WriteLine(200);
        }
    }
}