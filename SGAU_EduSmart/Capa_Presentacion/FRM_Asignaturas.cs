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
    public partial class FRM_Asignaturas : Form
    {
        clFacultades ObjFacultades = new clFacultades();
        clProfesores ObjProfesores = new clProfesores();
        clAsignaturas ObjAsignaturas = new clAsignaturas();

        public FRM_Asignaturas()
        {
            InitializeComponent();
            cmb_MaestroAsignt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_GrupoAsignt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Facultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Creditos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FormatCodigo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EscuelaAsignt.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FRM_Asignaturas_Load(object sender, EventArgs e)
        {
            cmb_MaestroAsignt.DataSource = ObjProfesores.Concatenacion();
            cmb_MaestroAsignt.DisplayMember = "NombreCompletoProf";
            cmb_MaestroAsignt.ValueMember = "NombreCompletoProf";

            cmb_Facultad.DataSource = ObjFacultades.ListarFacultades();
            cmb_Facultad.DisplayMember = "Fac_Nombre";
            cmb_Facultad.ValueMember = "ID_Facultad";

            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Insertar()
        {
            //ObjAsignaturas.InsertarAsignatura(Convert.ToInt16(cmb_MaestroAsignt.SelectedValue), Convert.ToInt16(cmb_Facultad.SelectedValue), txt_NombreAsignt.Text,
            //    txt_CodigoAsignt.Text, cmb_Creditos.Text);
        }

        private void btn_RegistroAsignt_Click(object sender, EventArgs e)
        {
            bool exist = data_RegistroMat.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Nombre_Asignatura"].Value) == txt_NombreAsignt.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }


            //ObjAsignaturas.InsertarAsignatura(Convert.ToInt16(cmb_CarreraAsignt.SelectedValue),Convert.ToInt16(cmb_MaestroAsignt.SelectedValue), txt_NombreAsignt.Text, txt_CodigoAsignt.Text,  
            //    Convert.ToInt16(cmb_Creditos.SelectedValue), 
        }

        private void cmb_FormatCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N1;
            Random ObjRandom = new Random();
            N1 = ObjRandom.Next(000, 999);
            if (cmb_FormatCodigo.Text == "AAA-000-00")
            {

            }
        }

        private void btn_CancelarAsignt_Click(object sender, EventArgs e) => Close();
    }
}
