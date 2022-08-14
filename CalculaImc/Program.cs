double IMC, peso, altura;
int idade;
string nome;

Console.WriteLine("Qual seu nome ? ");
nome = Console.ReadLine();
Console.WriteLine("Qual a sua idade?  ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o peso: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());

IMC = peso / (altura * altura);

Console.WriteLine(nome + $" O VALOR DO SEU IMC É : {IMC:0.00}\n", IMC);

Console.WriteLine(nome + $" o seu status é: ");
if (IMC < 18)
{
    Console.WriteLine("Magreza");
}

else if ((IMC > 18) && (IMC < 25))
{
    Console.WriteLine("Normal");
}

else if ((IMC > 26) && (IMC < 30))
{
    Console.WriteLine("Sobrepeso");
}
else if ((IMC > 31) && (IMC < 40))
{
    Console.WriteLine("Obesidade");
}

else
{
    Console.WriteLine("Obesidade Grave");
}
