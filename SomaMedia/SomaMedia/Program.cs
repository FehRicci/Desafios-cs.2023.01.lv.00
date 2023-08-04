// See https://aka.ms/new-console-template for more information
using SomaMedia;

Console.WriteLine("Informe a quantidade de valores a serem somados");
int value = int.Parse(Console.ReadLine());
while (value < 3 || value > 10)
{
    Console.WriteLine("Informe a quantidade de valores a serem somados(entre 3 e 10)");
    value = int.Parse(Console.ReadLine());
}
int[] values = new int[value];

for (int i = 0; i < value; i++)
{
    Console.WriteLine("Informe o valor: ");
    values[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("A soma dos valores é: " + Operacao.Somar(values));
Console.WriteLine("A média dos valores é: " + Operacao.Media(values));