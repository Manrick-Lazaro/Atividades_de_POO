using System;

class Program
{
  static void Main(string[] args)
  {
    string[] lista_1 = Console.ReadLine().Split(" ");
    int codigo_1 = int.Parse(lista_1[0]);
    int quantidade_1 = int.Parse(lista_1[1]);
    double valor_1 = double.Parse(lista_1[2]);

    string[] lista_2 = Console.ReadLine().Split(" ");
    int codigo_2 = int.Parse(lista_2[0]);
    int quantidade_2 = int.Parse(lista_2[1]);
    double valor_2 = double.Parse(lista_2[2]);

    double total = (quantidade_1 * valor_1) + (quantidade_2 * valor_2);

    Console.WriteLine($"VALOR A PAGAR: R$ {total:0.00}");
  }
}