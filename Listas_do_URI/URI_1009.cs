using System;

class Program
{
  static void Main(string[] args)
  {
    string nome = Console.ReadLine();
    double salarioF = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());

    double bonus = vendas * 0.15;
    double salarioT = bonus + salarioF;

    Console.WriteLine($"TOTAL = R$ {salarioT:0.00}");
  }
}