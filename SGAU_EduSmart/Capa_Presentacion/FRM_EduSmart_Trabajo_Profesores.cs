using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sistema_Gestión_Aula_EduSmart.Capa_Presentación;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_EduSmart_Trabajo_Profesores : Form
    {
        FRM_Acceso_Sistema ObjAcceso = new FRM_Acceso_Sistema();

        int LX, LY;

        public FRM_EduSmart_Trabajo_Profesores()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void icono_cerrar_Click_1(object sender, EventArgs e) => Application.Exit();

        private void icono_max_Click_1(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            icono_restaurar.Visible = true;
            icono_max.Visible = false;
        }

        private void icono_restaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1040, 544);
            this.Location = new Point(LX, LY);
            icono_restaurar.Visible = false;
            icono_max.Visible = true;
        }

        private void icono_minimizar_Click_1(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void pn_Título_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Abrir_Formulario_Panel(object FRM_Hijo)
        {
            if (this.pn_Contenedor.Controls.Count > 0)
            {
                this.pn_Contenedor.Controls.RemoveAt(0);
            }
            Form FHijo = FRM_Hijo as Form;
            FHijo.TopLevel = false;
            FHijo.Dock = DockStyle.Fill;
            this.pn_Contenedor.Controls.Add(FHijo);
            this.pn_Contenedor.Tag = FHijo;
            FHijo.Show();
        }

        private void btn_ConsultaEstProf_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_Panel(new FRM_Consulta_Estudiantes());
            label1.Text = "Consulta de Estudiantes - EduSmart";
        }

        private void btn_ReportesProf_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_Panel(new FRM_Reportes());
            label1.Text = "Impresión de Reportes - EduSmart";
        }

        private void btn_Regreso_Click(object sender, EventArgs e)
        {
            ObjAcceso.Visible = true;
            Visible = false;
        }

        private void btn_AsistenciaProf_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_Panel(new FRM_Asistencia());
            label1.Text = "Listado de Asistencia - EduSmart";
        }

        private void btn_PracticasProf_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_Panel(new FRM_Practicas());
            label1.Text = "Mantenimiento de Prácticas - EduSmart";
        }
    }
}
