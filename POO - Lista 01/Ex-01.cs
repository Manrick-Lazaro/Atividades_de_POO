using System;

class Circulo{
  public int raio;

  public double Area(){
    return (raio * raio) * 3.14;
  }

  public double Circuferencia(){
    return (2 * 3.14) * raio;
  }
}

class MainClass{
  public static void Main(string[] args){
    Circulo x = new Circulo();
    x.raio = int.Parse(Console.ReadLine());

    Console.WriteLine(x.Area());
    Console.WriteLine(x.Circuferencia());
  }
}