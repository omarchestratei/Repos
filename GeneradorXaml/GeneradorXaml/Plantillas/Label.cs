using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class Label
    {
        public static string Cadena()
        {
            return "<Label Grid.Column=\"0\"" + Environment.NewLine +
               "Grid.Row = \"0\"" + Environment.NewLine +
               "Content = \"\"" + Environment.NewLine +
               "HorizontalAlignment = \"Right\"" + Environment.NewLine +
               "VerticalAlignment = \"Center\"" + Environment.NewLine +
               "Margin = \"5\"/>";
        }

        public static string Cadena(int numPropiedad, string nombrePropiedad)
        {
            return "<Label Grid.Column=\"0\"" + Environment.NewLine +
               "Grid.Row = \"" + numPropiedad + "\"" + Environment.NewLine +
               "Content = \"" + nombrePropiedad + ":\"" + Environment.NewLine +
               "HorizontalAlignment = \"Right\"" + Environment.NewLine +
               "VerticalAlignment = \"Center\"" + Environment.NewLine +
               "Margin = \"5\"/>";
        }
    }
}
