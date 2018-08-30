using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Tabuada
    {
        public static void Calcular(int numero)
        {
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine(x + " X " + numero + " = " + (numero * x));
            }
        }

    }
}
