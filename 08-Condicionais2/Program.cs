using System;

class Program 
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Executando o Projeto 8 - Condicionais2");

		int idadeJoao = 16;
		int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

		if(idadeJoao >= 18 || acompanhado)
		{
			Console.WriteLine("Pode entrar");
		} else {
			Console.WriteLine("Não pode entrar!");
		} 

		Console.WriteLine("Tecle enter para fechar...");
		Console.ReadKey(true);
	}
}
