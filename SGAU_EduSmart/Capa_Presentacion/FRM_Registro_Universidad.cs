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
    public partial class FRM_Registro_Universidad : Form
    {
        clValidacion Validar = new clValidacion();
        clCancelar Cancelar = new clCancelar();
        clEstudiantes ObjEstudiantes = new clEstudiantes();
        clDistritos ObjDistritos = new clDistritos();

        public FRM_Registro_Universidad()
        {
            InitializeComponent();
            cmb_DistritoEdu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_DíasLabUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_GestiónUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PeríodoUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ProvinciaUni.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_RegistroUni_Click(object sender, EventArgs e)
        {
            FRM_Acceso_Sistema AccesoFRM = new FRM_Acceso_Sistema();
            AccesoFRM.Visible = true;
            Visible = false;
        }

        private void icono_cerrar_RegistroUni_Click(object sender, EventArgs e) => Application.Exit();

        private void txt_NombreUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solo_Letras(e);
        }

        private void txt_RectorUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solo_Letras(e);
        }

        private void btn_CancelarUni_Click(object sender, EventArgs e)
        {
            Cancelar.BorrarCampos(this);
        }

        private void txt_SectorUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solo_Letras(e);
        }

        private void btn_ExaminarFoto_Click(object sender, EventArgs e)
        {
            //Se crea el OpenFileDialog:
            OpenFileDialog ObtenerImagen = new OpenFileDialog();

            //Se pone el directorio donde se encuentran las imágenes:
            ObtenerImagen.InitialDirectory = "C:\\";
            
            //Filtro para mostrar archivos de imagen:
            ObtenerImagen.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if(ObtenerImagen.ShowDialog()==DialogResult.OK)
            {
                imgLogoUni.ImageLocation = ObtenerImagen.FileName;
            }
            else
            {
                MessageBox.Show("Error","Hubo un error al subir la imagen",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pnRegistroUni_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void titleRegistroUni_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FRM_Registro_Universidad_Load(object sender, EventArgs e)
        {
            cmb_ProvinciaUni.DataSource = ObjEstudiantes.ListarProvincias();
            cmb_ProvinciaUni.DisplayMember = "Prov_Nombre";
            cmb_ProvinciaUni.ValueMember = "ID_Provincia";

            cmb_DistritoEdu.DataSource = ObjDistritos.ListarDistritos();
            cmb_DistritoEdu.DisplayMember = "Distr_Nombre";
            cmb_DistritoEdu.ValueMember = "ID_Distrito";
        }
    }
}
