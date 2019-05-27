using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_Periodos : Form
    {
        public FRM_Periodos()
        {
            InitializeComponent();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
            cmb_FormatDescrip.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmb_FormatDescrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime ObjFecha = new DateTime();

            string MesInicio=date_FechaInicio.Text, MesFin=date_FechaFin.Text, MesInicioComp = MesInicio.Substring(0,3), MesFinComp = MesFin.Substring(0,3);

            if (cmb_FormatDescrip.Text == "3 meses (MES-MES-AÑO)")
            {
                txt_DescPeriodo.Text = ObjFecha.Month.ToString();
            }

            Random ObjRandom = new Random();
        }

        private void btn_CancelarAsignt_Click(object sender, EventArgs e) => Close();
    }
}
