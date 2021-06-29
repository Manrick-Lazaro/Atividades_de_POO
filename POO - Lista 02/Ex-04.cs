using System;

class ContaBancaria{
  private string titular;
  private int numero;
  private double saldo;

  public void SetTitular(string t){
    for(int i = 0; i < t.Length; i++){
      if(t[i] >= 'a' && t[i] <= 'z' || t[i] >= 'A' || t[i] <= 'Z'){
        titular = t;
      }
      else{
        titular = "";
        break;
      }
    }
  }
  public void SetNumero(int n){
    if(n > 0){
      numero = n;
    }
  }
  public void SetSaldo(double s){
    if(s >= 0){
      saldo = s;
    }
  }

  public string GetTitular(){
    return titular;
  }
  public int GetNumero(){
    return numero;
  }
  public double GetSaldo(){
    return saldo;
  }

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

    x.SetTitular(Console.ReadLine());
    x.SetNumero(int.Parse(Console.ReadLine()));
    x.SetSaldo(double.Parse(Console.ReadLine()));

    x.Deposito(20);
    Console.WriteLine(x.saldo);

    x.Saque(30);
    Console.WriteLine(x.saldo);
  }
}

/*

  ContaBancaria

-titular : string 
-numero : int
-saldo : double

+SetTitular(t : string) : void 
+SetNumero(n : int) : void
+SetSaldo(s : double) : void
+GetTitular() : string
+GetNumero() : int
+GetSaldo() : double
+Deposito(valor : int) : void
+Saque(valor : int) : void

*/
