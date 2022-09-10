using System;

namespace TypeCasting;

class Program
{
    static void Main()
    {
    // Implicit Casting = Conversão do menor pro maior
    // Explicit Casting = Conversão de maior pro menor

    int myIntex = 10;
    double myDoublex = 5.25;
    bool myBoolex = true;

    Console.WriteLine(Convert.ToString(myIntex));    // converte int em string
    Console.WriteLine(Convert.ToDouble(myIntex));    // converte int em double
    Console.WriteLine(Convert.ToInt32(myDoublex));  // converte double em int
    Console.WriteLine(Convert.ToString(myBoolex));   // converte bool em string

    }
}