using System;

class MainClass{
  static void Main(){
    Console.Write("Dia ");
    int diaI = int.Parse(Console.ReadLine());
    string[] horaI = Console.ReadLine().Split(':');
    int h = int.Parse(horaI[0]);
    int m = int.Parse(horaI[1]);
    int s = int.Parse(horaI[2]);

    Console.Write("Dia ");
    int diaT = int.Parse(Console.ReadLine());
    string[] horaT = Console.ReadLine().Split(':');
    int h2 = int.Parse(horaT[0]);
    int m2 = int.Parse(horaT[1]);
    int s2 = int.Parse(horaT[2]);

    int w = 0;
    int x = 1;
    int y = 0;
    int z = 0;

    for(int i = diaI; i != diaT - 1; i++){
      w += 1;
    }

    for(int i = h; i != h2; i++){
      if (i == 24){
        i = 1;
      }
      x += 1;
    }

    for(int i = m; i != m2; i++){
      if(i == 60){
        i = 1;
      }
      y++;
    }

    for(int i = s; i != s2; i++){
      if(i == 60){
        i = 1;
      }
      z++;
    }

    Console.WriteLine($"{w} dia(s)");
    Console.WriteLine($"{x} hora(s)");
    Console.WriteLine($"{y} minuto(s)");
    Console.WriteLine($"{z} segundo(s)");
  }
}