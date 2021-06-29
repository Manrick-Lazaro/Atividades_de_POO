using System;

class MainClass{
  public static void Main(string[] args){    
    EntradaCinema x = new EntradaCinema();

    x.SetDia(Console.ReadLine());
    x.SetHora(int.Parse(Console.ReadLine()));

    Console.WriteLine("\nInteiro\n{0}", x.Inteiro());
    Console.WriteLine("\nMeia-Entrada\n{0}", x.MeiaEntrada());
  }
}

class EntradaCinema{
  private string dia;
  private int hora;
  private double valor = 0;

  public void SetDia(string d){
    for(int i = 0; i < d.Length; i++){
      if(d[i] >= 'a' && d[i] <= 'z'){
        dia = d;
      }
      else{
        dia = "";
        break;
      }
    }
  }
  public void SetHora(int h){
    if(i > 0){
      hora = h
    }
  }

  public string GetDia(){
    return dia;
  }
  public int GetHora(){
    return hora;
  }

  public double Inteiro(){
    if(dia == "segunda" || dia == "terca" || dia == "quinta"){
      valor = 16.00;
    }
    else{
      if(dia == "quarta"){
        valor = 8.00;
      }
      else{
        if(dia == "sexta" || dia == "sabado" || dia == "domingo"){
          valor = 20.00;
        }
      }
    }

    if(hora >= 17 && hora <= 24.00){
      double aumento = valor * 0.5;
      valor += aumento;
    }

    return valor;
  }

  public double MeiaEntrada(){
    if(dia == "segunda" || dia == "terça" || dia == "quinta"){
      valor = 8.00;
    }
    else{
      if(dia == "sexta" || dia == "sabado" || dia == "domingo"){
        valor = 10.00;
      }
    }

    if(hora >= 17 && hora <= 24.00){
      valor = valor * 0.5;
    }

    return valor;
  }
}

/*

    EntradaCinema
    
-dia : string 
-hora : int

+SetDia(d : string) : void
+SetHora(h : int) : void
+GetDia() : string
+GetHora() : int
+Inteiro() : double
+MeiaEntrada() : double

*/