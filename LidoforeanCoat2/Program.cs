/* Рейнджер: Супер, но нужно немного улучшить программу. Тебе все также нужно принимать все значения, 
которые подает аврора, если значение не соответствует моему пальто, выведи его, но если пальто нашлось,
останови программу и выведи количество попыток, которое потребовалось Авроре для этого. */

using System;
public class LidoforeanCoat2
{
    public static void Mian()
    {
        string coat = Console.ReadLine();
        int count = 0;
        while (coat != "Лидофореанское пальто")
        {
            if (coat == "Лидофореанское пальто")
            {
                break;
            }
            Console.WriteLine(coat);
            count++;
            coat = Console.ReadLine();
        } 
        Console.WriteLine(count);    
    }
}
