using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class TextBox
    {
        public static string Cadena()
        {
            return "<TextBox Grid.Column=\"0\"" + Environment.NewLine +
               "Grid.Row = \"0\"" + Environment.NewLine +
               "Margin = \"5\"" + Environment.NewLine +
               "Text = \"{Binding Propiedad, UpdateSourceTrigger=PropertyChanged}\"/>";
        }

        public static string Cadena(int numPropiedad, string nombrePropiedad)
        {
            return "<TextBox Grid.Column=\"1\"" + Environment.NewLine +
               "Grid.Row = \"" + numPropiedad + "\"" + Environment.NewLine +
               "Margin = \"5\"" + Environment.NewLine +
               "Text = \"{Binding " + nombrePropiedad + ", UpdateSourceTrigger=PropertyChanged}\"/>";
        }
    }
}
