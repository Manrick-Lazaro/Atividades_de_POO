using System;

class MainClass{
  public static void Main(){
    Console.WriteLine("Digite seu nome completo:");
    string[] nome = Console.ReadLine().Split(' ');
    Console.WriteLine($"Bem-vindo ao C#, {nome[0]}");
  }
}