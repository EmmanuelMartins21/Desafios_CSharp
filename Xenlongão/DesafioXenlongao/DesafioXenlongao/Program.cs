using System;

namespace DesafioXenlongao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i< N; i++)
                {
                    var qntEsferas= Convert.ToInt32(int.Parse(Console.ReadLine()));
                    Console.WriteLine(Convert.ToInt32(qntEsferas - Math.Sqrt(qntEsferas)+1));
                }           
        }
    }
}
