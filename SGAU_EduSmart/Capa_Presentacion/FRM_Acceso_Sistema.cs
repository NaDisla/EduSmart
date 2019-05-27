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
    public partial class FRM_Acceso_Sistema : Form
    {
        clCancelar Cancelar = new clCancelar();
        FRM_Usuarios ObjUsuarios = new FRM_Usuarios();

        public FRM_Acceso_Sistema()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pn_Título_Acceso_Colegio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void icono_cerrar_AccesoES_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_CancelarAcceso_Click(object sender, EventArgs e)
        {
            Cancelar.BorrarCampos(this);
        }

        private void btn_IngresoSistema_Click(object sender, EventArgs e)
        {
            if ((txt_User.Text == "admin") && (txt_Password.Text == "1234"))
            {
                FRM_EduSmart_Trabajo ES_Trabajo = new FRM_EduSmart_Trabajo();
                ES_Trabajo.Visible = true;
                Visible = false;
                MessageBox.Show("Bienvenido " + txt_User.Text + ", ha ingresado a EduSmart");
            }
            else if ((txt_User.Text == "Profesor") && (txt_Password.Text == "6578"))
            {
                FRM_Acceso_Profesores ES_AccesoProf = new FRM_Acceso_Profesores();
                ES_AccesoProf.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("Datos erróneos, por favor inténtelo nuevamente");
            }
        }

        private void link_Usuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ObjUsuarios.Show();
        }
    }
}
