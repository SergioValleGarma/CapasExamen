using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRegion
    {
        public List<Region> Listar(string Nombre)
        {
            List<Region> ret = new List<Region>();
            DRegion datos = new DRegion();
            ret = datos.Listar(Nombre);
            return ret;
        }
    }
}
