using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class DataGridIEnumerable
    {
        public static string Cadena(int columnas)
        {
            return Cabecera(true) + Environment.NewLine +
                DefinicionColumna(true) + Environment.NewLine +
                Columnas(columnas) + Environment.NewLine +
                DefinicionColumna(false) + Environment.NewLine +
                Cabecera(false);
        }

        private static string Cabecera(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "grid:IEnumerableGrid>";
        }

        private static string Columnas(int numeroColumas)
        {
            return General.RepetirCadena(numeroColumas, Columna());
        }

        private static string Columna()
        {
            return "<DataGridTextColumn Header=\"\" Width=\"100\"/>";
        }

        private static string DefinicionColumna(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "grid:IEnumerableGrid.Columns>";
        }
    }
}
