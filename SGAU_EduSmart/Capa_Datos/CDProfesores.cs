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
    public class CDProfesores
    {
        SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;
        clConexion Conectar = new clConexion();

        public DataTable MostrarProfesores()
        {
            DataTable Tabla = new DataTable();
            SqlCommand CMD_Prof = new SqlCommand("SIUD_Profesores");
            CMD_Prof.CommandType = CommandType.StoredProcedure;
            CMD_Prof.Connection = Conectar.AbrirConexion();
            CMD_Prof.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMD_Prof.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }
        public DataTable TraerConsultaProfesores(int ID_Profesor, int ID_Escuela, int ID_GradoAcdm)
        {
            DataTable Tabla = new DataTable();
            SqlCommand CMD_Prof = new SqlCommand("SIUD_Profesores");
            CMD_Prof.CommandType = CommandType.StoredProcedure;
            CMD_Prof.Connection = Conectar.AbrirConexion();
            CMD_Prof.Parameters.AddWithValue("@Control", "S");
            CMD_Prof.Parameters.AddWithValue("@id", ID_Profesor);
            CMD_Prof.Parameters.AddWithValue("@idescuela", ID_Escuela);
            CMD_Prof.Parameters.AddWithValue("@idgradoacdm", ID_GradoAcdm);
            LeerFilas = CMD_Prof.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }
        public void ConsultarProfesor(string ID_Profesor, int ID_GradoAcdm, int ID_Escuela)
        {
            try
            {
                SqlCommand CMD = new SqlCommand("SIUD_Profesores");
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Connection = Conectar.AbrirConexion();
                CMD.Parameters.AddWithValue("@Control", "S");
                CMD.Parameters.AddWithValue("@id", ID_Profesor);
                CMD.Parameters.AddWithValue("@idgradoacdm", ID_GradoAcdm);
                CMD.Parameters.AddWithValue("@idescuela", ID_Escuela);
                CMD.ExecuteNonQuery();
                CMD.Parameters.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la consulta de datos: " + e.Message.ToString(), "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conectar.CerrarConexion();
            }
        }
        public void InsertarProfesor(string Prof_Cedula, string Prof_Nombres, string Prof_Apellidos, string Prof_Telefono, string Prof_Correo,
            string Prof_Direccion, string Prof_Sector, int ID_Provincia, int ID_GradoAcdm, int ID_Escuela)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Profesores");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@cedula", Prof_Cedula);
                Comando.Parameters.AddWithValue("@nombres", Prof_Nombres);
                Comando.Parameters.AddWithValue("@apellidos", Prof_Apellidos);
                Comando.Parameters.AddWithValue("@telefono", Prof_Telefono);
                Comando.Parameters.AddWithValue("@correo", Prof_Correo);
                Comando.Parameters.AddWithValue("@direccion", Prof_Direccion);
                Comando.Parameters.AddWithValue("@sector", Prof_Sector);
                Comando.Parameters.AddWithValue("@idprovincia", ID_Provincia);
                Comando.Parameters.AddWithValue("@idgradoacdm", ID_GradoAcdm);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la inserción de datos: " + e.Message.ToString());
            }
        }
        public void ModificarProfesor(string Prof_Cedula, string Prof_Nombres, string Prof_Apellidos, string Prof_Telefono, string Prof_Direccion, string Prof_Sector, int ID_Escuela)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Profesores");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "U");
                Comando.Parameters.AddWithValue("@cedula", Prof_Cedula);
                Comando.Parameters.AddWithValue("@nombres", Prof_Nombres);
                Comando.Parameters.AddWithValue("@apellidos", Prof_Apellidos);
                Comando.Parameters.AddWithValue("@telefono", Prof_Telefono);
                Comando.Parameters.AddWithValue("@direccion", Prof_Direccion);
                Comando.Parameters.AddWithValue("@sector", Prof_Sector);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la modificación de datos: " + e.Message.ToString(), "Error de modificación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
         }
        public void InactivarProfesor(string Prof_Cedula, string Prof_Nombres, string Prof_Apellidos, string Prof_Telefono, string Prof_Direccion, string Prof_Sector, int ID_Escuela)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Profesores");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "D");
                Comando.Parameters.AddWithValue("@cedula", Prof_Cedula);
                Comando.Parameters.AddWithValue("@nombres", Prof_Nombres);
                Comando.Parameters.AddWithValue("@apellidos", Prof_Apellidos);
                Comando.Parameters.AddWithValue("@telefono", Prof_Telefono);
                Comando.Parameters.AddWithValue("@direccion", Prof_Direccion);
                Comando.Parameters.AddWithValue("@sector", Prof_Sector);
                Comando.Parameters.AddWithValue("@idescuela", ID_Escuela);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la inactivación de datos: " + e.Message.ToString(), "Error de modificación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        public DataTable ProfesorConcatenacion()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conectar.AbrirConexion();
            Comando.CommandText = "ConcatenacionProfesores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

    }
}
