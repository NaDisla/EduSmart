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
using Sistema_Gestión_Aula_EduSmart.Capa_Datos;

namespace Sistema_Gestión_Aula_EduSmart
{
    public partial class FRM_Acceso_Profesores : Form
    {
        FRM_EduSmart_Trabajo_Profesores ObjTrabajoProfesores = new FRM_EduSmart_Trabajo_Profesores();
        clFacultades objFacultades = new clFacultades();
        clCarreras objCarreras = new clCarreras();
        clProfesores ObjProfesor = new clProfesores();

        public static string NombreCompleto;

        public FRM_Acceso_Profesores()
        {
            InitializeComponent();
            cmb_AsignaturaACS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_CodigoAsigntACS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_GrupoAsigntACS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PeriodoACS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ProfesorACS.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pn_TituloAcceso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void icono_cerrar_AccesoES_Click(object sender, EventArgs e) => Application.Exit();

        private void lbTituloAcceso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FRM_Acceso_Profesores_Load(object sender, EventArgs e)
        {
            cmb_ProfesorACS.DataSource = ObjProfesor.Concatenacion();
            cmb_ProfesorACS.DisplayMember = "NombreCompletoProf";
            cmb_ProfesorACS.ValueMember = "NombreCompletoProf";
        }

        private void btn_IngresoSistemaProf_Click(object sender, EventArgs e)
        {
            ObjTrabajoProfesores.Visible = true;
            Visible = false;
            NombreCompleto = cmb_ProfesorACS.Text;
        }

        private void cmb_ProfesorACS_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
