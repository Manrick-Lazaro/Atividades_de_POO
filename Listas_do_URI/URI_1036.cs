using System;

class Bhaskara
{
    public static void Main(string[] args)
    {
        //DELTA
        string[] valor = Console.ReadLine().Split(' ');
        double a = double.Parse(valor[0]);
        double b = double.Parse(valor[1]);
        double c = double.Parse(valor[2]);

        double delta = b * b - (4 * a * c);

        if (delta < 0 || 2 * a == 0) 
            Console.WriteLine("Impossivel calcular");
        else
        {
            //RAIZES
            double r1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"R1 = {r2:0.00000}");
            Console.WriteLine($"R2 = {r1:0.00000}");
        }
            
    }
}