using System;

class Program
{
  public static void Main(string[] args)
  {
    string[] valor = Console.ReadLine().Split(' ');
    int a = int.Parse(valor[0]);
    int b = int.Parse(valor[1]);
    int c = int.Parse(valor[2]);
    int d = int.Parse(valor[3]);

    if(b>c && d>a && c+d>a+b && c>0 && d>0 && a%2==0)
      Console.WriteLine("Valores aceitos");
    else
      Console.WriteLine("Valores nao aceitos");
  }
}