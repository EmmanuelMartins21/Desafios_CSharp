using System;

namespace SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x>0 && x<107)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x + 2);
                }
                else
                {
                    Console.WriteLine(x + 1);
                }
            }
        }
    }
}
