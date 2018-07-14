using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorXaml.ModelosVista
{
    public class SelectorObjetoModeloVista : ModeloVistaBase
    {
        private string _filtro;
        public string Filtro
        {
            get { return _filtro; }
            set { SetField(ref _filtro, value, nameof(Filtro)); }
        }

        private List<Type> _datos;
        public List<Type> Datos
        {
            get { return _datos; }
            set { SetField(ref _datos, value, nameof(Datos)); }
        }

        private ObservableCollection<Type> _lineas;
        public ObservableCollection<Type> Lineas
        {
            get { return _lineas; }
            set { SetField(ref _lineas, value, nameof(Lineas)); }
        }

        public void Consultar()
        {
            if (!string.IsNullOrWhiteSpace(Filtro))
            {
                var texto = Filtro.ToLower();

                var DatosFiltrados = Datos
                    .Where(i => i.FullName.ToLower().Contains(texto))
                    .ToList();

                Lineas = new ObservableCollection<Type>(DatosFiltrados);
            }
            else
            {
                Lineas = new ObservableCollection<Type>(Datos);
            }
        }
    }
}
