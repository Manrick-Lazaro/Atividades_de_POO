using System;

class Program
{
  static void Main(string[] args)
  {
    double N = 3.14159;
    double raio = double.Parse(Console.ReadLine());
    double area = N * (raio * raio);

    Console.WriteLine($"A={area:0.0000}");
  }
}