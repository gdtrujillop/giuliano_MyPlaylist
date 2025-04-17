using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylist
{
    internal class Gato : Animal
    {
        public double CalculoNota(double nota)
        {
            return (nota*3)/2;
        }

        public int contarPares()
        {
            int cont = 0;
            int var = 15;
            if (var % 2 == 0)
            {
                cont++;
                return cont;
            }
            else
                return 0;
        }

        public void PeliPrincipal()
        {
            Console.WriteLine("The dark knight rises");
        }

    }
}
