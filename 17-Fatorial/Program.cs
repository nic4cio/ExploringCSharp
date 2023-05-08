using System;

class Program
{

    public static void Main(string[] args)
    {
        int n = 5;
        int fac = 1;
        for(int i = 1; i <= n; i++)
        {
            fac = fac * i;
            Console.WriteLine($"O Fatorial de {i} é {fac}");
        }
    }

}
