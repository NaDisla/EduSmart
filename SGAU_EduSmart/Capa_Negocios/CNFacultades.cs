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
    public class CNFacultades
    {
        CDFacultades ObjFacultad = new CDFacultades();

        public void InsertarFacultad(string Fac_Nombre)
        {
            ObjFacultad.InsertarFacultad(Fac_Nombre);
        }
        public DataTable MostrarFacultades()
        {
            DataTable DTFacultades;
            DTFacultades = ObjFacultad.ListarFacultades();
            return DTFacultades;
        }
        public void ModificarFacultad(int ID, string Fac_Nombre)
        {
            ObjFacultad.ModificarFacultad(ID, Fac_Nombre);
        }
    }
}
