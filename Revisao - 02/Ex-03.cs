using System;

class MainClass {
  public static void Main () {
    Pessoa a = new Pessoa ("a", "18-12-2000");
    Pessoa b = new Pessoa ("b", 30);
    Pessoa c = new Pessoa ("c", 40);
    a.SetFiliacao(a, c);
   
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }
}

class Pessoa {
  private string nome;
  private int idade;
  private DateTime nasc;
  private Pessoa pai;
  private Pessoa mae;

  public Pessoa (string nome, DateTime nasc) {
    this.nome = nome;
    this.nasc = DateTime.Parse(nasc);
  }
  public Pessoa (string nome, int idade) {
    this.nome = nome;
    this.idade = idade;
  }
  public void SetFiliacao (Pessoa pai, Pessoa mae) {
    this.pai = pai;
    this.mae = mae;
  }
  public DateTime DifPai () {
    DateTime diferenca = nasc - ;
    return 
  }
  public override string ToString () {
    return $"{pai} {mae}";
  }

}