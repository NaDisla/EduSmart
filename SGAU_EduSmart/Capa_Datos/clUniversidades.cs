using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Presentacion.Capa_Datos
{
    class clUniversidades
    {
        /*clConexion Conectar = new clConexion();
        SqlCommand Cmd = new SqlCommand();
        SqlDataReader Read_Rows;

        public void InsertarUniversidades(string Fac_Nombre)
        {
            Cmd.Connection = Conectar.AbrirConexion();
            Cmd.CommandText = "InsertarUniversidades";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@nombre", Fac_Nombre);
            Cmd.ExecuteNonQuery();
            Cmd.Parameters.Clear();
        }
        public DataTable ListarProvincias()
        {
            DataTable Tabla = new DataTable();
            Cmd.Connection = Conectar.AbrirConexion();
            Cmd.CommandText = "ListarProvincias";
            Cmd.CommandType = CommandType.StoredProcedure;
            Read_Rows = Cmd.ExecuteReader();
            Tabla.Load(Read_Rows);
            Read_Rows.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarDistritos()
        {
            DataTable Tabla = new DataTable();
            Cmd.Connection = Conectar.AbrirConexion();
            Cmd.CommandText = "ListarDistritos";
            Cmd.CommandType = CommandType.StoredProcedure;
            Read_Rows = Cmd.ExecuteReader();
            Tabla.Load(Read_Rows);
            Read_Rows.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }*/
    }
}
