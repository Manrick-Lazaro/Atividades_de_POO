using System;

class program
{
    static void Main()
    {
        string[] aposta = Console.ReadLine().Split(' ');
        string[] sorteio = Console.ReadLine().Split(' ');

        string Premio = sorte(aposta, sorteio);
        Console.WriteLine("{0}", Premio);
    }
   
    static string sorte(string[] a, string[] b)
    {
        string premio = "";
        int quantidade = 0;
        
        for(int i = 0; i < 6; i++)
        {
            for(int x = 0; x < 6; x++)
            {
                if(a[i] == b[x])
                {
                    quantidade++;
                }
            }
        }

        switch(quantidade)
        {
            case 3:
                premio = "terno";
                break;
            case 4:
                premio = "quadra";
                break;
            case 5:
                premio = "quina";
                break;
            case 6:
                premio = "sena";
                break;
            default:
                premio = "azar";
                break;
        }
        
        return premio;
    }
}
