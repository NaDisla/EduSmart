using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Sistema_Gestión_Aula_EduSmart.Capa_Datos;
using Sistema_Gestión_Aula_EduSmart.Capa_Presentación;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_Profesores : Form
    {
        clValidacion Validar = new clValidacion();
        clProfesores objProfesor = new clProfesores();
        clEstudiantes objEstudiantes = new clEstudiantes();
        clCancelar Cancelar = new clCancelar();

        public FRM_Profesores()
        {
            InitializeComponent();
            cmb_GradoAcdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ProvinciaProf.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
            cmb_FormatCorreo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_NombresProf_KeyPress(object sender, KeyPressEventArgs e)
        {
             Validar.Solo_Letras(e);
        }

        private void FRM_Profesores_Load(object sender, EventArgs e)
        {
            cmb_ProvinciaProf.DataSource = objEstudiantes.ListarProvincias();
            cmb_ProvinciaProf.DisplayMember = "Prov_Nombre";
            cmb_ProvinciaProf.ValueMember = "ID_Provincia";

            cmb_GradoAcdm.DataSource = objProfesor.ListarGradosAcademicos();
            cmb_GradoAcdm.DisplayMember = "GradoAcdm_Nombre";
            cmb_GradoAcdm.ValueMember = "ID_GradoAcdm";

            data_RegistroProf.DataSource = objProfesor.ListarProfesores();
        }

        private void Insertar()
        {
            objProfesor.InsertarProfesor(txt_CedulaProf.Text, txt_NombresProf.Text, txt_ApellidosProf.Text, txt_TelefonoProf.Text, txt_CorreoProf.Text,
            txt_DireccionProf.Text, txt_SectorProf.Text, Convert.ToInt16(cmb_ProvinciaProf.SelectedValue), Convert.ToInt16(cmb_GradoAcdm.SelectedValue));
        }

        private void btn_RegistroProf_Click(object sender, EventArgs e)
        {
            bool exist = data_RegistroProf.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Prof_Cedula"].Value) == txt_CedulaProf.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
                txt_ApellidosProf.Text = "";
                txt_CedulaProf.Text = "";
                txt_CorreoProf.Text = "";
                txt_NombresProf.Text = "";
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }
            data_RegistroProf.DataSource = objProfesor.ListarProfesores();
        }

        private void btn_CancelarProf_Click(object sender, EventArgs e) => Close();

        private void btn_ModificarProf_Click(object sender, EventArgs e)
        {
            FRM_Modificar ObjModificar = new FRM_Modificar();

            ObjModificar.Show();
        }

        private void cmb_FormatCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Inicial_Nombre = txt_NombresProf.Text, Inicial_Apellido = txt_ApellidosProf.Text,
                Inic_Nombre = Inicial_Nombre.Substring(0, 1), Inic_Apellido = Inicial_Apellido.Substring(0, 1), uni = "@unphu.edu.do";
            int N1;
            Random ObjRandom = new Random();
            N1 = ObjRandom.Next(1111, 9999);
            if (cmb_FormatCorreo.Text == "aa0000@univ.edu.do")
            {
                txt_CorreoProf.Text = Inic_Nombre.ToLower() + Inic_Apellido.ToLower() + N1 + uni;
            }
            else if (cmb_FormatCorreo.Text == "napellido@univ.edu.do")
            {
                txt_CorreoProf.Text = Inic_Nombre.ToLower() + txt_ApellidosProf.Text + uni;
            }
        }
    }
 }
