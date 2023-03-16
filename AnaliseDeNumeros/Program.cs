using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();

            lista.Add(valor1);
            lista.Add(valor2);
            lista.Add(valor3);
            lista.Add(valor4);
            lista.Add(valor5);

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;
            int quantidadeNulos = 0;

            //TODO: Crie as condições necessárias para calcular cada uma das quantidades.
            //Observação: Caso queira usar um array uma lista para seus valores, fique à vontade...
            foreach (var i in lista)
            {
                if (i % 2 == 0)
                {
                    quantidadePares++;
                }
                else
                {
                    quantidadeImpares++;
                }

                if (i > 0)
                {
                    quantidadePositivos++;
                }
                else if(i < 0)
                {
                    quantidadeNegativos++;
                }
                else
                {
                    quantidadeNulos++;
                }
            }

            Console.WriteLine("{0} par(es)", quantidadePares);
            //TODO: Imprima as outras linhas conforme o enunciado deste desafio.
            Console.WriteLine("{0} impar(es)", quantidadeImpares);
            Console.WriteLine("{0} positivo(s)", quantidadePositivos);
            Console.WriteLine("{0} negativo(s)", quantidadeNegativos);
        }
    }
}