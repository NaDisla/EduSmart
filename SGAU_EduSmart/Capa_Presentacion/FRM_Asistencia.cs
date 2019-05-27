using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Gestión_Aula_EduSmart.Capa_Datos;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_Asistencia : Form
    {
        clAsistencia ObjAsistencia = new clAsistencia();

        public FRM_Asistencia()
        {
            InitializeComponent();
            lb_FechaAisstencia.Text = DateTime.Now.ToShortDateString();
        }

        private void FRM_Asistencia_Load(object sender, EventArgs e)
        {
            lb_FechaAisstencia.Text = DateTime.Now.ToShortDateString();
            txt_Prof.Text = FRM_Acceso_Profesores.NombreCompleto;
            data_AsistenciaEstud.DataSource = ObjAsistencia.ListarAsistencia();
        }
    }
}
