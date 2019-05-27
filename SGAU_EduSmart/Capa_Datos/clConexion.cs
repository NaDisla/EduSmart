using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class clConexion
    {
        /*internal string ObtenerConexion()
        {
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return conexion;
        }*/

        static private string CadenaConexion = "Data Source=.;Initial Catalog=DB_EduSmart;Integrated Security=True";
        public SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
