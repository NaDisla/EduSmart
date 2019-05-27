using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CDDistritos
    {
        SqlConnection CON = new SqlConnection();
        public void InsertarDistrito(string Distr_Nombre, ref bool ResultadoOk, ref string MensajeError)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("SIUD_Distritos", CON);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Control", "I");
                Comando.Parameters.AddWithValue("@nombre", Distr_Nombre);
                CON.Open();
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception e)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un error consultando los datos. " + e.Message.ToString();
            }
            finally
            {
                CON.Close();
            }
        }
    }
}
