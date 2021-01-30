using System;

class program
{
    static void Main()
    {
        int x=1, y;
        int n = int.Parse(Console.ReadLine());
        
        while(x <= n)
        {
            if(x%2 == 0)
            {
                y = x * x;
                Console.WriteLine("{0}^2 = {1}", x, y);
            }
            x++;
        } 
    }
}