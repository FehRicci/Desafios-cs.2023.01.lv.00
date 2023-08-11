// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bom vindo ao jogo de dados!\n");
string nome1;
string nome2;
int rodadas;

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


do
{
    Console.WriteLine("Informe a quantidade de rodadas (entre 1 e 5): ");
    rodadas = int.Parse(Console.ReadLine());
}while (rodadas < 1 || rodadas > 5);

Dados.Dados.CondicaoDados(nome1, nome2, rodadas);

