using System;

class program
{
    static void Main()
    {
        string[] valoreString = Console.ReadLine().Split(' ');
        double[] valores = new double[valoreString.Length];

        valores[0] = double.Parse(valoreString[0]);//C
        valores[1] = double.Parse(valoreString[1]);//B
        valores[2] = double.Parse(valoreString[2]);//A

        Array.Sort(valores);

        if(valores[2] >= valores[1] + valores[0])
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if((valores[2]*valores[2] == (valores[1]*valores[1])+(valores[0]*valores[0])))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if((valores[2]*valores[2] > (valores[1]*valores[1])+(valores[0]*valores[0])))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if((valores[2]*valores[2] < (valores[1]*valores[1])+(valores[0]*valores[0])))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if(valores[2] == valores[1] && valores[1] == valores[0])
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if(valores[0]==valores[1]&&valores[0]!=valores[2] || valores[0]==valores[2]&&valores[0]!=valores[1] || valores[1]==valores[2]&&valores[1]!=valores[0])
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}