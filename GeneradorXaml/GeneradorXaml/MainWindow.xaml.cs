using GeneradorXaml.ModelosVista;
using GeneradorXaml.Plantillas;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace GeneradorXaml
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowModeloVista ModeloVista;

        public MainWindow()
        {
            InitializeComponent();

            ModeloVista = new MainWindowModeloVista();
            ModeloVista.ModeloDefault();

            DataContext = ModeloVista;

            InicializarEventos();
        }

        public void InicializarEventos()
        {
            txtCodigo.TextChanged += (o, e) =>
            {
                if (!txtCodigo.IsFocused)
                {
                    txtCodigo.Focus(); 
                }
            };

            btnLabel.Click += (s, e) => PegarPlantilla(Plantilla.Label);
            btnTextBox.Click += (s, e) => PegarPlantilla(Plantilla.TextBox);
            btnTextBoxCatalogo.Click += (s, e) => PegarPlantilla(Plantilla.TextBoxCatalogo);
            btnButton.Click += (s, e) => PegarPlantilla(Plantilla.Button);
            btnComboBox.Click += (s, e) => PegarPlantilla(Plantilla.ComboBox);
            btnCheckBox.Click += (s, e) => PegarPlantilla(Plantilla.CheckBox);

            btnGrid.Click += (s, e) =>
            {
                var vista = new DimensionGrid();

                vista.ShowDialog();

                if (vista.ok == false)
                    return;

                PegarPlantilla(Plantilla.Grid(vista.Columnas, vista.Filas));
            };

            btnDataGrid.Click += (s, e) =>
            {
                var numColumnas = PedirCantidad();

                if (numColumnas <= 0)
                    return;

                PegarPlantilla(Plantilla.DataGrid(numColumnas));
            };

            btnDataGridIEnumerable.Click += (s, e) =>
            {
                var numColumnas = PedirCantidad();

                if (numColumnas <= 0)
                    return;

                PegarPlantilla(Plantilla.DataGridIEnumerable(numColumnas));
            };

            btnInputBindings.Click += (s, e) =>
            {
                var cantidad = PedirCantidad();

                if (cantidad <= 0)
                    return;

                PegarPlantilla(Plantilla.InputBindings(cantidad));
            };

            btnDataGridTemplateColumn.Click += (s, e) =>
            {
                var numColumnas = PedirCantidad();

                if (numColumnas <= 0)
                    return;

                PegarPlantilla(Plantilla.DataGridColumnConBoton(numColumnas));
            };

            btnDataGridColumn.Click += (s, e) =>
            {
                var numColumnas = PedirCantidad();

                if (numColumnas <= 0)
                    return;

                PegarPlantilla(Plantilla.DataGridColumnConEstilo(numColumnas));
            };

            btnElegirDLL.Click += (s, e) => CargarArchivo();
            btnCargarTipos.Click += (s, e) => CargarTipos();
            btnSeleccionarObjeto.Click += (s, e) => SeleccionarObjeto();
            btnGenerarModelo.Click += (s, e) => GenerarModeloXAML();
        }

        private void PegarPlantilla(string plantilla)
        {
            var texto = plantilla + Environment.NewLine + Environment.NewLine;

            var indiceSeleccion = txtCodigo.SelectionStart;
            ModeloVista.Codigo = ModeloVista.Codigo.Insert(indiceSeleccion, texto);
            txtCodigo.SelectionStart = indiceSeleccion + texto.Length;
        }

        private int PedirCantidad()
        {
            var vista = new PedirCantidad();
            vista.ShowDialog();

            if (vista.ok == false)
                return 0;

            return vista.Cantidad;
        }

        private void GenerarModeloXAML()
        {
            if (string.IsNullOrWhiteSpace(ModeloVista.Archivo))
            {
                MessageBox.Show("Selecciona el archivo");
                return;
            }

            if (ModeloVista.TipoSeleccionado == null)
            {
                MessageBox.Show("Selecciona el objeto");
                return;
            }

            ModeloVista.Codigo = "";

            var Propiedades = ModeloVista.TipoSeleccionadoPropiedades;

            PegarPlantilla(Plantilla.GridPropiedades(Propiedades));
        }

        public void CargarTipos()
        {
            if (string.IsNullOrWhiteSpace(ModeloVista.Archivo))
            {
                MessageBox.Show("Primero selecciona el archivo");
                return;
            }

            try
            {
                var assem = Assembly.LoadFrom(ModeloVista.Archivo);

                ModeloVista.Tipos = assem.GetTypes().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string SeleccionarArchivo()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "dll o exe| *.dll;*.exe";

            var resultado = ofd.ShowDialog();

            if (!resultado.HasValue && !resultado.Value)
                return null;

            return ofd.FileName;
        }

        public void CargarArchivo()
        {
            var archivo = SeleccionarArchivo();

            if (string.IsNullOrWhiteSpace(archivo))
                return;

            ModeloVista.Archivo = archivo;
            CargarTipos();
        }

        public void SeleccionarObjeto()
        {
            if (ModeloVista.Tipos == null || ModeloVista.Tipos.Count() < 1)
            {
                MessageBox.Show("Primero selecciona el dll o exe");
                return;
            }

            var selector = new SelectorObjeto(ModeloVista.Tipos);
            selector.ShowDialog();

            if (selector.Ok && selector.TipoSeleccionado != null)
            {
                ModeloVista.CargarTipoSeleccionado(selector.TipoSeleccionado);
            }
        }
    }
}
