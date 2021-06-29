using System;

class Viagem{
  private double distanica, tempo;

  public void SetDistancia(double d){
    if(d >= 0) 
      distanica = d;
  }
  public void SetTempo(double t){
    if(t >= 0){
      tempo = t;
    }
  }

  public double GetDistancia(){
    return distanica;
  }
  public double GetTempo(){
    return tempo;
  }

  public double Velocidade(){
    double v = distanica / tempo;
    return v;
  }
}

class MainClass{
  public static void Main(){
    Viagem x = new Viagem();
    
    x.SetDistancia(240.0);
    x.SetTempo(3.5);
   
    Console.WriteLine("{0:0.00}", x.Velocidade());
  }
}