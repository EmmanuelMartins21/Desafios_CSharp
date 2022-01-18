using System;

public class DIO
{

    public static void Main(string[] args)
    {

        double pi, raio, volume;
        pi = 3.14159;

        raio = double.Parse(Console.ReadLine()); // Leitura do raio

        volume = ((4 / 3.0) * pi * Math.Pow(raio, 3));

        Console.WriteLine("VOLUME = {0:F3}", volume);
    }
}