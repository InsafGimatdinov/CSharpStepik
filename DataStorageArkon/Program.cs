/* Рейнджер: Отлично! Пока я справляюсь с астероидами вот тебе дополнительная задача. 
Аврора отправит тебе список данных об одном из представителей расы 
"Арконцев": Планета, Поселение, Вид, Имя, Возраст (каждый на разной строке). 
После чего отправит запрос на вывод данных ("Планета", "Поселение", "Вид", "Имя", "Возраст"). 
Например, Аврора запросила "Имя", в таком случае твоя задача вывести имя, которое было передано в начале.
-----------------------------------------------------------------------------------------------------
P.S Не забудь выполнить проверку на наличие данных. 
Так, Аврора может запросить, например, должность Арконца, но таких данных в системе нет, 
в таком случае, выведи "Данные в системе отсутствуют". */

using System;
public class DataStorageArkon
{
    public static void Main()
    {
        Console.Clear();
        string planet = Console.ReadLine();
        string settlement = Console.ReadLine();
        string view = Console.ReadLine();
        string name = Console.ReadLine();
        string age = Console.ReadLine();
        string request = Console.ReadLine();
        if (request == "Планета") 
        {
            Console.WriteLine(planet);
        }
        if (request == "Поселение") 
        {
            Console.WriteLine(settlement);
        } 
        if (request == "Вид")
        {
            Console.WriteLine(view);
        }
        if (request == "Имя")
        {
            Console.WriteLine(name);
        }
        if (request == "Возраст")
        {
            Console.WriteLine(age);
        }
        else 
        {
            Console.WriteLine("Данные в системе отсутствуют");
        }
    }
}