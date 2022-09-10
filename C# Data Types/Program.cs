using System;

namespace Datatype;

class Program
{
    static void Main()
    {
        
    int testeInt = 100000; // int é usado para armazenar numeros inteiro de -2147483648 a 2147483647.
    Console.WriteLine(testeInt);  

    long testeLong = 15000000000L; 
    Console.WriteLine(testeLong); /* long é usado quando int não é suficiente para armazenar o valor,
    e long pode armazenar numeros inteiros de -9223372036854775808 a 9223372036854775807. */

    float testeFloat = 5.75F;
    Console.WriteLine(testeFloat); /* float é usado para numeros decimais com seis ou sete numeros 
    após o ponto decimal */

    double testeDouble = 19.99D;
    Console.WriteLine(testeDouble); /* double é usado também para números decimais, porém 
    com 15 números após o ponto decimal */

    bool brasilHexa = true;
    bool miojoEhRuim = false;
    Console.WriteLine(brasilHexa);
    Console.WriteLine(miojoEhRuim); // bool é usado para armazenar valor verdadeiro ou falso

    char turma = 'B';
    Console.WriteLine(turma); /* char é usado para armazenar um único caractere e deve ser escrito entre
    aspas simples */

    string testeString = "Hello World";
    Console.WriteLine(testeString); // string é usado para armazenar uma sequencia de caracteres (texto)

    }
}