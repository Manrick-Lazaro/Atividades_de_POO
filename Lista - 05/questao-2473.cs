using System;

class MainClass{
  static void Main(){
    int pontos = 0;
    string = "";
    string[] aposta = Console.ReadLine().Splpit(' ');
    string[] sorteado = Console.ReadLine().Splpit(' ');

    if(aposta[0] == sorteado[0] || aposta[0] == sorteado[1] || aposta[0] == sorteado[2] || aposta[0] == sorteado[3] || aposta[0] == sorteado[4] || aposta[0] == sorteado[5] ||){
      pontos++;
    }
    if(aposta[1] == sorteado[0] || aposta[1] == sorteado[1] || aposta[1] == sorteado[2] || aposta[1] == sorteado[3] || aposta[1] == sorteado[4] || aposta[1] == sorteado[5] ||){
      pontos++;
    }
    if(aposta[2] == sorteado[2] || aposta[2] == sorteado[1] || aposta[2] == sorteado[2] || aposta[2] == sorteado[3] || aposta[2] == sorteado[4] || aposta[2] == sorteado[5] ||){
      ponto++;
    }
    if(aposta[3] == sorteado[0] || aposta[3] == sorteado[1] || aposta[3] == sorteado[2] || aposta[3] == sorteado[3] || aposta[3] == sorteado[4] || aposta[3] == sorteado[5] ||){
      ponto++;
    }
    if(aposta[4] == sorteado[0] || aposta[4] == sorteado[1] || aposta[4] == sorteado[2] || aposta[4] == sorteado[3] || aposta[4] == sorteado[4] || aposta[4] == sorteado[5] ||){
      ponto++;
    }
    if(aposta[5] == sorteado[0] || aposta[5] == sorteado[1] || aposta[5] == sorteado[2] || aposta[5] == sorteado[3] || aposta[5] == sorteado[4] || aposta[5] == sorteado[5] ||){
      ponto++;
    }

    if(ponto == 3){
      premio = "terno";
    }
    else{
      if(ponto == 4){
        premio = "quadra";
      }
      else{
        if(ponto == 5){
          premio = "quina";
        }
        else{
          if(ponto == 6){
            premio = "sena";
          }s
        }
      }
    }
  }
}