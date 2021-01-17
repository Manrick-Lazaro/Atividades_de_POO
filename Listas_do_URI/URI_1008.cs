using System;

class Program
{
  static void Main(string[] args)
  {
    int numeroFuncionario = int.Parse(Console.ReadLine());
    int horasTrabalhadas = int.Parse(Console.ReadLine());
    double valorHoras = double.Parse(Console.ReadLine());

    double salario = horasTrabalhadas * valorHoras;

    Console.WriteLine($"NUMBER = {numeroFuncionario}");
    Console.WriteLine($"SALARY = U$ {salario:0.00}");
  }
}