using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class ComboBox
    {
        public static string Cadena()
        {
            return "<ComboBox" + Environment.NewLine +
                  "IsTextSearchEnabled = \"True\"" + Environment.NewLine +
                  "IsEditable = \"True\"" + Environment.NewLine +
                  "Margin = \"5\"" + Environment.NewLine +
                  "Grid.Row = \"0\"" + Environment.NewLine +
                  "Grid.Column = \"0\"/>";
        }
    }
}
