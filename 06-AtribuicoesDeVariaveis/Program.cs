using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}