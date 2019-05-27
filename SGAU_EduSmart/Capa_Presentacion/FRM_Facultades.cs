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
    public partial class FRM_Facultades : Form
    {
        clFacultades objFacultades = new clFacultades();

        public FRM_Facultades()
        {
            InitializeComponent();
        }

        private void FRM_Facultades_Load(object sender, EventArgs e)
        {
            ListarFacultades();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }
        
        private void Insertar()
        {
            objFacultades.InsertarFacultades(txt_NombreFac.Text);
        }

        private void btn_RegistroFac_Click(object sender, EventArgs e)
        {
            bool exist = data_RegistroFac.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Fac_Nombre"].Value) == txt_NombreFac.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.");
            }
            ListarFacultades();
        }

        private void ListarFacultades()
        {
            data_RegistroFac.DataSource = objFacultades.ListarFacultades();
        }

        private void btn_CancelarFac_Click(object sender, EventArgs e) => Close();
    }
}
