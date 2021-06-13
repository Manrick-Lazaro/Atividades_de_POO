using System;

class MainClass{
  public static void Main(){
    int valor = int.Parse(Console.ReadLine());

    int nota = valor / 100;
    int resto = valor % 100;
    Console.WriteLine($"{nota} nota(s) de R$ 100,00");

    nota = resto / 50;
    resto = resto % 50;
    Console.WriteLine($"{nota} nota(s) de R$ 50,00");

    nota = resto / 20;
    resto = resto % 20;
    Console.WriteLine($"{nota} nota(s) de R$ 20,00");

    nota = resto / 10;
    resto = resto % 10;
    Console.WriteLine($"{nota} nota(s) de R$ 10,00");

    nota = resto / 5;
    resto = resto % 5;
    Console.WriteLine($"{nota} nota(s) de R$ 5,00");
    
    nota = resto / 2;
    resto = resto % 2;
    Console.WriteLine($"{nota} nota(s) de R$ 2,00");

    nota = resto;
    Console.WriteLine($"{nota} nota(s) de R$ 1,00");

  }
}