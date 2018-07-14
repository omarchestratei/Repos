using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GeneradorXaml
{
    /// <summary>
    /// Interaction logic for DimensionGrid.xaml
    /// </summary>
    public partial class DimensionGrid : Window
    {

        public bool ok { get; set; }
        public int Filas
        {
            get
            {
                int salida = 0;
                int.TryParse(txtFilas.Text, out salida);
                return salida;
            }
        }


        public int Columnas
        {
            get
            {
                int salida = 0;
                int.TryParse(txtColumnas.Text, out salida);
                return salida;
            }
        }




        public DimensionGrid()
        {
            InitializeComponent();

            txtFilas.Focus();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ok = true;
            Close();
        }
    }
}
