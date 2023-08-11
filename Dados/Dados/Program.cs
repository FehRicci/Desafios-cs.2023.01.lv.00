// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bom vindo ao jogo de dados!\n");
string nome1;
string nome2;

do
{
    Console.WriteLine("Informe o nome do Primeiro Jogador: ");
    nome1 = Console.ReadLine().ToUpper();

    Console.WriteLine("Informe o nome do Segundo Jogador: ");
    nome2 = Console.ReadLine().ToUpper();

    if (nome1 == nome2)
    {
        Console.WriteLine("\nOs nomes não podem ser iguais!\n");
    }
}while (nome1 == nome2);
