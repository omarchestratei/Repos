using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class TextBoxCatalogo
    {
        public static string Cadena()
        {
            return "<enlace:TextBoxCatalogo Grid.Column=\"0\"" + Environment.NewLine +
               "Grid.Row = \"0\"" + Environment.NewLine +
               "VerticalAlignment = \"Center\"" + Environment.NewLine +
               "HorizontalAlignment = \"Left\"" + Environment.NewLine +
               "Margin = \"5\"" + Environment.NewLine +
               "Valor = \"{Binding Propiedad, UpdateSourceTrigger=PropertyChanged}\"/>";
        }
    }
}
