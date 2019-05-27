using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocios
{
    public class CNUsuario
    {
        CDUsuario ObjUsuario = new CDUsuario();
        public String PUsuario, PClave;

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Logueo;
            Logueo = ObjUsuario.Iniciar_Sesion(PUsuario, PClave);

            return Logueo;
        }
        public void AgregarUsuario(byte[] Usu_Nombre, byte[] Usu_Clave, string Usu_Nombres, string Usu_Apellidos, byte[] Usu_ConfirmarClave, string Usu_Rol)
        {
            ObjUsuario.InsertarUsuario(Usu_Nombre, Usu_Clave, Usu_Nombres, Usu_Apellidos, Usu_ConfirmarClave, Usu_Rol);
        }

    }
}
