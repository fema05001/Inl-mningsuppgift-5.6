using System;
namespace uppgift_5_6
{
    class program
    {
        static void Main(string[] args)
        {
            long g = 1;
            Console.WriteLine("Skriv in talen du vill multiplicera separerade med asterisker '*' ");
           string Tal =Console.ReadLine();
            string[] separation = Tal.Split('*');

           
            for (long i = 0; i < separation.Length; i++)
            {
                long[] b =new long[separation.Length];
                b [i] = long.Parse(separation[i]);
                Console.WriteLine(b[i]);
                g = g * b[i];
            }
            Console.Write("Summan av talen blir " + g);

            
            
        }
    }
}

