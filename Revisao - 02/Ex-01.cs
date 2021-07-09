using System;

class Pais{
  private string nome;
  private double area, populacao;

  public Pais (string nome, double area, double populacao) {
    for (int i = 0; i < nome.Length; i++) {
      if (nome[i] >= 'a' && nome[i] <= 'z' || nome[i] >= 'A' && nome[i] <= 'Z') {
        this.nome = nome;
      }
      else
        nome = "";
        break;
    }

    if (area > 0) {
      this.area = area;
    }

    if (populacao > 0) {
      this.populacao = populacao;
    }
  }

  public void SetNome (string nome) {
    for (int i = 0; i < nome.Length; i++) {
      if (nome[i] >= 'a' && nome[i] <= 'z' || nome[i] >= 'A' && nome[i] <= 'Z') {
        this.nome = nome;
      }
      else
        nome = "";
        break;
    }
  }
  public void SetArea (double area) {
    if (area > 0) {
      this.area = area;
    }
  }
  public void SetPopulacao (double populacao) {
    if (populacao > 0) {
      this.populacao = populacao;
    }
  }

  public string GetNome () { 
    return nome;
  }
  public double GetArea () {
    return area;
  }
  public double GetPopulacao () {
    return populacao;
  }

  public double Densidade () {
    return populacao / area;
  }

  public override string ToString () {
    return $"Nome do país: {nome}\nArea: {area}\nPopulação: {populacao}";
  }
}

class MainClass {
  public static void Main (string[] args) {
    Pais x = new Pais ("Brasil", 8516000, 211755692);
    
    Console.WriteLine("\nAlterar dados? [s] para sim | [n] para nao\n");
    
    if (Console.ReadLine() == "s") {   
      Console.Write ("NOME: ");
      x.SetNome (Console.ReadLine());

      Console.Write ("AREA: ");
      x.SetArea (double.Parse(Console.ReadLine()));

      Console.Write ("POPULAÇÂO: ");
      x.SetPopulacao (double.Parse(Console.ReadLine()));
    }

    Console.WriteLine ("\nDensidade demográfica do país {0}: {1:0.0}", x.GetNome(), x.Densidade());

    Console.WriteLine ("\nDADOS DO OBJETO:\n{0}", x.ToString());
  }
}