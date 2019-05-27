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

namespace Sistema_Gestión_Aula_EduSmart.Capa_Presentación
{
    public partial class FRM_Nacionalidades : Form
    {
        clEstudiantes ObjEstudiantes = new clEstudiantes();

        public FRM_Nacionalidades()
        {
            InitializeComponent();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void FRM_Nacionalidades_Load(object sender, EventArgs e)
        {
            data_RegistroNac.DataSource = ObjEstudiantes.ListarNacionalidades();
        }

        private void btn_CancelarProv_Click(object sender, EventArgs e) => Close();
    }
}
