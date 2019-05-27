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
    public class CNEstudiantes
    {
        CDEstudiantes ObjEstudiante = new CDEstudiantes();

        public void ConsultarEstudiante(string Est_Codigo)
        {
            ObjEstudiante.ConsultarEstudiante(Est_Codigo);
        }

        public void InsertarEstudiante(string Est_Cedula, string Est_Matricula, string Est_Nombres, string Est_Apellidos, int ID_Nacionalidad, int ID_Carrera, string Est_Telefono, string Est_Genero,
           string Est_CorreoInst, string Est_Direccion, string Est_Sector, int ID_Provincia)
        {
            ObjEstudiante.InsertarEstudiante(Est_Cedula, Est_Matricula, Est_Nombres, Est_Apellidos, ID_Nacionalidad, ID_Carrera, Est_Telefono, Est_Genero, Est_CorreoInst, Est_Direccion, Est_Sector, ID_Provincia);
        }
        public void ModificarEstudiante(int ID_Carrera, int ID_Provincia, string Est_Nombres, string Est_Apellidos, string Est_Telefono, string Est_Direccion, string Est_Sector)
        {
            ObjEstudiante.ModificarEstudiante(ID_Carrera, ID_Provincia, Est_Nombres, Est_Apellidos, Est_Telefono, Est_Direccion, Est_Sector);
        }
        public DataTable MostrarEstudiantes()
        {
            DataTable DTEstudiante;
            DTEstudiante = ObjEstudiante.ListarEstudiantes();
            return DTEstudiante;
        }
        public DataTable MostrarTodosEstudiantes()
        {
            DataTable DTTodos;
            DTTodos = ObjEstudiante.ListarEstudiantesTotal();
            return DTTodos;
        }
        public DataTable ConcatenacionEstudiante()
        {
            DataTable DTNombreCompleto;
            DTNombreCompleto = ObjEstudiante.ListarEstudiantes();
            return DTNombreCompleto;
        }

    }
}
