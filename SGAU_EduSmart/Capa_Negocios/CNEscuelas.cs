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
    public class CNEscuelas
    {
        CDEscuelas ObjEscuela = new CDEscuelas();

        public void InsertarEscuela(int ID_Facultad, string Esc_Nombre)
        {
            ObjEscuela.InsertarEscuela(ID_Facultad, Esc_Nombre);
        }
        public DataTable MostrarEscuelas()
        {
            DataTable DTEscuelas;
            DTEscuelas = ObjEscuela.MostrarEscuelasInner();
            return DTEscuelas;
        }
    }
}
