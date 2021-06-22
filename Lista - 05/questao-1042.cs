using System;

class MainClass{
  static void Mian(){
    string[] valores = Console.ReadLine().Split(' ');
    int n1 = int.Parse(valores[0]);
    int n2 = int.Parse(valores[1]);
    int n3 = int.Parse(valores[2]);

    if(n1 >= n2 && n1 >= n3){
      if(n2 > n3){
        Console.WriteLine($"{n3}");
        Console.WriteLine($"{n2}");
        Console.WriteLine($"{n1}");
      } 
      else{
        Console.WriteLine($"{n2}");
        Console.WriteLine($"{n3}");
        Console.WriteLine($"{n1}");
      }   
    }
    else{
      if(n2 >= n1 && n2 >= n3){
        if(n1 > n3){
          Console.WriteLine($"{n3}");
          Console.WriteLine($"{n1}");
          Console.WriteLine($"{n2}");
        }
        else{
          Console.WriteLine($"{n1}");
          Console.WriteLine($"{n3}");
          Console.WriteLine($"{n2}");
        }
      }
      else{
        if(n3 >= n2 && n3 >= n1){
          if(n2 >= n1){
            Console.WriteLine($"{n1}");
            Console.WriteLine($"{n2}");
            Console.WriteLine($"{n3}");
          }
          else{
            Console.WriteLine($"{n2}");
            Console.WriteLine($"{n1}");
            Console.WriteLine($"{n3}");
          }
        }
      }
    }
  }
}