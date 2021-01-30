using System;

class program
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(' ');
        double x = double.Parse(n[0]);
        double y = double.Parse(n[1]);

        if(x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        if(x == 0 && y != 0)
        {
            Console.WriteLine("Eixo Y");
        }
        if(x != 0 && y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        if(x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        if(x < 0 && y > 0)
        {
            Console.WriteLine("Q2");
        }
        if(x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        if(x > 0 && y < 0)
        {
            Console.WriteLine("Q4");
        }
    }
}