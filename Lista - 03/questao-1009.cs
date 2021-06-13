using System;

class MainClass{
  public static void Main(){
    string nome = Console.ReadLine();
    double salarioFixo = double.Parse(Console.ReadLine());
    double valorVendas = double.Parse(Console.ReadLine());
    double aumento = valorVendas * 0.15;
    double novoSalario = salarioFixo + aumento;
    Console.WriteLine($"TOTAL = R$ {novoSalario:0.00}");
  }
}