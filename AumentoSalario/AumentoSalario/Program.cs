﻿using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        double salario = 0.00;
        double reajuste = 0.00;
        double novoSalario = 0.00;
        double percentual = 0.00;

        salario = Convert.ToDouble(Console.ReadLine());
        //Verifica se o valor inserido está correto
        if (!string.IsNullOrEmpty(salario.ToString()))
        {
            //TODO: Complete os espaços em branco com uma possível solução para o problema:

            if (salario <= 400.00)
            {
                percentual = 0.15;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;

            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                percentual = 0.12;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                percentual = 0.10;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;

            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 0.07;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario > 2000.00)
            {
                percentual = 0.04;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;

            }
            else
            {
                Console.WriteLine("Salario incompativel");
            }

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual * 100);

        }
        else
        {
            Console.WriteLine("Salario invalido. Digite novamente");
            salario = Convert.ToDouble(Console.ReadLine());
        }
        
    }
}