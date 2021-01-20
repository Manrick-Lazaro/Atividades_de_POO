using System;

class Program
{
  public static void Main(string[] args)
  {
    int litros = 12;
    int horas = int.Parse(Console.ReadLine());
    int velocidade = int.Parse(Console.ReadLine());

    double distancia = velocidade * horas;
    double total = distancia / litros;

    Console.WriteLine($"{total:0.000}");
  }
}