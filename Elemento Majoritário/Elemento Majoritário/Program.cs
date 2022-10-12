using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("Digite o número: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
    }
    public static int MajorityElement(int[] nums)
    {
        int maior = nums[0];
        int count = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != maior)
            {
                maior = nums[i];
                count++;
            }
            else
            {
                if (maior == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return maior;
    }
}