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
    public partial class FRM_Carreras : Form
    {
        clCarreras objCarreras = new clCarreras();
        FRM_Modificar ObjModificar = new FRM_Modificar();

        public FRM_Carreras()
        {
            InitializeComponent();
            cmb_FacultadCarr.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Insertar()
        {
            objCarreras.InsertarCarreras(txt_NombreCarr.Text, Convert.ToInt16(cmb_FacultadCarr.SelectedValue));
        }

        private void btn_RegistroCarr_Click(object sender, EventArgs e)
        {
            bool exist = data_RegistroCarr.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Carr_Nombre"].Value) == txt_NombreCarr.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }
            data_RegistroCarr.DataSource = objCarreras.ListarCarreras();
        }

        private void FRM_Carreras_Load(object sender, EventArgs e)
        {
            cmb_FacultadCarr.DataSource = objCarreras.ListarFacultades();
            cmb_FacultadCarr.DisplayMember = "Fac_Nombre";
            cmb_FacultadCarr.ValueMember = "ID_Facultad";

            data_RegistroCarr.DataSource = objCarreras.ListarCarreras();
        }

        private void btn_ModificarCarr_Click(object sender, EventArgs e)
        {

            ObjModificar.Show();
        }

        private void btn_CancelarCarr_Click(object sender, EventArgs e) => Close();
    }
}
