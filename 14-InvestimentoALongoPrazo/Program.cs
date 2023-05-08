using System;

class Programa
{
    public static void Main(string[] args)
    {

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {   
                investimento *= fatorRendimento;
            }

            fatorRendimento = fatorRendimento + 0.001;
        } 

        Console.WriteLine($"Depois dos 5 anos você terá R${investimento}");

        Console.WriteLine("press enter to exit...");
        Console.ReadKey(true);
    }
}