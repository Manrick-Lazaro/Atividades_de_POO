using System;

class program
{
    static void Main()
    {
        string[] num = Console.ReadLine().Split(' ');
        int n1 = int.Parse(num[0]);
        int n2 = int.Parse(num[1]);
        int n3 = int.Parse(num[2]);
        int n4 = int.Parse(num[3]);
        int n5 = int.Parse(num[4]);
    
        if(n1 > n2)
        {
            if(n2 > n3)
            {
                if(n3 > n4)
                {
                    if(n4 > n5)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("N");
                    }
                }
                else
                {
                    Console.WriteLine("N");
                }
            }
            else
            {
                Console.WriteLine("N");
            }
        }
        else
        {
            if(n5 > n4)
            {
                if(n4 > n3)
                {
                    if(n3 > n2)
                    {
                        if(n2 > n1)
                        {
                            Console.WriteLine("C");
                        }
                        else
                        {
                            Console.WriteLine("N");
                        }
                    }
                    else
                    {
                        Console.WriteLine("N");
                    }
                }
                else
                {
                    Console.WriteLine("N");
                }
            }
            else
            {
                Console.WriteLine("N");
            }
        }

    }
}