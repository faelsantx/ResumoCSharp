using System;

namespace sesenao
{
  class Program
  {
    static void Main(string[] args)
    {
    
if (20 > 18) // if é usado para realizar comandos a partir de condições verdadeiras
{
  Console.WriteLine("20 é maior que 18"); 
}
else { // se a condição for falsa utilizamos o else 
    Console.WriteLine("20 é menor que 18"); 
}

int hora = 22;
if (hora < 10) 
{
  Console.WriteLine("Bom dia.");
} 
else if (hora < 20) // else if é usado para fazer o se encadeado
{
  Console.WriteLine("Boa tarde.");
} 
else 
{
  Console.WriteLine("Boa noite.");
}


int horario = 20;
string rst = (time < 18) ? "Bom dia." : "Boa noite."; // operador ternario é usado em casos de if else simples
Console.WriteLine(rst);

    }
  }
}
