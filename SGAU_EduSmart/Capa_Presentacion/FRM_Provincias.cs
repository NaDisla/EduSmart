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
    public partial class FRM_Provincias : Form
    {
        clProvincias ObjProvincias = new clProvincias();

        public FRM_Provincias()
        {
            InitializeComponent();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Insertar()
        {
            ObjProvincias.InsertarProvincias(txt_NombreProv.Text);
        }

        private void FRM_Provincias_Load(object sender, EventArgs e)
        {
            data_RegistroProv.DataSource = ObjProvincias.ListarProvincias();
        }

        private void btn_RegistroProv_Click(object sender, EventArgs e)
        {
            bool exist = data_RegistroProv.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Prov_Nombre"].Value) == txt_NombreProv.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }

            data_RegistroProv.DataSource = ObjProvincias.ListarProvincias();
        }

        private void btn_CancelarProv_Click(object sender, EventArgs e) => Close();
    }
}
