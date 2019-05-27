using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestión_Aula_EduSmart.Capa_Presentación
{
    public partial class FRM_Reportes : Form
    {
        public FRM_Reportes()
        {
            InitializeComponent();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void FRM_Reportes_Load(object sender, EventArgs e)
        {
            txt_Prof.Text = FRM_Acceso_Profesores.NombreCompleto;
        }
    }
}
