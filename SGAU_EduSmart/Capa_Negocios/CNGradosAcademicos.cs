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
    public class CNGradosAcademicos
    {
        CDGradosAcademicos ObjGrado = new CDGradosAcademicos();

        public DataTable ListaDeGrados()
        {
            DataTable DTGrados;
            DTGrados = ObjGrado.MostrarGrados();
            return DTGrados;
        }

        public void InsertarGradoAcademico(string GradoAcdm_Nombre)
        {
            ObjGrado.InsertarGradoAcademico(GradoAcdm_Nombre);
        }
        public void ModificarGradoAcademico(string GradoAcdm_Nombre)
        {
            ObjGrado.ModificarGradoAcademico(GradoAcdm_Nombre);
        }
    }
}
