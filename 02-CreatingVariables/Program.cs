
class Program {
    static void Main(string[] args){
        Console.WriteLine("Criando Variáveis");

        int idade;

        idade = 27;
        Console.WriteLine($"minha idade agora é {idade}");

        idade = 27 - 5;
        Console.WriteLine($"minha idade agora é {idade}");

        idade = 5 * 2 - 6;
        Console.WriteLine($"minha idade agora é {idade}");

        idade = (5 - 2) * 3;   
        Console.WriteLine($"minha idade agora é {idade}");

        Console.WriteLine("Press any key to exit");
        Console.ReadKey(true);
    }
}