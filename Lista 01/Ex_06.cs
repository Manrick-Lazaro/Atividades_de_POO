using System;

class Program
{
  static void Main (string[] args)
  {
    double velocidade = 300.000;
    string[] tempo = Console.ReadLine().Split(":");
    
    double horas = double.Parse(tempo[0]);
    double minutos = double.Parse(tempo[1]);
    double segundos = double.Parse(tempo[2]);

    horas *= 3600;
    minutos *= 60;

    double totalTempo = horas + minutos + segundos;
    double distancia = totalTempo * velocidade;

    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}