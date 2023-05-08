using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 12 - Calcula Poupança");

        double investimento = 1000;

        //rendimento 0.5% (0.005) ao mês

        int mes = 1;
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine($"No mês {mes} o investimento foi de: {investimento}");

            mes++;
        }


        Console.WriteLine("Press enter to exit...");
        Console.ReadKey(true);
    }
}