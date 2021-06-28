using System;

class ContaBancaria{
  public string titular;
  public int numero;
  public double saldo;

  public void Deposito(int valor){
    saldo += valor;
  }
  public void Saque(int valor){
    saldo = saldo - valor;
  }
}

class MainClass{
  public static void Main(string[] args){
    ContaBancaria x = new ContaBancaria();

    x.titular = Console.ReadLine();
    x.numero = int.Parse(Console.ReadLine());
    x.saldo = double.Parse(Console.ReadLine());

    x.Deposito(20);
    Console.WriteLine(x.saldo);

    x.Saque(30);
    Console.WriteLine(x.saldo);
  }
}