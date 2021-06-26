using System;

class MainClass{
  public static double Maior(double x, double y){
    if(x > y)
      return x;
    else
      return y;
  }

  public static void Main(){
    Console.WriteLine("Digite o primeiro valor");
    double n1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    double n2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Maior {0}", Maior(n1, n2));
  }
}