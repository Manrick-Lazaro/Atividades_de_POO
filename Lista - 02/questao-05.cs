using System;

class MainClass{
  public static void Main(){
    long h, m, s;
    
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    string[] valorTempo = Console.ReadLine().Split(':');
    h = long.Parse(valorTempo[0]);
    m = long.Parse(valorTempo[1]);
    s = long.Parse(valorTempo[2]);

    m += 60*h;
    s += 60*m;

    long distancia = s * 300000;

    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}