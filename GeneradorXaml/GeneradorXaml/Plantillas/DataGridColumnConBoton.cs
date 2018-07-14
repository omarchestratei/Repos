using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class DataGridColumnConBoton
    {
        public static string Cadena(int num)
        {
            return Columnas(num);
        }

        private static string Cabecera(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "DataGridTemplateColumn>";
        }

        private static string DefinicionCellTemplate(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "DataGridTemplateColumn.CellTemplate>";
        }

        private static string DefinicionDataTemplate(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "DataTemplate>";
        }

        private static string Columnas(int veces)
        {
            return General.RepetirCadena(veces, Columna());
        }

        private static string Columna()
        {
            return Cabecera(true) + Environment.NewLine +
                    DefinicionCellTemplate(true) + Environment.NewLine +
                    DefinicionDataTemplate(true) + Environment.NewLine +
                    "<Button Height=\"20\"" + Environment.NewLine +
                            "Width = \"20\"" + Environment.NewLine +
                            "Padding = \"0\"" + Environment.NewLine +
                            "Margin = \"0\"" + Environment.NewLine +
                            "Command = \"{Binding ElementName=Vista," + Environment.NewLine +
                            "Path = DataContext.ComandoNombre}\"" + Environment.NewLine +
                            "CommandParameter=\"{Binding .}\"" + Environment.NewLine +
                            "ToolTip=\"\">" + Environment.NewLine +

                            "<md:PackIcon Kind = \"\"/>" + Environment.NewLine +
                    "</Button> " + Environment.NewLine + 
                    DefinicionDataTemplate(false) + Environment.NewLine +
                    DefinicionCellTemplate(false) + Environment.NewLine +
                    Cabecera(false);
        }
    }
}
