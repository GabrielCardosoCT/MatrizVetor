using System;

class Program
    {
    static void Main (string[] args)
        {

        int soma = 0;
        

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Valor {i}: ");
            int valor = int.Parse(Console.ReadLine());

            soma += valor;
        }
        
        Console.WriteLine();

        int media = soma / 10;
        Console.WriteLine(media);
        }
    }
