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
    public class CNCarreras
    {
        clConexion Conectar = new clConexion();
        CDCarreras ObjCarrera = new CDCarreras();

        public DataTable MostrarTodasCarreras()
        {
            DataTable DTCarreras;
            DTCarreras = ObjCarrera.MostrarCarreras();
            return DTCarreras;
        }

        public void InsertarCarrera(int ID_Facultad, int ID_Escuela, string Carr_Nombre)
        {
            ObjCarrera.InsertarCarrera(ID_Facultad, ID_Escuela, Carr_Nombre);
        }

        public void ModificarCarrera(int ID_Facultad, int ID_Escuela, string Carr_Nombre)
        {
            ObjCarrera.ModificarCarrera(ID_Facultad, ID_Escuela, Carr_Nombre);
        }

    }
}
