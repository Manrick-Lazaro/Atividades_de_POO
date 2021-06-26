using System;

class MainClass{
  public static void Ordenar(ref int x, ref int y, ref int z){
    if(x > y){
      int aux = x;
      x = y;
      y = aux;
      if(y > z){
        int aux = y;
        y = z;
        z = aux;
      }
      else{
        if(y > z){
          int aux = y;
          y = z;
          z = aux;
        }
      }
    } 
  }

  public static void Main(){
    Console.WriteLine("Digite o primeiro valor:");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o terceiro valor:");
    int n3 = int.Parse(Console.ReadLine());

    Ordenar(ref n1, ref n2, ref n3);

    Console.WriteLine("{0}\n{1}\n{2}", n1, n2, n3);
  }
}