using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacoes
    {
        public static double Somar(double valor1, double valor2) {
           return (valor1 + valor2);
        }
        public static double Subtrair(double valor1, double valor2)
        {
            return (valor1 - valor2);
        }
        public static double Multiplicar(double valor1, double valor2)
        {
            return (valor1 * valor2);
        }
        public static double Dividir(double valor1, double valor2)
        {
            return (valor1 / valor2);
        }
        public static double Resto(double valor1, double valor2)
        {
            return (valor1 % valor2);
        }
        public static double Potencia(double valor1, double valor2)
        {
            return Math.Pow(valor1 , valor2);
        }
    }

    
}
