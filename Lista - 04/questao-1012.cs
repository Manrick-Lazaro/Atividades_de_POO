using System;

class MainClass
{
  static void Main(string[] args)
  {
    string[] dados = Console.ReadLine().Split(' ');

    double a = double.Parse(dados[0]);
    double b = double.Parse(dados[1]);
    double c = double.Parse(dados[2]);

    double triangulo = (a * c) / 2;
    double circulo = (Math.Pow(c,2)) * 3.14159;
    double trapezio = (a + b) * c / 2;
    double quadrado = b * b;
    double retangulo = a * b;

    Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
    Console.WriteLine($"CIRCULO: {circulo:0.000}");
    Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
    Console.WriteLine($"QUADRADO: {quadrado:0.000}");
    Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}