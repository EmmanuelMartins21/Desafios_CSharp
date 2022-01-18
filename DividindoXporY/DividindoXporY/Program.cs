using System;

class Desafio
{
    static void Main()
    {
        int limit = int.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            int X = Int32.Parse(line[0]);
            int Y = Int32.Parse(line[1]);
            if (Y != 0)
            {
                double divisao = ((double)X / Y); // Digite aqui o calculo da divisao

                Console.WriteLine("{0:F1}", divisao);
            }
            else
            {
                Console.WriteLine("divisao impossivel");
            }

        }

    }
}