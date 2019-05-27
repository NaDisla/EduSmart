using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class FRM_Practicas : Form
    {
        FRM_Acceso_Profesores objAccesoProf = new FRM_Acceso_Profesores();
        public FRM_Practicas()
        {
            InitializeComponent();
            cmb_Asignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PenalidadPractica.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ValorPractica.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void icono_cerrar_form_Click(object sender, EventArgs e) => Close();

        private void FRM_Practicas_Load(object sender, EventArgs e)
        {
            txt_Prof.Text = FRM_Acceso_Profesores.Maestro;
            txt_Asignatura.Text = FRM_Acceso_Profesores.Materia;
            txt_CodigoSecc.Text = FRM_Acceso_Profesores.Codigo;
        }

        private void btn_CancelarFac_Click(object sender, EventArgs e) => Close();
    }
}
