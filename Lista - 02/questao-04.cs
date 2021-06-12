using System;

class MainClass{
  public static void Main(){
    int b, h;
    double area, perimetro, diagonal;

    Console.WriteLine("Digite a base e a altura do retângulo");
    b = int.Parse(Console.ReadLine());
    h = int.Parse(Console.ReadLine());

    area = b * h;
    perimetro = b + b + h + h;
    diagonal = Math.Sqrt((b*b) + (h*h));

    Console.WriteLine($"Área = {area:0.00} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:0.00}");
  }
}