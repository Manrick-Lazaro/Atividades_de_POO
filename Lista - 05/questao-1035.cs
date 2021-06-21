using System;

class MainClass{
  public static void Main(){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    if(b > c && d > a && c+d > a+b && c > 0 && d > 0 && a%2 == 0){
      Cosnole.WriteLine("Valores aceitos");
    }
    else{
      Console.WriteLine("Valores nao aceitos");
    }
  }
}