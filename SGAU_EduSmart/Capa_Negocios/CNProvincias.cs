using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocios
{
    public class CNProvincias
    {
        CDProvincias ObjProvincia = new CDProvincias();

        public DataTable MostrarProvincias()
        {
            DataTable DTProvincias;
            DTProvincias= ObjProvincia.MostrarProvincias();
            return DTProvincias;
        }

        public void InsertarProvincia(string Prov_Nombre)
        {
            ObjProvincia.InsertarProvincia(Prov_Nombre);
        }
    }
}
