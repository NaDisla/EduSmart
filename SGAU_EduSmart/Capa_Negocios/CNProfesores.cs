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
    public class CNProfesores
    {
        CDProfesores ObjProfesor = new CDProfesores();

        public void ConsultarProfesor(string ID_Profesor, int ID_GradoAcdm, int ID_Escuela)
        {
            ObjProfesor.ConsultarProfesor(ID_Profesor, ID_GradoAcdm, ID_Escuela);
        }
        public DataTable TraerProfesores(int ID_Profesor, int ID_GradoAcdm, int ID_Escuela)
        {
            DataTable DTProfesores;
            DTProfesores = ObjProfesor.TraerConsultaProfesores(ID_Profesor, ID_Escuela, ID_GradoAcdm);
            return DTProfesores;
        }
        public void InsertarProfesor(string Prof_Cedula, string Prof_Nombres, string Prof_Apellidos, string Prof_Telefono, string Prof_Correo,
           string Prof_Direccion, string Prof_Sector, int ID_Provincia, int ID_GradoAcdm, int ID_Escuela)
        { 
            ObjProfesor.InsertarProfesor(Prof_Cedula, Prof_Nombres, Prof_Apellidos, Prof_Telefono, Prof_Correo, Prof_Direccion, Prof_Sector, ID_Provincia, ID_GradoAcdm, ID_Escuela);
        }
        public void ModificarProfesor(string Prof_Cedula, string Prof_Nombres, string Prof_Apellidos, string Prof_Telefono, string Prof_Direccion, string Prof_Sector, int ID_Escuela)
        {
            ObjProfesor.ModificarProfesor(Prof_Cedula, Prof_Nombres, Prof_Apellidos, Prof_Telefono, Prof_Direccion, Prof_Sector, ID_Escuela);
        }
        public void EliminarProfesor(string Prof_Cedula, string Prof_Nombres, string Prof_Apellidos, string Prof_Telefono, string Prof_Direccion, string Prof_Sector, int ID_Escuela)
        {
            ObjProfesor.InactivarProfesor(Prof_Cedula, Prof_Nombres, Prof_Apellidos, Prof_Telefono, Prof_Direccion, Prof_Sector, ID_Escuela);
        }
        public DataTable MostrarTodosProfesores()
        {
            DataTable DTProfesor;
            DTProfesor = ObjProfesor.MostrarProfesores();
            return DTProfesor;
        }
        public DataTable ProfesorConcatenacion()
        {
            DataTable DTConcatenarProf;
            DTConcatenarProf = ObjProfesor.ProfesorConcatenacion();
            return DTConcatenarProf;
        }
    }
}
