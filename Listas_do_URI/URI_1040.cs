using System;

class program
{
    static void Main()
    {
        double n1,n2,n3,n4,n5,media,mediaFinal;
        string[] valores = Console.ReadLine().Split(' ');

        n1 = double.Parse(valores[0]);
        n2 = double.Parse(valores[1]);
        n3 = double.Parse(valores[2]);
        n4 = double.Parse(valores[3]);

        media = Math.Round((2 * n1 + 3 * n2 + 4 * n3 + 1 * n4)/(2 + 3 + 4 + 1),1);

        if(media >= 7.0)
        {
            Console.WriteLine("Media: {0:0.0}",media);
            Console.WriteLine("Aluno aprovado.");
        }
        
        if(media < 5.0)
        {
            Console.WriteLine("Media: {0:0.0}",media);
            Console.WriteLine("Aluno reprovado.");
        }
         
        if(media >= 5.0 && media < 6.9)
        {
            Console.WriteLine("Media: {0:0.0}",media);
            Console.WriteLine("Aluno em exame.");
            
            n5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0:0.0}", n5);
            
            mediaFinal = (n5 + media) / 2;

            if(mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: {0:0.0}",mediaFinal);
            } 
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: {0:0.0}",mediaFinal);
            }
        }       
        
        
    }
}