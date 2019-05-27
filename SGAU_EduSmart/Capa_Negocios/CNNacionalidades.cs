using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CNNacionalidades
    {
        CDNacionalidades ObjNacionalidad = new CDNacionalidades();
        clConexion Conectar = new clConexion();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;

        public DataTable ListarNacionalidades()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conectar.AbrirConexion();
            Comando.CommandText = "ListarNacionalidades";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

        public void InsertarNacionalidad(string Nac_Nombre, ref bool ResultadoOk, ref string MensajeError)
        {
            ObjNacionalidad.InsertarNacionalidad(Nac_Nombre, ref ResultadoOk, ref MensajeError);
        }
    }
}
