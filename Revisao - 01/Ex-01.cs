using System;

class MainClass{
  public static double Densidade(int habitantes, double area){
    double result = habitantes / area;
    return result;
  }

  public static void Main(){
    Console.WriteLine("Digite o nome do estado:");
    string nomeEstado = Console.ReadLine();

    Console.WriteLine("Digite o numero de habitantes:");
    int populacao = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a área do estado em km²:");
    double areaEstado = double.Parse(Console.ReadLine());

    double habitantesArea = Densidade(populacao, areaEstado);

    Console.WriteLine($"A densidade demográfica do {nomeEstado} é de {habitantesArea:0.0} hab./Km²");
  }
}