using GeneradorXaml.ModelosVista;
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
    /// Interaction logic for SelectorObjeto.xaml
    /// </summary>
    public partial class SelectorObjeto : Window
    {
        SelectorObjetoModeloVista ModeloVista;

        public Type TipoSeleccionado { get; set; }
        public bool Ok { get; set; }

        public SelectorObjeto(List<Type> Datos)
        {
            InitializeComponent();

            ModeloVista = new SelectorObjetoModeloVista();
            ModeloVista.Datos = Datos;

            DataContext = ModeloVista;

            Buscar();

            txtBuscar.Focus();

            Eventos();
        }

        public void Eventos()
        {
            txtBuscar.KeyDown += (s, e) =>
            {
                if (e.Key == Key.Enter)
                    Buscar();
            };

            //DataGrid.PreviewKeyDown += (o, e) =>
            //{
            //    if (e.Key == Key.Enter &&
            //        DataGrid.SelectedItems.Count > 0)
            //    {
            //        Aceptar();
            //    }
            //};

            DataGrid.MouseDoubleClick += (o, e) =>
            {
                if (DataGrid.SelectedItems.Count > 0)
                    Aceptar();
            };
        }

        private void Buscar()
        {
            ModeloVista.Consultar();
        }

        private void Aceptar()
        {
            Ok = true;
            TipoSeleccionado = (Type)DataGrid.SelectedItem;
            Close();
        }
    }
}
