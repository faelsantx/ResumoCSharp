using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    string nome = "Fael"; //cria uma variavel do tipo string ja setando um valor pra ela
    Console.WriteLine(nome); //mostra o valor da variavel   

    int n1 = 15; // criação de uma variavel do tipo inteiro
    Console.WriteLine(n1); 

    int num; //cria a variavel nessa linha
    num = 15; //e seta o valor nessa outra linha  
    Console.WriteLine(num);

    int numero = 15; //cria a variavel e seta o valor
    numero = 20; // substitui o valor setado por um novo
    Console.WriteLine(numero);

    const int valor = 15; // utilizando a palavra const setamos um valor imutável na variavel
    valor = 20; // aqui ocorre um erro pois o valor nao pode ser alterado

    string name = "Fael";
    Console.WriteLine("Oi " + name); //podemos combinar textos com variaveis usando o +

    string primeiroNome = "Rafael ";
    string sobrenome = "Santos";
    string nomeCompleto = primeiroNome + sobrenome; // podemos fazer combinacao entre duas variaveis
    Console.WriteLine(nomeCompleto);

    int x = 5;
    int y = 6;
    Console.WriteLine(x + y); // podemos fazer soma entre duas variaveis

    int a = 5, b = 6, c = 50; // setar valores em variaveis do mesmo tipo em uma linha
    Console.WriteLine(a + b + c); 

    int g, h, i;
    g = h = i = 50; //podemos setar o mesmo valor em diferentes variaveis na mesma linha
    Console.WriteLine(g + h + i);
    
    }
  }
}
