using System;

class MainClass{
  public static void Main(){
    int n1, n2, media;
    
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    n2 = int.Parse(Console.ReadLine());

    media = ((n1 * 2) + (n2 * 3)) / 5;

    Console.WriteLine($"Média parcial = {media}");
  }
}