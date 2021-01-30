using System;

class program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int n1 = int.Parse(valores[0]);
        int n2 = int.Parse(valores[1]);
        int n3 = int.Parse(valores[2]);

        if(n1>n2 && n2>n3)
        {
            Console.WriteLine("{0}",n3);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}\n",n1);

            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
        }
        if(n1 > n3 && n3 > n2)
        {
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
            Console.WriteLine("{0}\n",n1);

            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
            
        }
        if(n2 > n3 && n3 > n1)
        {
            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n3);
            Console.WriteLine("{0}\n",n2);

            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
        }
        if(n2 > n1 && n1 > n3)
        {
            Console.WriteLine("{0}",n3);
            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}\n",n2);

            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
        }
        if(n3>n1 & n1>n2)
        {
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}\n",n3);

            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
        }
        if(n3 > n2 && n2 > n1)
        {
            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}\n",n3);

            Console.WriteLine("{0}",n1);
            Console.WriteLine("{0}",n2);
            Console.WriteLine("{0}",n3);
        }

    }
}