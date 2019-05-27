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
    public class CNAsignaturas
    {
        CDAsignaturas ObjAsignatura = new CDAsignaturas();

        public DataTable MostrarMaterias()
        {
            DataTable DTMatrias;
            DTMatrias = ObjAsignatura.MostrarAsignaturas();
            return DTMatrias;
        }

        public void InsertarMateria(int ID_Facultad, int ID_Escuela, string Asignt_Nombre, string Asignt_Codigo, int Asignt_Creditos, int Asignt_HorasPract, int Asignt_HorasTeor, 
            int Asignt_TotalHoras, int Asignt_BloquePensum)
        {
            ObjAsignatura.InsertarAsignatura(ID_Facultad, ID_Escuela, Asignt_Nombre, Asignt_Codigo, Asignt_Creditos, Asignt_HorasPract, Asignt_HorasTeor, Asignt_TotalHoras, 
                Asignt_BloquePensum);
        }

        public void ModificarMateria(int ID_Facultad, int ID_Escuela, string Asignt_Nombre, string Asignt_Codigo, int Asignt_HorasPract, int Asignt_HorasTeor, int Asignt_TotalHoras)
        {
            ObjAsignatura.ModificarAsignatura(ID_Facultad, ID_Escuela, Asignt_Nombre, Asignt_Codigo, Asignt_HorasPract, Asignt_HorasTeor, Asignt_TotalHoras);
        }
    }
}
