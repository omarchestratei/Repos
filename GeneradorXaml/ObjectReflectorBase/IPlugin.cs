using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReflectorBase
{
    public interface IPlugin
    {
        string CrearCadena(Type tipo);
        string Nombre();
    }
}
