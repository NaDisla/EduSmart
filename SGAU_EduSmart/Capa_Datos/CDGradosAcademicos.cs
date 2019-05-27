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
    public class CDGradosAcademicos
    {
        clConexion Conectar = new clConexion();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;

        public DataTable MostrarGrados()
        {
            DataTable Tabla = new DataTable();
            SqlCommand CMD_Grados = new SqlCommand("SIUD_GradosACDM");
            CMD_Grados.CommandType = CommandType.StoredProcedure;
            CMD_Grados.Connection = Conectar.AbrirConexion();
            CMD_Grados.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMD_Grados.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

        public void InsertarGradoAcademico(string GradoAcdm_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_GradosACDM");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@nombre", GradoAcdm_Nombre);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la inserción de los datos: " + e.Message.ToString(), "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conectar.CerrarConexion();
            }
        }

        public void ModificarGradoAcademico(string GradoAcdm_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_GradosACDM");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "U");
                Comando.Parameters.AddWithValue("@nombre", GradoAcdm_Nombre);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación de los datos: " + e.Message.ToString(), "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conectar.CerrarConexion();
            }
        }
    }
}
