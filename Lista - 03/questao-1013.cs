using System;

class MainClass{
  public static void Main(){
    string[] valor = Console.ReadLine().Split(' ');
    int a = int.Parse(valor[0]);
    int b = int.Parse(valor[1]);
    int c = int.Parse(valor[2]);

    int maiorAB = ((a+b)+Math.Abs(a-b)) / 2;
    int maiorABC = ((maiorAB+c)+Math.Abs(maiorAB-c)) / 2;

    Console.WriteLine($"{maiorABC} eh o maior");
  }
}