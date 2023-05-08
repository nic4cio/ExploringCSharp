using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Executing...");

        double investimento = 1000;

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine($"No mês {mes} vocês tem {investimento}");

           
        }

        Console.WriteLine("Press enter to leave...");
        Console.ReadKey(true);
    }
}