using System;

class Program
{
  static void Main(string[] args)
  {
    double raio = double.Parse(Console.ReadLine());
    double volume = (4/3.0) * 3.14159 * Math.Pow(raio,3);

    Console.WriteLine($"VOLUME = {volume:0.000}");
  }
}