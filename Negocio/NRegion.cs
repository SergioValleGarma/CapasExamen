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
        public List<Region> Listar(Region region)
        {
            List<Region> ret = new List<Region>();
            DRegion datos = new DRegion();
            ret = datos.Listar(region);
            return ret;
        }

        public void Crear(Region region)
        {
            DRegion datos = new DRegion();
            datos.CrearRegion(region);
        }

        public void Editar(Region region)
        {
            DRegion datos = new DRegion();
            datos.EditarRegion(region);
        }

        public void Eliminar(Region region)
        {
            DRegion datos = new DRegion();
            datos.Eliminar(region);
        }
    }
}
