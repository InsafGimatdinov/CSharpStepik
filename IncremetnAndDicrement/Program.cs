using System;
public class IncremetAndDicrement 
{
    public static void Main()
    {
        /* int a = 1;
        a = ++a * a;
        Console.WriteLine(a); */

        /* int a = 1;
        a = a++ * a;
        Console.WriteLine(a); */

        /* int a = 1;
        Console.WriteLine(a++ * a++ * a++);
        Console.WriteLine(a); */

        int a = 1;
        a = a * ++a;
        Console.WriteLine(a);
    }
}