using System;

namespace Sequencia_IJ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Montando a matriz
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}

