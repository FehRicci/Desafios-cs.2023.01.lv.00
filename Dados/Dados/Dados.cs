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

        public static void CondicaoDados(string nome1 , string nome2)
        {
            int numRodadas = 3;
            int dado1;
            int dado2;
            int pontos1 = 0;
            int pontos2 = 0;

            for (int i = 1; i <= numRodadas; i++)
            {
                dado1 = RodarDados();
                dado2 = RodarDados();

                Console.WriteLine("\nJOGADOR " + nome1 + ": " + dado1);
                Console.WriteLine("JOGADOR " + nome2 + ": " + dado2);
                if (dado1 == dado2)
                    Console.WriteLine("Rodada " + i + " Empate\n");
                else if (dado1 > dado2)
                {
                    pontos1++;
                    Console.WriteLine("Vencedor da rodada " + i + " : " + nome1 + "\n");
                }
                else
                {
                    pontos2++;
                    Console.WriteLine("Vencedor da rodada " + i + " : " + nome2 + "\n");
                }

                Console.WriteLine("\n PONTOS: " + nome1 + " :" + pontos1 + " , " + nome2 + " :" + pontos2);

                if (i == 3)
                {
                    if (pontos1 > pontos2)
                        Console.WriteLine("\nVENCEDOR: " + nome1);
                    else if (pontos2 > pontos1)
                        Console.WriteLine("\nVENCEDOR: " + nome2);
                    else
                        Console.WriteLine("\nEMPATE");
                }


            }

        }
    }
}
