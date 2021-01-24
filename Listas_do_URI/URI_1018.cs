using System;

class Program
{
  public static void Main(string[] args)
  {
    int valor = int.Parse(Console.ReadLine());

    int valor_100 = valor / 100;
    int resto_100 = valor % 100;

    int valor_50 = resto_100 / 50;
    int resto_50 = resto_100 % 50;

    int valor_20 = resto_50 / 20;
    int resto_20 = resto_50 % 20;

    int valor_10 = resto_20 / 10;
    int resto_10 = resto_20 % 10;

    int valor_5 = resto_10 / 5;
    int resto_5 = resto_10 % 5;

    int valor_2 = resto_5 / 2;
    int resto_2 = resto_5 % 2;

    int valor_1 = resto_2 / 1;

    Console.WriteLine(valor);
    Console.WriteLine($"{valor_100} nota(s) de R$ 100,00");
    Console.WriteLine($"{valor_50} nota(s) de R$ 50,00");
    Console.WriteLine($"{valor_20} nota(s) de R$ 20,00");
    Console.WriteLine($"{valor_10} nota(s) de R$ 10,00");
    Console.WriteLine($"{valor_5} nota(s) de R$ 5,00");
    Console.WriteLine($"{valor_2} nota(s) de R$ 2,00");
    Console.WriteLine($"{valor_1} nota(s) de R$ 1,00");
  }
}