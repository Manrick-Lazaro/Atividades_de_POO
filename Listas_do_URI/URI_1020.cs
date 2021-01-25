using System;

class Program
{
  public static void Main(string[] args)
  {
    int valor = int.Parse(Console.ReadLine());

    int ano = valor / 365;
    int mes = (valor % 365) / 30;
    int dia = (valor % 365) % 30;

    Console.WriteLine($"{ano} ano(s)");
    Console.WriteLine($"{mes} mes(es)");
    Console.WriteLine($"{dia} dia(s)");
  }
}