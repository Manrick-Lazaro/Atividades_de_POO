using System;

class Media{
  public string nome;
  public int n1, n2, n3, n4, notaFinal;

  public double MediaParcial(){
    int somados = (n1 * 2) + (n2 * 2) + (n3 * 3) + (n3 * 3);
    double media = somados / 10;
    return media;
  }
  public double MediaFinal(){
    int somados = (n1 * 2) + (n2 * 2) + (n3 * 3) + (n3 * 3);
    double media = somados / 10;
    double mediaF = (media + notaFinal) / 2;
    return mediaF;
  }
}

class MainClass{
  public static void Main(string[] args){
    Media x = new Media();

    x.nome = Console.ReadLine();
    x.n1 = int.Parse(Console.ReadLine());
    x.n2 = int.Parse(Console.ReadLine());
    x.n3 = int.Parse(Console.ReadLine());
    x.n4 = int.Parse(Console.ReadLine());

    if(x.MediaParcial() >= 60){
      Console.WriteLine("Aprovado");
    }
    else{
      Console.WriteLine("Recuperação");
     
      x.notaFinal = int.Parse(Console.ReadLine());
    
      if(x.MediaFinal() >= 60){
        Console.WriteLine("Aprovado");
      }
      else 
        Console.WriteLine("Reprovado");
    }
  }
}