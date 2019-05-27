using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CDPracticas
    {
        clConexion Conectar = new clConexion();
        SqlDataReader LeerFilas;

        public DataTable ListarPracticas()
        {
            DataTable Tabla = new DataTable();
            SqlCommand Comando = new SqlCommand("SIUD_Practicas");
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Connection = Conectar.AbrirConexion();
            Comando.Parameters.AddWithValue("@Control", "S");
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

        //public void InsertarPractica(string Fac_Nombre)
        //{
        //    try
        //    {
        //        SqlCommand Comando = new SqlCommand("SIUD_Facultades");
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Connection = Conectar.AbrirConexion();
        //        Comando.Parameters.AddWithValue("@Control", "I");
        //        Comando.Parameters.AddWithValue("@nombre", Fac_Nombre);
        //        Comando.ExecuteNonQuery();
        //        Comando.Parameters.Clear();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Ha ocurrido un error en la inserción de los datos: " + e.Message.ToString());
        //    }
        //    finally
        //    {
        //        Conectar.CerrarConexion();
        //    }
        //}
    }
}
