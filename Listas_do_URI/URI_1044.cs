using System;

class program
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        int a = int.Parse(nums[0]);
        int b = int.Parse(nums[1]);

        if(a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}