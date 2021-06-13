using System;

class MainClass{
  public static void Main(){
    string[] valor1 = Console.ReadLine().Split(' ');
    double X1 = double.Parse(valor1[0]);
    double Y1 = double.Parse(valor1[1]);

    string[] valor2 = Console.ReadLine().Split(' ');
    double X2 = double.Parse(valor2[0]);
    double Y2 = double.Parse(valor2[1]);

    double distancia = Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)));
    Console.WriteLine($"{distancia:0.0000}");
  }
}