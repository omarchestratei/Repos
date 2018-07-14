using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class General
    {
        public static string RepetirCadena(int veces, string cadena)
        {
            var salida = "";
            for (int i = 0; i < veces; i++)
            {
                salida += cadena + Environment.NewLine;
            }

            return salida;
        }
    }
}
