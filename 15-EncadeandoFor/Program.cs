using System;

class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto...");

        //*
        //**
        //***
        //****
        //*****

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j ++)
            {
                Console.Write("*");
                if(j >= i)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        

        Console.WriteLine("press enter to exit...");
        Console.ReadKey(true);
    }
}