using System;

namespace Output;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá!"); 
        Console.WriteLine("Meu nome é Rafael."); // WriteLine insere uma nova linha para cada frase.
        Console.WriteLine("Eu tenho 18 anos.");

        Console.Write("Olá!"); 
        Console.Write("Meu nome é Rafael."); // Write apenas segue as escritas na frente sem pular linha
        Console.Write("Eu tenho 18 anos.");
    }
}