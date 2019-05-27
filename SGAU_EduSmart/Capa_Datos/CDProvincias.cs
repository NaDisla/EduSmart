using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class CDProvincias
    {
        clConexion Conectar = new clConexion();
        SqlDataReader LeerFilas;

        public DataTable MostrarProvincias()
        {
            DataTable Tabla = new DataTable();
            SqlCommand CMD_Prov = new SqlCommand("SIUD_Provincias");
            CMD_Prov.CommandType = CommandType.StoredProcedure;
            CMD_Prov.Connection = Conectar.AbrirConexion();
            CMD_Prov.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMD_Prov.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

        public void InsertarProvincia(string Prov_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Provincias");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@nombre", Prov_Nombre);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la inserción de datos" + e.Message.ToString(), "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conectar.CerrarConexion();
            }
        }
    }
}
