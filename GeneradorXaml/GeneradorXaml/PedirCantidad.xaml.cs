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
    /// Interaction logic for PedirCantidad.xaml
    /// </summary>
    public partial class PedirCantidad : Window
    {
        public PedirCantidad()
        {
            InitializeComponent();

            txtCantidad.Focus();
        }

        public bool ok { get; set; }

        public int Cantidad
        {
            get
            {
                int salida = 0;
                int.TryParse(txtCantidad.Text, out salida);
                return salida;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ok = true;
            Close();
        }
    }
}
