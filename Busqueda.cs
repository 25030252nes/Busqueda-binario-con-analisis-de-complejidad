using System;
using System.Collections.Generic;
using System.Text;

namespace Busqueda_binario_con_analisis_de_complejidad
{
    public class Busqueda
    {
        public static int Binaria(int[] a, int x)
        {
            int i = 0, f = a.Length - 1;
            while (i <= f)
            {
                int m = (i + f) / 2;
                if (a[m] == x) return m;
                if (a[m] < x) i = m + 1;
                else f = m - 1;
            }
            return -1;
        }
    }
}
