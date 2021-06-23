using System;

class MainClass{
  static void Main(){
    string[] valores = Console.ReadLine().Split(' ');
    int n1 = int.Parse(valores[0]);
    int n2 = int.Parse(valores[1]);
    int n3 = int.Parse(valores[2]);
    int n4 = int.Parse(valores[3]);
    int n5 = int.Parse(valores[4]);

    if(n1 >= n2 && n2 >= n3 && n3 >= n4 && n4 >= n5){
      Console.WriteLine("D");
    }
    else{
      if(n1 <= n2 && n2 <= n3 && n3 <= n4 && n4 <= n5){
        Console.WriteLine("C");
      }
      else{
        Console.WriteLine("N");
      }
    }
  }
}