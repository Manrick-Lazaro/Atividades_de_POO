using System;

class program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        
        if(n >= 0 && n <=25.00)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        if(n > 25.00 && n <= 50.00)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        if(n > 50.00 && n <= 75.00)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        if(n > 75.00 && n <= 100.00)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        if(n < 0 || n > 100.00)
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}
