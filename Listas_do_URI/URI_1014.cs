using System;

class Program
{
  public static void Main(string[] args)
  {
    int distancia = int.Parse(Console.ReadLine());
    double consumo = double.Parse(Console.ReadLine());

    double consumoMedio = distancia / consumo;

    Console.WriteLine($"{consumoMedio:0.000} km/l");
  }
}