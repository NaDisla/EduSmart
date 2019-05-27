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
    public class CDEstudiantes
    {
        clConexion Conectar = new clConexion();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;

        public DataTable ListarEstudiantesTotal()
        {
            DataTable Tabla = new DataTable();
            SqlCommand CMDLista= new SqlCommand("SIUD_Estudiantes");
            CMDLista.CommandType = CommandType.StoredProcedure;
            CMDLista.Connection = Conectar.AbrirConexion();
            CMDLista.Parameters.AddWithValue("@Control", "S");
            LeerFilas = CMDLista.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }

        public void ConsultarEstudiante(string Est_Codigo)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Estudiantes");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "S");
                Comando.Parameters.AddWithValue("@id", Est_Codigo);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la consulta de datos: " + e.Message.ToString(), "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertarEstudiante(string Est_Cedula, string Est_Matricula, string Est_Nombres, string Est_Apellidos, int ID_Nacionalidad, int ID_Carrera, string Est_Telefono, string Est_Genero,
           string Est_CorreoInst, string Est_Direccion, string Est_Sector, int ID_Provincia)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Estudiantes");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@cedula", Est_Cedula);
                Comando.Parameters.AddWithValue("@matricula", Est_Matricula);
                Comando.Parameters.AddWithValue("@nombres", Est_Nombres);
                Comando.Parameters.AddWithValue("@apellidos", Est_Apellidos);
                Comando.Parameters.AddWithValue("@idnacionalidad", ID_Nacionalidad);
                Comando.Parameters.AddWithValue("@idcarrera", ID_Carrera);
                Comando.Parameters.AddWithValue("@telefono", Est_Telefono);
                Comando.Parameters.AddWithValue("@genero", Est_Genero);
                Comando.Parameters.AddWithValue("@correoinst", Est_CorreoInst);
                Comando.Parameters.AddWithValue("@direccion", Est_Direccion);
                Comando.Parameters.AddWithValue("@sector", Est_Sector);
                Comando.Parameters.AddWithValue("@idprovincia", ID_Provincia);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la inserción de datos: " + e.Message.ToString());
            }
        }
        public void ModificarEstudiante(int ID_Carrera, int ID_Provincia, string Est_Nombres, string Est_Apellidos, string Est_Telefono, string Est_Direccion, string Est_Sector)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Estudiantes");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = Conectar.AbrirConexion();
                Comando.Parameters.AddWithValue("@Control", "U");
                Comando.Parameters.AddWithValue("@idcarrera", ID_Carrera);
                Comando.Parameters.AddWithValue("@idprovincia", ID_Provincia);
                Comando.Parameters.AddWithValue("@nombres", Est_Nombres);
                Comando.Parameters.AddWithValue("@apellidos", Est_Apellidos);
                Comando.Parameters.AddWithValue("@telefono", Est_Telefono);
                Comando.Parameters.AddWithValue("@direccion", Est_Direccion);
                Comando.Parameters.AddWithValue("@sector", Est_Sector);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error durante la inserción de datos: " + e.Message.ToString());
            }
        }
        public DataTable ListarEstudiantes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conectar.AbrirConexion();
            Comando.CommandText = "ConcatenacionEstudiantes";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conectar.CerrarConexion();
            return Tabla;
        }
    }
}
