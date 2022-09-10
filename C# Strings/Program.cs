using System;

namespace Strings;

class Program
{
    static void Main()
    {
        
    string teste = "oi"; //cria uma variavel do tipo string e seta o valor dela
    string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    Console.WriteLine("O tamanho da variavel é: " + txt.Length);

    string bill = "BoRAa";
    Console.WriteLine(bill.ToUpper());   // Transforma a palavra toda em 'MAIUSCULA'
    Console.WriteLine(bill.ToLower());   // Transforma a palavra toda em 'minuscula'

    string nomee = "Rafael "; // Colocamos um espaço no final para separar as duas strings 
    string sobrenomee = "Santos";
    string full = string.Concat(nomee, sobrenomee); // Usamos o "Concat" para concatenar as duas strings
    Console.WriteLine(full);

    string seuNome  = "John"; // Na interpolação na colocamos espaço na frente
    string seuSobrenome = "Doe";
    string completo = $"My full name is: {seuNome} {seuSobrenome}"; /* tem que ser usado o "$" para o 
    metodo de interpolação */
    Console.WriteLine(completo);

    string myString = "Brasil";
    Console.WriteLine(myString[0]);  /* Para saber a posicao de cada letra da string, lembrando que
    começamos a contar do numero 0 */


    }
}