using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Dados
    {
        private static int RodarDados()
        {
            Random rnd = new Random();
            return rnd.Next(1,7);
        }

        public static void CondicaoDados(string nome1 , string nome2, int rodadas)
        {
            int dado1;
            int dado2;
            int pontos1 = 0;
            int pontos2 = 0;

            for (int i = 1; i <= rodadas; i++)
            {
                dado1 = RodarDados();
                dado2 = RodarDados();

                Console.WriteLine("\nJOGADOR " + nome1 + ": " + dado1);
                Console.WriteLine("JOGADOR " + nome2 + ": " + dado2);

                if (dado1 == dado2)
                    Console.WriteLine("Rodada " + i + " Empate\n");
                else if (dado1 > dado2)
                    pontos1++;
                else
                    pontos2++;

                Console.WriteLine("\nPONTOS: " + nome1 + " :" + pontos1 + " , " + nome2 + " :" + pontos2);

                Vencedor(nome1, nome2, pontos1, pontos2, i, rodadas, dado1, dado2);

                

            }

        }

        private static void GanhadorRodada(string nome1, string nome2, int pontos1, int pontos2, int i, int rodadas, int dado1, int dado2)
        {
            if (dado1 == dado2)
                Console.WriteLine("Rodada " + i + " Empate\n");
            else if (dado1 > dado2)
            {
                Console.WriteLine("Vencedor da rodada " + i + " : " + nome1 + "\n");
            }
            else
            {
                Console.WriteLine("Vencedor da rodada " + i + " : " + nome2 + "\n");
            }
        }

        private static void Vencedor(string nome1, string nome2, int pontos1, int pontos2, int i, int rodadas , int dado1, int dado2)
        {
            if (i == rodadas)
            {
                if (pontos1 > pontos2)
                    Console.WriteLine("\nVENCEDOR: " + nome1);
                else if (pontos2 > pontos1)
                    Console.WriteLine("\nVENCEDOR: " + nome2);
                else
                    Empate(nome1, nome2, pontos1, pontos2, i, rodadas, dado1, dado2);
            }
        }

        private static void Empate(string nome1, string nome2, int pontos1, int pontos2, int i, int rodadas, int dado1 , int dado2)
        {
            if (i == rodadas)
            {
                do
                {
                    if (pontos1 == pontos2)
                    {
                        dado1 = RodarDados();
                        dado2 = RodarDados();

                        Console.WriteLine("\n****DESEMPATE****");
                        Console.WriteLine("\nJOGADOR " + nome1 + ": " + dado1);
                        Console.WriteLine("JOGADOR " + nome2 + ": " + dado2);

                        if (dado1 > dado2)
                        {
                            Console.WriteLine("Vencedor : " + nome1 + " " + dado1);
                            pontos1++;
                        }
                        else if (dado2 > dado1)
                        {
                            Console.WriteLine("Vencedor : " + nome2 + " " + dado2);
                            pontos2++;
                        }

                    }
                }while (pontos1 == pontos2);

            }
        }
    }
}
