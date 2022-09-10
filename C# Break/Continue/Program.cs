using System;

namespace Break.Continue
{
  class Program
  {
    static void Main(string[] args)
    {

     for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break; // break para toda a execução do codigo caso a condicao seja verdadeira como nesse caso
  }
  Console.WriteLine(i);
}   


for (int c = 0; c < 10; c++) 
{
  if (c == 4) 
  {
    continue; // ja o continue volta pro começo do codigo caso a condicao seja verdadeira, ele nao para a execucao
  }
  Console.WriteLine(c);

  // isso pode ser usado tanto com if ou com while loop tambem
}

    }
  }
}