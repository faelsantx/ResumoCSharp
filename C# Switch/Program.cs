using System;

namespace Switch;

class Program 
{
    static void Main()
    {
        int dia = 7; // declaramos a variavel com a quantidade de casos que serao usados
        switch(dia) // colocamos entre parenteses a expressao que sera usada
        {
        case 1 :
            Console.WriteLine("Segunda");
            break; // break sai do bloco do switch, ele finaliza o processo
        case 2 :
            Console.WriteLine("Terça");
            break;
        case 3 : 
            Console.WriteLine("Quarta");
            break;
        case 4 :
            Console.WriteLine("Quinta");
            break;
        case 5 :
            Console.WriteLine("Sexta");
            break;
        case 6 :
            Console.WriteLine("Sábadão");
            break;
        case 7 :
            Console.WriteLine("Domingão");
            break;
        default : // usado quando o valor nao esta no intervalo dos casos ou foi escrito errado
            Console.WriteLine("A semana só tem 7 dias"); 
            break;
        
        }
    }
}