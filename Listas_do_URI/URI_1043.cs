using System;

class program
{
    static void Main()
    {
        string[] valor = Console.ReadLine().Split(' ');

        double n1 = double.Parse(valor[0]);
        double n2 = double.Parse(valor[1]);
        double n3 = double.Parse(valor[2]);

        if(Math.Abs(n2-n3) < n1 && n1 < n2+n3 || Math.Abs(n1-n2) < n3 && n3 < n1+n2 || Math.Abs(n1-n3) < n2 && n2 < n1+n3)
        {   
            double a = Perimetro(n1, n2, n3);
            Console.WriteLine("Perimetro = {0:0.0}", a);
        }
        else
        {
            double b = AreaTrapezio(n1, n2, n3);
            Console.WriteLine("Area = {0:0.0}", b);
        }
    }

    public static double Perimetro(double a, double b, double c)
    {
        double resultado = (a + b + c);
        
        return resultado;
    }
    public static double AreaTrapezio(double a, double b, double c) 
    {        
        double resultado = ((a + b)*c)/2;
        
        return resultado;
    }
}