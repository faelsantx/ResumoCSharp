using System; 

namespace UserInput;

class Program 
{
    static void Main()
    {
      
        string nome;
        
        Console.WriteLine ("Digite seu nome: ");
        nome = Console.ReadLine(); 
        Console.WriteLine("Seu nome é:" + nome); /* Readline obtem o valor da variavel na execução do 
        programa ao inves de serem setados por codigo (ProximoAoCodigoLeiaDoVisualG) */

    }
}