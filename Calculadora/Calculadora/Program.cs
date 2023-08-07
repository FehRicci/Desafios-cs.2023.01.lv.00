// See https://aka.ms/new-console-template for more information
using Calculadora;
using System.ComponentModel;

int opcao;

do
{
    Console.WriteLine("Escolha a opção desejada:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Resto da Divisão");
    Console.WriteLine("6 - Potência");
    Console.WriteLine("0 - SAIR");

    opcao = int.Parse(Console.ReadLine());

    double valor1;
    double valor2;
    if (opcao != 0)
    {
        Console.WriteLine("Informe o primeiro valor:");
        valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor:");
        valor2 = double.Parse(Console.ReadLine());
    }
    else
    {
        break;
    }


    switch (opcao)
    {
        case 1:
            Console.WriteLine("O Resultado é: " + Operacoes.Somar(valor1, valor2));
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("O Resultado é: " + Operacoes.Subtrair(valor1, valor2));
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("O Resultado é: " + Operacoes.Multiplicar(valor1, valor2));
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("O Resultado é: " + Operacoes.Dividir(valor1, valor2));
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("O Resultado é: " + Operacoes.Resto(valor1, valor2));
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("O Resultado é: " + Operacoes.Potencia(valor1, valor2));
            Console.WriteLine();
            break;
        default:
            break;

    }
}while(opcao !=0);

