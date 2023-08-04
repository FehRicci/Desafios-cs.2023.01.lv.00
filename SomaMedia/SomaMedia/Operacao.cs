using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SomaMedia
{
    internal class Operacao
    {
        public static double Somar(int[]value)
        {
            var Sum = value.Sum();
            return Sum;
        }
        public static double Media(int[] value)
        {
           var Media = value.Average();
            return Media;
        }
    }
}
