using System;

class MainClass{
  public static void ordenar(ref string a, ref string b, ref string c, ref string d){
    string aux = "";

    for(int i = 1; i <= 4; i++){  
      if(a[0] > b[0]){
        aux = a;
        a = b;
        b = aux;
        if(b[0] > c[0]){
          aux = b;
          b = c;
          c = aux;
          if(c[0] > d[0]){
            aux = c;
            c = d;
            d = aux;
          }
        }
      }
      else{
        if(b[0] > c[0]){
          aux = b;
          b = c;
          c = aux;
        }
        else{
          if(c[0] > d[0]){
            aux = c;
            c = d;
            d = aux;
          }
        }
      }
    }
  }

  public static void Main(){
    Console.WriteLine("Digite o nome de quatro cidades:");
    string n1 = Console.ReadLine();
    string n2 = Console.ReadLine();
    string n3 = Console.ReadLine();
    string n4 = Console.ReadLine();

    ordenar(ref n1, ref n2, ref n3, ref n4);
    Console.WriteLine($"\n{n1}\n{n2}\n{n3}\n{n4}");
  }
}