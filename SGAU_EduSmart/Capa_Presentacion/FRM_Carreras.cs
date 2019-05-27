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
    public partial class FRM_Carreras : Form
    {
        CNCarreras ObjNCarrera = new CNCarreras();
        CNFacultades ObjNFacultad = new CNFacultades();
        CNEscuelas ObjNEscuela = new CNEscuelas();
        FRM_Profesores ObjProfesor = new FRM_Profesores();

        public FRM_Carreras()
        {
            InitializeComponent();
            cmb_FacultadCarr.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EscuelaCarr.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Insertar()
        {
            ObjNCarrera.InsertarCarrera(Convert.ToInt16(cmb_FacultadCarr.SelectedValue), Convert.ToInt16(cmb_EscuelaCarr.SelectedValue), txt_NombreCarr.Text);
        }

        private void btn_RegistroCarr_Click(object sender, EventArgs e)
        {
            bool exist = data_RegistroCarr.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Nombre"].Value) == txt_NombreCarr.Text);

            if (!exist)
            {
                Insertar();
                MessageBox.Show("Registro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Este registro ya existe, favor de intentar nuevamente.", "Error de inserción de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            data_RegistroCarr.DataSource = ObjNCarrera.MostrarTodasCarreras();
        }

        private void FRM_Carreras_Load(object sender, EventArgs e)
        {
            cmb_FacultadCarr.DataSource = ObjNFacultad.MostrarFacultades();
            cmb_FacultadCarr.DisplayMember = "Nombre";
            cmb_FacultadCarr.ValueMember = "ID_Facultad";

            cmb_EscuelaCarr.DataSource = ObjNEscuela.MostrarEscuelas();
            cmb_EscuelaCarr.DisplayMember = "Escuela";
            cmb_EscuelaCarr.ValueMember = "ID_Escuela";

            data_RegistroCarr.DataSource = ObjNCarrera.MostrarTodasCarreras();
        }

        private void icono_cerrar_form_Click(object sender, EventArgs e) => Close();

        private void btn_ModificarCarr_Click(object sender, EventArgs e)
        {
            data_RegistroCarr[1, ObjProfesor.Tabla_Posicion].Value = cmb_EscuelaCarr.Text;
            data_RegistroCarr[2, ObjProfesor.Tabla_Posicion].Value = cmb_FacultadCarr.Text;
            data_RegistroCarr[3, ObjProfesor.Tabla_Posicion].Value = txt_NombreCarr.Text;
        }

        private void btn_CancelarCarr_Click(object sender, EventArgs e) => Close();

        private void data_RegistroCarr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjProfesor.Tabla_Posicion = data_RegistroCarr.CurrentRow.Index;
            cmb_EscuelaCarr.Text = data_RegistroCarr[1, ObjProfesor.Tabla_Posicion].Value.ToString();
            cmb_FacultadCarr.Text = data_RegistroCarr[2, ObjProfesor.Tabla_Posicion].Value.ToString();
            txt_NombreCarr.Text = data_RegistroCarr[3, ObjProfesor.Tabla_Posicion].Value.ToString();

        }

        private void btn_BuscarCarrera_Click(object sender, EventArgs e)
        {
            if((txt_NombreCarr.Text == "")||(cmb_EscuelaCarr.Text == "")||(cmb_FacultadCarr.Text == ""))
            {
                MessageBox.Show("Por favor,  seleccione la escuela como parámetro.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
