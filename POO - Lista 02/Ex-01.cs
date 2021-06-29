using System;

class Circulo{
  private int raio;

  public void SetRaio(int r){
    if(r > 0) raio = r;
  }

  public int GetRaio(){
    return raio;
  }

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
    x.SetRaio(int.Parse(Console.ReadLine()));

    Console.WriteLine(x.Area());
    Console.WriteLine(x.Circuferencia());
  }
}