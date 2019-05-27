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
    public partial class FRM_Escuelas : Form
    {
        clFacultades ObjFacultades = new clFacultades();
        clProfesores ObjProfesores = new clProfesores();

        public FRM_Escuelas()
        {
            InitializeComponent();
            cmb_Facultad.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void FRM_Escuelas_Load(object sender, EventArgs e)
        {
            cmb_Facultad.DataSource = ObjFacultades.ListarFacultades();
            cmb_Facultad.DisplayMember = "Fac_Nombre";
            cmb_Facultad.ValueMember = "ID_Facultad";
        }

        private void btn_CancelarEscuela_Click(object sender, EventArgs e) => Close();
    }
}
