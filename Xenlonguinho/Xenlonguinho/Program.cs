using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var esferas = int.Parse(Console.ReadLine());

                Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));

            }
        }
    }
}