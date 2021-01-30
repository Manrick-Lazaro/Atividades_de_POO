using System;

class program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int testes=1, dentro=0, fora=0;

        while(testes <= n)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            if(x >= 10 && x <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }

            testes++;
        }

        Console.WriteLine("{0} in", dentro);
        Console.WriteLine("{0} out", fora);
    }
}