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
    public class CNDistritos
    {
        CDDistritos ObjDistrito = new CDDistritos();
        clConexion Conectar = new clConexion();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;

        public DataTable ListarDistritos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conectar.AbrirConexion();
            Comando.CommandText = "ListarDistritos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

        public void InsertarDistrito(string Distr_Nombre, ref bool ResultadoOk, ref string MensajeError)
        {
           ObjDistrito.InsertarDistrito(Distr_Nombre, ref ResultadoOk, ref MensajeError);
        }
    }
}
