using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class DataGridColumnConEstilo
    {
        public static string Cadena(int columnas)
        {
            return Columnas(columnas);
        }

        private static string DefinicionColumna(bool esApertura)
        {
            return "<" + (esApertura 
                ? "DataGridTextColumn Header=\"\" Width=\"80\" Binding=\"{Binding Propiedad, StringFormat=C}\"" 
                : "/DataGridTextColumn") 
                + ">";
        }

        private static string DefinicionCellStyle(bool esApertura)
        {
            return "<" + (esApertura ? string.Empty : "/") + "DataGridTextColumn.CellStyle>";
        }

        private static string DefinicionStyle(bool esApertura)
        {
            return "<" + (esApertura ? string.Empty : "/") + "Style>";
        }

        private static string Columna()
        {
            return DefinicionColumna(true) + Environment.NewLine +
                DefinicionCellStyle(true) + Environment.NewLine +
                DefinicionStyle(true) + Environment.NewLine +
                "<Setter" +
                " Property=\"FrameworkElement.HorizontalAlignment\"" +
                " Value=\"Right\"/>" + Environment.NewLine +
                DefinicionStyle(false) + Environment.NewLine +
                DefinicionCellStyle(false) + Environment.NewLine +
                DefinicionColumna(false);
        }

        private static string Columnas(int numeroColumas)
        {
            return General.RepetirCadena(numeroColumas, Columna());
        }
    }
}
