using System;

class Program
{
  public static void Main(string[] args)
  {
    int distancia = int.Parse(Console.ReadLine());
    int minuto= distancia * 2;

    Console.WriteLine($"{minuto} minutos");
  }
}