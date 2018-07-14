using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class CheckBox
    {
        public static string Cadena()
        {
            return "<CheckBox" + Environment.NewLine +
                  "Grid.Column = \"0\"" + Environment.NewLine +
                  "Grid.Row = \"0\"" + Environment.NewLine +
                  "Content = \"\"" + Environment.NewLine +
                  "Margin = \"5\"/>";
        }
    }
}
