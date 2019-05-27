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
    public partial class FRM_Aulas : Form
    {
        public FRM_Aulas()
        {
            InitializeComponent();
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
