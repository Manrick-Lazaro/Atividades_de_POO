using System;

class MainClass{
  public static int soma(int inicio, int fim){
    int valorTotal = 0;
    for(int i = inicio; i <= fim; i++){
      valorTotal += i;
    }
    return valorTotal;
  }

  public static void Main(){
    Console.WriteLine("Digite o valor de inicio:");
    int inicio = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor final:");
    int fim = int.Parse(Console.ReadLine());

    int resultado = soma(inicio, fim);
    Console.WriteLine($"soma total {resultado}");
  }
}