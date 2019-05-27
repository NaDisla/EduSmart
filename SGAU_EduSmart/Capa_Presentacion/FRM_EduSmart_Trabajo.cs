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
    public partial class FRM_EduSmart_Trabajo : Form
    {
        FRM_Acceso_Sistema ObjAcceso = new FRM_Acceso_Sistema();

        public FRM_EduSmart_Trabajo()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void icono_minimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        int LX, LY;
        private void icono_restaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1060, 576);
            this.Location = new Point(LX, LY);
            icono_restaurar.Visible = false;
            icono_maximizar.Visible = true;
        }

        private void icono_maximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            icono_restaurar.Visible = true;
            icono_maximizar.Visible = false;
        }

        private void icono_cerrar_Click_1(object sender, EventArgs e) => Application.Exit();

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

        private void Abrir_Formulario_En_Panel(object Form_Hijo)
        {
            if (this.pn_Contenedor.Controls.Count > 0)
            {
                this.pn_Contenedor.Controls.RemoveAt(0);
            }

            Form FH = Form_Hijo as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.pn_Contenedor.Controls.Add(FH);
            this.pn_Contenedor.Tag = FH;
            FH.Show();
        }

        private void btn_Estudiantes_Click_1(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Estudiantes());
            label1.Text = "Mantenimiento de Estudiantes - EduSmart";
        }

        private void btn_Docentes_Click_1(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Profesores());
            label1.Text = "Mantenimiento de Profesores - EduSmart";
        }

        private void btn_Facultades_Click_1(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Facultades());
            label1.Text = "Mantenimiento de Facultades - EduSmart";
        }

        private void btn_Escuelas_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Escuelas());
            label1.Text = "Mantenimiento de Escuelas - EduSmart";
        }

        private void btn_Carreras_Click_1(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Carreras());
            label1.Text = "Mantenimiento de Carreras - EduSmart";
        }

        private void btn_Asignaturas_Click_1(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Asignaturas());
            label1.Text = "Mantenimiento de Asignaturas - EduSmart";
        }

        private void btn_Aulas_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Aulas());
            label1.Text = "Matenimiento de Aulas - EduSmart";
        }

        private void btn_Grados_Click_1(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Grados_Academicos());
            label1.Text = "Mantenimiento de Grados Académicos - EduSmart";
        }

        private void btn_Provincias_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Provincias());
            label1.Text = "Mantenimiento de Provincias - EduSmart";
        }

        private void btn_Periodos_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Periodos());
            label1.Text = "Mantenimiento de Períodos - EduSmart";
        }

        private void btn_Nacionalidades_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FRM_Nacionalidades());
            label1.Text = "Mantenimiento de Nacionalidades - EduSmart";
        }
        //REDIMENSIONAMIENTO:

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pn_Principal.Region = region;
            this.Invalidate();
        }
        private void btn_Regreso_Click(object sender, EventArgs e)
        {
            ObjAcceso.Visible = true;
            Visible = false;
        }









        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

    }
}
