/* Рейнджер: А у тебя неплохо получается применять теорию на практике, 
вот тебе еще одна задачка. Нужно рассчитать, 
сколько энергии потребуется для уничтожения мешающего космического мусора. Обычно на 1 объект уходит 20 единиц энергии, 
но если мы попали в 7 или более объектов из-за взрывной волны мы экономим и тратим в 2 раза меньше энергии, 
а если в 3 или более, то мы сэкономим лишь 20% энергии.
Аврора отправит тебе количество мусора, находящихся на нашем пути, выведи количество энергии, 
которое потребуется для их уничтожения. */

using System;
public class SpentEnergy
{
    public static void Main()
    {
        double countGarbage = int.Parse(Console.ReadLine());
        double energyOneObj = 20;
        double energy;
        double fullEnergy;
        if (countGarbage >= 7) 
        {
            energy = energyOneObj / 2;
            fullEnergy = energy * countGarbage;
            Console.WriteLine(fullEnergy);
        }
        else if (countGarbage >= 3 || countGarbage > 7)
        {
            energy = energyOneObj - energyOneObj * 0.2;
            fullEnergy = energy * countGarbage;
            Console.WriteLine(fullEnergy);
        }
        else if (countGarbage > 0 || countGarbage < 3)
        {
            fullEnergy = energyOneObj * countGarbage;
            Console.WriteLine(fullEnergy);
        }
    }
}