using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class Grid
    {
        public static string Cadena(int columnas, int filas)
        {
            return GridCabecera(true) + Environment.NewLine +
                DefinicionColumna(true) + Environment.NewLine +
                Columnas(columnas) + Environment.NewLine +
                DefinicionColumna(false) + Environment.NewLine +
                DefinicionFila(true) + Environment.NewLine +
                Filas(filas) + Environment.NewLine +
                DefinicionFila(false) + Environment.NewLine +
            GridCabecera(false);
        }

        public static string CadenaPropiedades(List<PropertyInfo> propiedades)
        {
            const int DosColumnas = 2;
            int numFilas = propiedades.Count;

            var cadena = GridCabecera(true) + Environment.NewLine +
                DefinicionColumna(true) + Environment.NewLine +
                Columnas(DosColumnas) + Environment.NewLine +
                DefinicionColumna(false) + Environment.NewLine +
                DefinicionFila(true) + Environment.NewLine +
                Filas(numFilas) + Environment.NewLine +
                DefinicionFila(false) + Environment.NewLine + Environment.NewLine;

            foreach (var prop in propiedades)
            {
                var nombreProp = prop.Name;
                var numProp = propiedades.IndexOf(prop);

                cadena += Label.Cadena(numProp, nombreProp) + Environment.NewLine;
                cadena += TextBox.Cadena(numProp, nombreProp) + Environment.NewLine + Environment.NewLine;
            }

            cadena += GridCabecera(false);

            return cadena;
        }

        private static string GridCabecera(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "Grid>";
        }


        private static string Columnas(int numeroColumas)
        {
            return General.RepetirCadena(numeroColumas, Columna());
        }

        private static string Filas(int numeroFilas)
        {
            return General.RepetirCadena(numeroFilas, Fila());
        }

        private static string FilasPropiedades(int numeroFilas)
        {
            return General.RepetirCadena(numeroFilas, Fila());
        }

        private static string Columna()
        {
            return "<ColumnDefinition Width=\"100\"/>";
        }


        private static string Fila()
        {
            return "<RowDefinition Height=\"38\"/>";
        }

        private static string DefinicionFila(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "Grid.RowDefinitions>";
        }


        private static string DefinicionColumna(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "Grid.ColumnDefinitions>";
        }
    }
}
