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

    public class CDUsuario
    {
        clConexion CON = new clConexion();
        SqlCommand CMD = new SqlCommand();
        SqlDataReader LeerFilas;
        private clConexion Connect = new clConexion();
        private SqlDataReader Read;
        //byte[] reader;
        //byte[] btUserName = Encoding.Unicode.GetBytes(reader["Usu_Nombre"].ToString());
        //string UserName = Encoding.Unicode.GetString(btUserName);

        public void InsertarUsuario(byte[] Usu_Nombre, byte[] Usu_Clave, string Usu_Nombres, string Usu_Apellidos, byte[] Usu_ConfirmarClave, string Usu_Rol)
        {

            try
            {
                SqlCommand Comando = new SqlCommand("InsertarUsuario");
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Connection = CON.AbrirConexion();
                Comando.Parameters.AddWithValue("@nombreusuario", Usu_Nombre);
                Comando.Parameters.AddWithValue("@clave", Usu_Clave);
                Comando.Parameters.AddWithValue("@nombres", Usu_Nombres);
                Comando.Parameters.AddWithValue("@apellidos", Usu_Apellidos);
                Comando.Parameters.AddWithValue("@confirmarclave", Usu_ConfirmarClave);
                Comando.Parameters.AddWithValue("@rol", Usu_Rol);
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

        public SqlDataReader Iniciar_Sesion(string Usuario, string Clave)
        {
            SqlCommand CMD = new SqlCommand("SP_Login",Connect.AbrirConexion());
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.Parameters.AddWithValue("@Usuario", Usuario);
            CMD.Parameters.AddWithValue("@Clave", Clave);
            Read = CMD.ExecuteReader();

            return Read;
        }
    }
}
