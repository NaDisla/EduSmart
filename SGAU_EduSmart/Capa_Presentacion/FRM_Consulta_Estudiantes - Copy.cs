using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestión_Aula_EduSmart.Capa_Datos;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_Consulta_Estudiantes : Form
    {
        FRM_Acceso_Profesores ObjAcceso = new FRM_Acceso_Profesores();
        clEstudiantes ObjEstudiantes = new clEstudiantes();

        public FRM_Consulta_Estudiantes()
        {
            InitializeComponent();
            cmb_Matricula.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Matricula.DataSource = ObjEstudiantes.ListarEstudiantes();
            cmb_Matricula.DisplayMember = "Est_Matricula";
            cmb_Matricula.ValueMember = "ID_Estudiante";
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void cmb_Matricula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Consulta_Estudiantes_Load(object sender, EventArgs e)
        {
            txt_Prof.Text = FRM_Acceso_Profesores.NombreCompleto;
        }
    }
}
