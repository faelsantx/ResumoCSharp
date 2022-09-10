using System ;

namespace forloop;

class Program
{
    static void Main()
    {
   
    /*(é executada uma vez antes do bloco do codigo);(condição do codigo);
    (é executada todas as vezes após a execução do código)*/
    for (int i = 0; i <= 10; i = i + 2) // o i recebe 0 e se ele for menor que 10 ele recebe +2
    {
    Console.WriteLine(i);
    }

    }
    }
