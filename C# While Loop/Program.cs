using System;

namespace whileloop;

class Program
{
    static void Main()
    {
        
    int i = 0;
    while (i < 5) // while = enquanto a expressao for verdadeira ele executara o codigo em loop 
    {
    Console.WriteLine(i);
    i++;
    }

    int f = 0;
    do // do while executa pelo menos uma vez o codigo mesmo que a expressao seja falsa
    {
    Console.WriteLine(f);
    f++;
    }
    while (f < 5);  

    }
}