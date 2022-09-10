using System;

namespace arrays;

class Program
{
    static void Main()
    {

    string[] carro; // declaracao de um array
    string[] carros = {"Volvo", "BMW", "Ford", "Mazda"}; // Para inserir valores neles faremos dessa forma

    int[] numeros = {10, 20, 30, 40}; // array de inteiro

    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    Console.WriteLine(cars[0]); // acessa o valor de acordo com o indice do array (indice começa do numero 0)

    cars[0] = "Opel"; // insere um valor direto no numero do indice do array

    string[] carroes = {"Volvo", "BMW", "Ford", "Mazda"};
    Console.WriteLine(carroes.Length); // mostra quantos elementos o array possui

    string[] carrinhos = {"Volvo", "BMW", "Ford", "Mazda"};
    for (int i = 0; i < cars.Length; i++) 
    {
    Console.WriteLine(cars[i]); // loop com array
    }

    string[] carruus = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in carruus) // o foreach listara todos os elementos do array 
    {
    Console.WriteLine(i);
    }

    
    string[] marcas = {"Volvo", "BMW", "Ford", "Mazda"};
    Array.Sort(marcas);  // array.sort mostrara os elementos em ordem alfabetica
    foreach (string i in marcas)
    {
    Console.WriteLine(i);
    }

    
    int[] myNumbers = {5, 1, 8, 9};
    Array.Sort(myNumbers); // e nesse caso mostrara os elementos em ordem crescente
    foreach (int i in myNumbers)
    {
    Console.WriteLine(i);
    }

    // using System.Linq; com isso podemos indicar maiores,menores e a soma dos valores de um array
    /* EXEMPLO: int[] numeros = {5, 1, 8, 9};
       Console.WriteLine(numeros.Max());  
       Console.WriteLine(numeros.Min());  
       Console.WriteLine(numeros.Sum()); */  

    }
}