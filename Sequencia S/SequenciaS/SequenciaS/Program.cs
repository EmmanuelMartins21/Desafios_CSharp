using System;
using System.Globalization;

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, c, S = 0;
            for (a = 1; a <= 100; a++)
            {
                c = 1 / a;  
                S += c;
            }
            var x = Math.Round(S, 2);
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
