using System;

class Media{
  private string nome;
  private int n1, n2, n3, n4, notaFinal;

  public void SetNome(string n){
    for(int i = 0; i < n.Length; i++){
      if(n[i] >= 'a' && n[i] <= 'z' || n[i] >= 'A' && n[i] <= 'Z')
        nome = n;
      else  
        nome = "";
    }
  }
  public void SetNota1(int n){
    if(n >= 0 && n <= 100){
      n1 = n;
    }
  }
  public void SetNota2(int n){
    if(n >= 0 && n <= 100){
      n2 = n;
    }
  }
  public void SetNota3(int n){
    if(n >= 0 && n <= 100){
      n3 = n;
    }
  }
  public void SetNota4(int n){
    if(n >= 0 && n <= 100){
      n4 = n;
    }
  }
  public void SetNotaFinal(int n){
    if(n >= 0 && n <= 100){
      notaFinal = n;
    }
  }

  public string GetNome(){
    return nome;
  }
  public int GetNota1(){
    return n1;
  }
  public int GetNota2(){
    return n2;
  }
  public int GetNota3(){
    return n3;
  }
  public int GetNota4(){
    return n4;
  }
  public int GetNotaFinal(){
    return notaFinal;
  }

  public double MediaParcial(){
    int somados = (n1 * 2) + (n2 * 2) + (n3 * 3) + (n4 * 3);
    double media = somados / 10;
    return media;
  }
  public double MediaFinal(){
    int somados = (n1 * 2) + (n2 * 2) + (n3 * 3) + (n4 * 3);
    double media = somados / 10;
    double mediaF = (media + notaFinal) / 2;
    return mediaF;
  }
}

class MainClass{
  public static void Main(string[] args){
    Media x = new Media();

    x.SetNome(Console.ReadLine());
    x.SetNota1(int.Parse(Console.ReadLine()));
    x.SetNota2(int.Parse(Console.ReadLine()));
    x.SetNota3(int.Parse(Console.ReadLine()));
    x.SetNota4(int.Parse(Console.ReadLine()));

    if(x.MediaParcial() >= 60){
      Console.WriteLine("Aprovado");
    }
    else{
      Console.WriteLine("Recuperação");

      x.SetNotaFinal(int.Parse(Console.ReadLine()));
    
      if(x.MediaFinal() >= 60){
        Console.WriteLine("Aprovado");
      }
      else 
        Console.WriteLine("Reprovado");
    }
  }
}