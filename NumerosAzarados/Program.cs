string numero = Console.ReadLine();

//TODO: Descubra e imprima se o número é azarado.
//Dica: O método "Contains" pode ser útil neste desafio.
if (numero.Contains("13"))
{
    Console.WriteLine(numero + " es de Mala Suerte");
}
else
{
    Console.WriteLine(numero + " NO es de Mala Suerte");
}
