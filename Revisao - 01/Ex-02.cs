using System;

class MainClass{
  public static string criarSenha(string[] frase){
    string senha = "";

    for(int i = 0; i < frase.Length; i++){
      string palavra = frase[i];
      int quantidade = palavra.Length;
      senha += quantidade;
    }
    return senha;
  }

  public static void Main(){
    Console.WriteLine("Digite uma frase:");
    string[] frase = Console.ReadLine().Split(' ');
    
    string senha = criarSenha(frase);
    Console.WriteLine($"A senha é {senha}");
  }
}