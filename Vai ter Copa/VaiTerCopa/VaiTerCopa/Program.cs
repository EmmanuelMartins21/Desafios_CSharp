using System;

namespace VaiTerCopa
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            while ((str = Console.ReadLine()) != null)
            {
                
                int x = int.Parse(str);
                if(x < 0 || x>100)
                {
                    Console.WriteLine("Valor invalido");
                }
                else if (x>0)
                {
                    Console.WriteLine("vai ter duas!");
                }
                else          
                {
                    Console.WriteLine("vai ter copa!");
                }
            }

        }
    }
}
