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
    public class CDEscuelas
    {
        clConexion CON = new clConexion();
        SqlCommand CMD= new SqlCommand();
        SqlDataReader LeerFilas;

        public DataTable MostrarEscuelasInner()
        {
            DataTable TablaEscuelas = new DataTable();
            SqlCommand CMD_Escuela = new SqlCommand("SIUD_Escuelas");
            CMD_Escuela.CommandType = CommandType.StoredProcedure;
            CMD_Escuela.Connection = CON.AbrirConexion();
            CMD_Escuela.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMD_Escuela.ExecuteReader();
            TablaEscuelas.Load(LeerFilas);
            LeerFilas.Close();
            CON.CerrarConexion();
            return TablaEscuelas;
        }

        public void InsertarEscuela(int ID_Facultad, string Esc_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Escuelas");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = CON.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@idfacultad", ID_Facultad);
                Comando.Parameters.AddWithValue("@nombre", Esc_Nombre);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la inserción de los datos: " + e.Message.ToString());
            }
            finally
            {
                CON.CerrarConexion();
            }
        }

        public void ModificarEscuela(int ID_Facultad, string Esc_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Escuelas");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = CON.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@idfacultad", ID_Facultad);
                Comando.Parameters.AddWithValue("@nombre", Esc_Nombre);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la inserción de los datos: " + e.Message.ToString());
            }
            finally
            {
                CON.CerrarConexion();
            }
        }

    }
}
