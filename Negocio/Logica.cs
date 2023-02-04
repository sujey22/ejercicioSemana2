using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejerciciosemana2.Entidades;

namespace Ejerciciosemana2.Negocio
{
    internal class Logica
    {
        public String NMayorOIgual (Numeros num) {
            int n1 = num.getNumero1();
            int n2 = num.getNumero2();

            if (n1 == n2)
            {
                return ("El primer numero ingresado es " + n1 + " y es igual al segundo que es " + n2);

            }else if (n1 > n2)
            {
                return ("El numero " + n1 + " es mayor que " + n2);

            }else if (n1 < n2)
            {
                return ("El numero " + n2 + " es mayor que " + n1);

            }
            else
            {
                return "Asegurese de ingresar datos correctos"; 
            }
        }
    }
}

 