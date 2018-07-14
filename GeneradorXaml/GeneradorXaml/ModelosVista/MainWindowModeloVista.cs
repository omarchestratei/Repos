using GeneradorXaml.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.ModelosVista
{
    public class MainWindowModeloVista : ModeloVistaBase
    {
        public RelayCommand ComandoBuscar { get; set; }
        public RelayCommand ComandoEscribirFiltro { get; set; }
        public RelayCommand ComandoImprimirReporte { get; set; }
        public RelayCommand ComandoExportarReporte { get; set; }
        public RelayCommand ComandoExportarReporteLinea { get; set; }
        public RelayCommand ComandoImprimirReporteLinea { get; set; }

        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set { SetField(ref _codigo, value, nameof(Codigo)); }
        }

        private List<Type> _tipos;
        public List<Type> Tipos
        {
            get { return _tipos; }
            set { SetField(ref _tipos, value, nameof(Tipos)); }
        }

        private string _archivo;
        public string Archivo
        {
            get { return _archivo; }
            set { SetField(ref _archivo, value, nameof(Archivo)); }
        }

        private Type _tipoSeleccionado;
        public Type TipoSeleccionado
        {
            get { return _tipoSeleccionado; }
            set { SetField(ref _tipoSeleccionado, value, nameof(TipoSeleccionado)); }
        }

        private string _tipoSeleccionadoNombre;
        public string TipoSeleccionadoNombre
        {
            get { return _tipoSeleccionadoNombre; }
            set { SetField(ref _tipoSeleccionadoNombre, value, nameof(TipoSeleccionadoNombre)); }
        }

        private List<PropertyInfo> _tipoSeleccionadoPropiedades;
        public List<PropertyInfo> TipoSeleccionadoPropiedades
        {
            get { return _tipoSeleccionadoPropiedades; }
            set { SetField(ref _tipoSeleccionadoPropiedades, value, nameof(TipoSeleccionadoPropiedades)); }
        }

        public void CargarTipoSeleccionado(Type Tipo)
        {
            TipoSeleccionado = Tipo;
            TipoSeleccionadoNombre = Tipo.FullName;
            TipoSeleccionadoPropiedades = Tipo.GetProperties().ToList();
        }

        public void ModeloDefault()
        {
            Codigo = "";
            Tipos = new List<Type>();
            Archivo = "";
            TipoSeleccionado = null;
            TipoSeleccionadoNombre = "";
            TipoSeleccionadoPropiedades = new List<PropertyInfo>();
        }
    }
}
