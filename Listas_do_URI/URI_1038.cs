using System;

class program
{
    static void Main()
    {
        double[] valor = new double[5];
        valor[0] = 4.00;
        valor[1] = 4.50;
        valor[2] = 5.00;
        valor[3] = 2.00;
        valor[4] = 1.50;

        string[] digitos = Console.ReadLine().Split(' ');
        int codigo = int.Parse(digitos[0])-1;
        int quantidade = int.Parse(digitos[1]);
        

        double obj = valor[codigo];
        double total = quantidade * obj;

        Console.WriteLine("Total: R$ {0:0.00}",total);
    }
}
