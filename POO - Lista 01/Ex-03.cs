using System;

class Viagem{
  public int distanica, horas, minutos;

  public double Velocidade(){
    double tempo = (minutos / 60) + horas;
    double v = distanica / tempo;
    return v;
  }
}

class MainClass{
  public static void Main(){
    Viagem x = new Viagem();
    
    x.distanica = 240;
    x.horas = 2;
    x.minutos = 30;

    Console.WriteLine(x.Velocidade());
  }
}