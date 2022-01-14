using System;

namespace QuadradoPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 5 && n < 2000) // Condicional dada pelo exercicio
            {
                for(int valr = 1; valr<= n; valr++)
                {
                    if (valr % 2 == 0) // Verifica se é par
                    {
                        Console.WriteLine(valr+"^2 = "+ valr*valr);
                    }                  
                }
            }
            
        }
    }
}
