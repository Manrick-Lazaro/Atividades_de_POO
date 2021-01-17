using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a base e a altura do triângulo");
    double B = double.Parse(Console.ReadLine());
    double H = double.Parse(Console.ReadLine());

    double b = Math.Pow(B,2);
    double h = Math.Pow(H,2);

    double area = B * H;
    double perimetro = (B * 2) + (H * 2);
    double diagonal = Math.Sqrt(b + h);

    Console.WriteLine($"Área = {area:0.00} - Perímetro {perimetro:0.00} - Diagonal {diagonal:0.00}");
  }
}