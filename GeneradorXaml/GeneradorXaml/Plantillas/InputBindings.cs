using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public class InputBindings
    {
        public static string Cadena(int numKeys)
        {
            return Cabecera(true) + Environment.NewLine +
                Keys(numKeys) + Environment.NewLine +
                Cabecera(false);
        }

        private static string Cabecera(bool esApertura)
        {
            return "< " + (esApertura ? string.Empty : "/") + "Page.InputBindings>";
        }

        private static string Keys(int veces)
        {
            return General.RepetirCadena(veces, Key());
        }

        private static string Key()
        {
            return "<KeyBinding Key=\"\" Modifiers=\"Ctrl\" Command=\"{Binding ComandoNombre}\"/>";
        }
    }
}
