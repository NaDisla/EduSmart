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
    public class CDAsignaturas
    {
        clConexion Conectar = new clConexion();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;
        public DataTable MostrarAsignaturas()
        {
            DataTable Tabla = new DataTable();
            SqlCommand CMD_Asignt = new SqlCommand("SIUD_Asignaturas");
            CMD_Asignt.CommandType = CommandType.StoredProcedure;
            CMD_Asignt.Connection = Conectar.AbrirConexion();
            CMD_Asignt.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMD_Asignt.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }
        public void InsertarAsignatura(int ID_Facultad, int ID_Escuela, string Asignt_Nombre, string Asignt_Codigo, int Asignt_Creditos, int Asignt_HorasPract, int Asignt_HorasTeor, int Asignt_TotalHoras,
            int Asignt_BloquePensum)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Asignaturas");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@idfacultad", ID_Facultad);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.Parameters.AddWithValue("@nombre", Asignt_Nombre);
                Comando.Parameters.AddWithValue("@codigo", Asignt_Codigo);
                Comando.Parameters.AddWithValue("@creditos", Asignt_Creditos);
                Comando.Parameters.AddWithValue("@horaspract", Asignt_HorasPract);
                Comando.Parameters.AddWithValue("@horasteor", Asignt_HorasTeor);
                Comando.Parameters.AddWithValue("@totalhoras", Asignt_TotalHoras);
                Comando.Parameters.AddWithValue("@bloquepensum", Asignt_BloquePensum);
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
        public void ModificarAsignatura(int ID_Facultad, int ID_Escuela, string Asignt_Nombre, string Asignt_Codigo, int Asignt_HorasPract, int Asignt_HorasTeor, int Asignt_TotalHoras)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Asignaturas");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "U");
                Comando.Parameters.AddWithValue("@idfacultad", ID_Facultad);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.Parameters.AddWithValue("@nombre", Asignt_Nombre);
                Comando.Parameters.AddWithValue("@codigo", Asignt_Codigo);
                Comando.Parameters.AddWithValue("@horaspract", Asignt_HorasPract);
                Comando.Parameters.AddWithValue("@horasteor", Asignt_HorasTeor);
                Comando.Parameters.AddWithValue("@totalhoras", Asignt_TotalHoras);
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
