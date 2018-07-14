using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class Button
    {
        public static string Cadena()
        {
            return "<Button Padding=\"0\"" + Environment.NewLine +
                            "Height = \"25\"" + Environment.NewLine +
                            "Width = \"25\"" + Environment.NewLine +
                            "Margin = \"5\">" + Environment.NewLine +
                            "Content = \"\"" + Environment.NewLine +
                        "< material:PackIcon Kind = \"Plus\" />" + Environment.NewLine +
                     "</Button> ";
        }
    }
}
