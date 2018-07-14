using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.Plantillas
{
    public static class Plantilla
    {
        public static string Button = Plantillas.Button.Cadena();

        public static string CheckBox = Plantillas.CheckBox.Cadena();

        public static string ComboBox = Plantillas.ComboBox.Cadena();

        public static string Label = Plantillas.Label.Cadena();

        public static string LabelPropiedad(int numPropiedad, string nombrePropiedad)
        {
            return Plantillas.Label.Cadena(numPropiedad, nombrePropiedad);
        }

        public static string TextBox = Plantillas.TextBox.Cadena();

        public static string TextBoxPropiedad(int numPropiedad, string nombrePropiedad)
        {
            return Plantillas.TextBox.Cadena(numPropiedad, nombrePropiedad);
        }

        public static string TextBoxCatalogo = Plantillas.TextBoxCatalogo.Cadena();

        public static string DataGrid(int numColumnas)
        {
            return Plantillas.DataGrid.Cadena(numColumnas);
        }

        public static string DataGridColumnConBoton(int numColumnas)
        {
            return Plantillas.DataGridColumnConBoton.Cadena(numColumnas);
        }

        public static string DataGridColumnConEstilo(int numColumnas)
        {
            return Plantillas.DataGridColumnConEstilo.Cadena(numColumnas);
        }

        public static string DataGridIEnumerable(int numColumnas)
        {
            return Plantillas.DataGridColumnConEstilo.Cadena(numColumnas);
        }

        public static string Grid(int numColumnas, int numFilas)
        {
            return Plantillas.Grid.Cadena(numColumnas, numFilas);
        }

        public static string GridPropiedades(List<PropertyInfo> propiedades)
        {
            return Plantillas.Grid.CadenaPropiedades(propiedades);
        }

        public static string InputBindings(int cantidad)
        {
            return Plantillas.InputBindings.Cadena(cantidad);
        }
    }
}
