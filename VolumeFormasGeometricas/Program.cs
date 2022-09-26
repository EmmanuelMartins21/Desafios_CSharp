using System;

public class Volumes
{
    public static void Main(string[] args)
    {
        Menu();        
    }

    /// <summary>
    /// Metodo de construção do Menu principal 
    /// </summary>
    public static void Menu()
    {
        string escolhaErrada;
        int saida = 0;
        while (saida != 5)
        {
            Console.WriteLine("Digite 1 para ver o volume da esfera");
            Console.WriteLine("Digite 2 para ver o volume do cilindro");
            Console.WriteLine("Digite 3 para ver o volume do cone");
            Console.WriteLine("Digite 4 para ver o volume do cubo");
            Console.WriteLine("Digite 5 para sair");
            string escolha = Console.ReadLine();

            if (string.IsNullOrEmpty(escolha.ToString()))
            {
                Console.WriteLine(" Opcao errada, deseja escolher novamente? Digite S para sim e N para Nao");
                escolhaErrada = Console.ReadLine();
                if (escolhaErrada == "S" || escolhaErrada == "s") Menu();
            }
            switch (Convert.ToInt32(escolha))
            {
                case 1:
                    VolumeEsfera();
                    break;
                case 2:
                    VolumeCilindro();
                    break;
                case 3:
                    VolumeCone();
                    break;
                case 4:
                    VolumeCubo();                    
                    break;
                case 5:
                    saida = 5;
                    break;                    
                default:
                    break;
            }

        }
    }

    public static void VolumeEsfera()
    {
        double pi, raio, volume;
        pi = 3.14159;
        try
        {
            Console.WriteLine("Digite o raio");
            raio = double.Parse(Console.ReadLine()); // Leitura do raio

            if(raio.ToString() == null) VolumeEsfera(); // Se não digitar  o raio, chamará o metodo novamente

            volume = ((4 / 3.0) * pi * Math.Pow(raio, 3));

            Console.WriteLine("VOLUME = {0:F3}", volume);
        }
        catch(Exception ex)
        {
             string mensagem  = ex.Message;
            throw new Exception(mensagem);
        }
        
    }
    public static void VolumeCilindro()
    {
        double pi, raio, altura,volume;
        pi = 3.14159;
        try
        {
            Console.WriteLine("Digite o raio");
            raio = double.Parse(Console.ReadLine()); // Leitura do raio.

            if (raio.ToString() == null) VolumeCilindro();

            Console.WriteLine("Digite a altura");
            altura = double.Parse(Console.ReadLine());

            if (altura.ToString() == null) VolumeCilindro();
            volume = (pi * Math.Pow(raio, 2)*altura);

            Console.WriteLine("VOLUME = {0:F3}", volume);
        }
        catch (Exception ex)
        {
            string mensagem = ex.Message;
            throw new Exception(mensagem);
        }
    }

    public static void VolumeCone()
    {
        double pi, raio, altura, volume;
        pi = 3.14159;
        try
        {
            Console.WriteLine("Digite o raio");
            raio = double.Parse(Console.ReadLine()); // Leitura do raio

            if (raio.ToString() == null) VolumeCone();

            Console.WriteLine("Digite a altura");
            altura = double.Parse(Console.ReadLine());

            if (altura.ToString() == null) VolumeCone();
            volume = (pi * Math.Pow(raio, 2) * altura)/3;

            Console.WriteLine("VOLUME = {0:F3}", volume);
        }
        catch (Exception ex)
        {
            string mensagem = ex.Message;
            throw new Exception(mensagem);
        }
    }

    public static void VolumeCubo()
    {
        double aresta, volume;
       
        try
        {
            Console.WriteLine("Digite a aresta");
            aresta = double.Parse(Console.ReadLine()); // Leitura da area
            if (aresta.ToString() == null) VolumeCubo();
            volume =  Math.Pow(aresta, 3);

            Console.WriteLine("VOLUME = {0:F3}", volume);
        }
        catch (Exception ex)
        {
            string mensagem = ex.Message;
            throw new Exception(mensagem);
        }
    }
}
