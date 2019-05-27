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
using Sistema_Gestión_Aula_EduSmart.Capa_Presentación;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_Estudiantes : Form
    {
        FRM_Modificar ObjModificar = new FRM_Modificar();
        clEstudiantes objEstudiantes = new clEstudiantes();
        clValidacion Validar = new clValidacion();
        clCancelar Cancelar = new clCancelar();
        clCarreras objCarreras = new clCarreras();
        
        public FRM_Estudiantes()
        {
            InitializeComponent();

            cmb_CarreraEstud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_NacionalidadEst.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ProvinciaEstud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FormatCorreo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FormatMatricula.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void FRM_Estudiantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solo_Letras(e);
        }

        private void FRM_Estudiantes_Load(object sender, EventArgs e)
        {
            cmb_CarreraEstud.DataSource = objCarreras.ListarCarreras();
            cmb_CarreraEstud.DisplayMember = "Carr_Nombre";
            cmb_CarreraEstud.ValueMember = "ID_Carrera";

            cmb_ProvinciaEstud.DataSource = objEstudiantes.ListarProvincias();
            cmb_ProvinciaEstud.DisplayMember = "Prov_Nombre";
            cmb_ProvinciaEstud.ValueMember = "ID_Provincia";

            cmb_NacionalidadEst.DataSource = objEstudiantes.ListarNacionalidades();
            cmb_NacionalidadEst.DisplayMember = "Nac_Nombre";
            cmb_NacionalidadEst.ValueMember = "ID_Nacionalidad";

            data_RegistroEst.DataSource = objEstudiantes.ListarEstudiantes();
        }

        private void cmb_FormatMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N1, N2;
            Random ObjRandom = new Random();
            N1 = ObjRandom.Next(00, 18);
            N2 = ObjRandom.Next(1111, 9999);
            
            if(cmb_FormatMatricula.Text == "00-0000")
            {
                txt_MatrículaEstud.Text = Convert.ToString(N1 + "-" + N2);
            }
            else if(cmb_FormatMatricula.Text == "0-00-0000")
            {
                txt_MatrículaEstud.Text = Convert.ToString(N1 + "-" + N1 + "-" + N2);
            }
        }
        string Genero;
        private void rb_Fem_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "F";
        }

        private void rb_Masc_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "M";
        }
        private void Insertar()
        {
            objEstudiantes.InsertarEstudiantes(Convert.ToInt16(cmb_NacionalidadEst.SelectedValue), Convert.ToInt16(cmb_CarreraEstud.SelectedValue),
            Convert.ToInt16(cmb_ProvinciaEstud.SelectedValue), txt_CedulaEstud.Text, txt_MatrículaEstud.Text, txt_NombresEstud.Text, txt_ApellidosEstud.Text,
            txt_TeléfonoEstud.Text, txt_CorreoEstud.Text, Genero, txt_DirecciónEstud.Text, txt_SectorEstud.Text);
        }

        private void btn_RegistroEst_Click_1(object sender, EventArgs e)
        {
            bool exist = data_RegistroEst.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Est_Cedula"].Value) == txt_CedulaEstud.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
                txt_ApellidosEstud.Text = "";
                txt_CedulaEstud.Text = "";
                txt_CorreoEstud.Text = "";
                txt_DirecciónEstud.Text = "";
                txt_MatrículaEstud.Text = "";
                txt_NombresEstud.Text = "";
                txt_SectorEstud.Text = "";
                txt_TeléfonoEstud.Text = "";
                cmb_CarreraEstud.Text = "";
                cmb_FormatCorreo.Text = "";
                cmb_FormatMatricula.Text = "";
                cmb_NacionalidadEst.Text = "";
                cmb_ProvinciaEstud.Text = "";
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }
            data_RegistroEst.DataSource = objEstudiantes.ListarEstudiantes();
        }

        private void cmb_FormatCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Inicial_Nombre = txt_NombresEstud.Text, Inicial_Apellido = txt_ApellidosEstud.Text, 
                Inic_Nombre = Inicial_Nombre.Substring(0, 1), Inic_Apellido = Inicial_Apellido.Substring(0,1), uni = "@unphu.edu.do", uni2 = "@365.unphu.edu.do";
            int N1, N2;
            Random ObjRandom = new Random();
            N1 = ObjRandom.Next(00, 18);
            N2 = ObjRandom.Next(1111, 9999);
            if(cmb_FormatCorreo.Text == "aa00-0000@univ.edu.do")
            {
                txt_CorreoEstud.Text = Inic_Nombre.ToLower() + Inic_Apellido.ToLower() + txt_MatrículaEstud.Text + uni;
            }
            else if(cmb_FormatCorreo.Text == "aa00-0000@365.univ.edu.do")
            {
                txt_CorreoEstud.Text = Inic_Nombre.ToLower() + Inic_Apellido.ToLower() + txt_MatrículaEstud.Text + uni2;
            }
        }

        private void btn_CancelarEst_Click_1(object sender, EventArgs e) => Close();

        private void btn_ModificarEst_Click(object sender, EventArgs e)
        {
            ObjModificar.Show();
        }
    }
}
