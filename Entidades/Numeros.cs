using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejerciciosemana2.Entidades
{
    internal class Numeros
    {
       int numero1, numero2;

        public Numeros(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int getNumero1()
        {
            return numero1;
        }

        public int getNumero2()
        {
            return numero2;
        }

        public void setNumero1(int numero1)
        {
            this.numero1 = numero1;
        }

        public void setNumero2(int numero2)
        {
            this.numero2 = numero2;
        }
     
    }
}