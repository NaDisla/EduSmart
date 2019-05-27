using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestión_Aula_EduSmart.Capa_Datos;

namespace Sistema_Gestión_Aula_EduSmart.Capa_Presentación
{
    public partial class FRM_Grados_Academicos : Form
    {
        clGradosAcademicos ObjGrados = new clGradosAcademicos();
        clProfesores ObjProfesor = new clProfesores();
    
        public FRM_Grados_Academicos()
        {
            InitializeComponent();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void FRM_Grados_Academicos_Load(object sender, EventArgs e)
        {
            data_RegistroGrados.DataSource = ObjProfesor.ListarGradosAcademicos();
            ObjProfesor.ListarGradosAcademicos();
        }

        private void Insertar()
        {
            ObjGrados.InsertarGradosAcademicos(txt_NombreGrado.Text);
        }

        private void btn_RegistroGrado_Click_1(object sender, EventArgs e)
        {
            bool exist = data_RegistroGrados.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["GradoAcdm_Nombre"].Value) == txt_NombreGrado.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }
            data_RegistroGrados.DataSource = ObjProfesor.ListarGradosAcademicos();
        }

        private void btn_CancelarGrado_Click(object sender, EventArgs e) => Close();
    }
}
