using System;

class Program
{
    public static void Main(string[] args)
    {

        double salario = 3000.15;
        Console.WriteLine(salario);

        // o float e no int apenas 32 bits podem ser armazenados
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // O long é um tipo de variável de 64 bits
        long x = 2000000000000000;
        Console.WriteLine(x);
        
        short y = 1500;
        Console.WriteLine(y);
        
        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadKey(true);
    }
}
