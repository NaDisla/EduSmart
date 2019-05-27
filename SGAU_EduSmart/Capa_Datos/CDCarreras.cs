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
    public class CDCarreras
    {
        clConexion Conectar = new clConexion();
        SqlCommand CMD = new SqlCommand();
        SqlDataReader LeerFilas;

        public DataTable MostrarCarreras()
        {
            DataTable TablaCarreras = new DataTable();
            SqlCommand CMD_Carrera = new SqlCommand("SIUD_Carreras");
            CMD_Carrera.CommandType = CommandType.StoredProcedure;
            CMD_Carrera.Connection = Conectar.AbrirConexion();
            CMD_Carrera.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMD_Carrera.ExecuteReader();
            TablaCarreras.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return TablaCarreras;
        }


        public void InsertarCarrera(int ID_Facultad, int ID_Escuela, string Carr_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Carreras");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@idfacultad", ID_Facultad);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.Parameters.AddWithValue("@nombre", Carr_Nombre);
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
        public void ModificarCarrera(int ID_Facultad, int ID_Escuela, string Carr_Nombre)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Carreras");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "U");
                Comando.Parameters.AddWithValue("@idfacultad", ID_Facultad);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.Parameters.AddWithValue("@nombre", Carr_Nombre);
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
