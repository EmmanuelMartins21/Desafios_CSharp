using System;

namespace DIO
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int i = 1;
            //Exibir "Ho" do papai noel       
            while (i < N)
            {
                Console.Write("Ho ");
                i++;
            }
            Console.WriteLine("Ho!");
        }
    }
}