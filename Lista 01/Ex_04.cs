using System;
class Ex04{
  static void Main(string[] args){
    int nota1 = int.Parse(Console.ReadLine());
    int nota2 = int.Parse(Console.ReadLine());

    int nota3 = ((nota1 * 2) + (nota2 * 3)) / 5;
    Console.WriteLine($"Média parcial = {nota3}");
  }
}