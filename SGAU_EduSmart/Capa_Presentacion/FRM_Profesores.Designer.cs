namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Profesores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Profesores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombresProf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApellidosProf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DireccionProf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CorreoProf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Regreso = new System.Windows.Forms.Button();
            this.btn_Registrar_prf_Colegio = new System.Windows.Forms.Button();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.txt_SectorProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CedulaProf = new System.Windows.Forms.MaskedTextBox();
            this.txt_TelefonoProf = new System.Windows.Forms.MaskedTextBox();
            this.cmb_ProvinciaProf = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_GradoAcdm = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_CancelarProf = new System.Windows.Forms.Button();
            this.btn_ModificarProf = new System.Windows.Forms.Button();
            this.btn_RegistroProf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_FormatCorreo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foto_uni = new System.Windows.Forms.PictureBox();
            this.data_RegistroProf = new System.Windows.Forms.DataGridView();
            this.btn_ImprimirRepProf = new System.Windows.Forms.Button();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroProf)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // txt_NombresProf
            // 
            this.txt_NombresProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombresProf.ForeColor = System.Drawing.Color.Black;
            this.txt_NombresProf.Location = new System.Drawing.Point(96, 36);
            this.txt_NombresProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NombresProf.MaxLength = 30;
            this.txt_NombresProf.Name = "txt_NombresProf";
            this.txt_NombresProf.Size = new System.Drawing.Size(251, 23);
            this.txt_NombresProf.TabIndex = 4;
            this.txt_NombresProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombresProf_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(478, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos:";
            // 
            // txt_ApellidosProf
            // 
            this.txt_ApellidosProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApellidosProf.ForeColor = System.Drawing.Color.Black;
            this.txt_ApellidosProf.Location = new System.Drawing.Point(572, 38);
            this.txt_ApellidosProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ApellidosProf.MaxLength = 30;
            this.txt_ApellidosProf.Name = "txt_ApellidosProf";
            this.txt_ApellidosProf.Size = new System.Drawing.Size(285, 23);
            this.txt_ApellidosProf.TabIndex = 6;
            this.txt_ApellidosProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombresProf_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cédula:";
            // 
            // txt_DireccionProf
            // 
            this.txt_DireccionProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DireccionProf.ForeColor = System.Drawing.Color.Black;
            this.txt_DireccionProf.Location = new System.Drawing.Point(407, 76);
            this.txt_DireccionProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DireccionProf.MaxLength = 30;
            this.txt_DireccionProf.Name = "txt_DireccionProf";
            this.txt_DireccionProf.Size = new System.Drawing.Size(450, 23);
            this.txt_DireccionProf.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(320, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Teléfono:";
            // 
            // txt_CorreoProf
            // 
            this.txt_CorreoProf.Enabled = false;
            this.txt_CorreoProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CorreoProf.ForeColor = System.Drawing.Color.Black;
            this.txt_CorreoProf.Location = new System.Drawing.Point(166, 77);
            this.txt_CorreoProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CorreoProf.MaxLength = 40;
            this.txt_CorreoProf.Name = "txt_CorreoProf";
            this.txt_CorreoProf.Size = new System.Drawing.Size(398, 23);
            this.txt_CorreoProf.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correo institucional:";
            // 
            // btn_Regreso
            // 
            this.btn_Regreso.BackColor = System.Drawing.Color.MintCream;
            this.btn_Regreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Regreso.FlatAppearance.BorderSize = 0;
            this.btn_Regreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regreso.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regreso.ForeColor = System.Drawing.Color.Black;
            this.btn_Regreso.Location = new System.Drawing.Point(417, 794);
            this.btn_Regreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Regreso.Name = "btn_Regreso";
            this.btn_Regreso.Size = new System.Drawing.Size(198, 47);
            this.btn_Regreso.TabIndex = 16;
            this.btn_Regreso.Text = "Regresar al inicio";
            this.btn_Regreso.UseVisualStyleBackColor = false;
            // 
            // btn_Registrar_prf_Colegio
            // 
            this.btn_Registrar_prf_Colegio.BackColor = System.Drawing.Color.Green;
            this.btn_Registrar_prf_Colegio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registrar_prf_Colegio.FlatAppearance.BorderSize = 0;
            this.btn_Registrar_prf_Colegio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar_prf_Colegio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar_prf_Colegio.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar_prf_Colegio.Location = new System.Drawing.Point(8, 794);
            this.btn_Registrar_prf_Colegio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Registrar_prf_Colegio.Name = "btn_Registrar_prf_Colegio";
            this.btn_Registrar_prf_Colegio.Size = new System.Drawing.Size(198, 47);
            this.btn_Registrar_prf_Colegio.TabIndex = 15;
            this.btn_Registrar_prf_Colegio.Text = "Registrar";
            this.btn_Registrar_prf_Colegio.UseVisualStyleBackColor = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(178, 12);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(554, 29);
            this.txt_UniADMIN.TabIndex = 18;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SectorProf
            // 
            this.txt_SectorProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SectorProf.ForeColor = System.Drawing.Color.Black;
            this.txt_SectorProf.Location = new System.Drawing.Point(407, 116);
            this.txt_SectorProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SectorProf.Name = "txt_SectorProf";
            this.txt_SectorProf.Size = new System.Drawing.Size(161, 23);
            this.txt_SectorProf.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(320, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sector:";
            // 
            // txt_CedulaProf
            // 
            this.txt_CedulaProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CedulaProf.ForeColor = System.Drawing.Color.Black;
            this.txt_CedulaProf.Location = new System.Drawing.Point(96, 76);
            this.txt_CedulaProf.Mask = "000-0000000-0";
            this.txt_CedulaProf.Name = "txt_CedulaProf";
            this.txt_CedulaProf.Size = new System.Drawing.Size(92, 23);
            this.txt_CedulaProf.TabIndex = 28;
            // 
            // txt_TelefonoProf
            // 
            this.txt_TelefonoProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelefonoProf.ForeColor = System.Drawing.Color.Black;
            this.txt_TelefonoProf.Location = new System.Drawing.Point(96, 116);
            this.txt_TelefonoProf.Mask = "(999)000-0000";
            this.txt_TelefonoProf.Name = "txt_TelefonoProf";
            this.txt_TelefonoProf.Size = new System.Drawing.Size(92, 23);
            this.txt_TelefonoProf.TabIndex = 30;
            // 
            // cmb_ProvinciaProf
            // 
            this.cmb_ProvinciaProf.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProvinciaProf.ForeColor = System.Drawing.Color.Black;
            this.cmb_ProvinciaProf.FormattingEnabled = true;
            this.cmb_ProvinciaProf.Location = new System.Drawing.Point(675, 115);
            this.cmb_ProvinciaProf.Name = "cmb_ProvinciaProf";
            this.cmb_ProvinciaProf.Size = new System.Drawing.Size(182, 26);
            this.cmb_ProvinciaProf.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(589, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Provincia:";
            // 
            // cmb_GradoAcdm
            // 
            this.cmb_GradoAcdm.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GradoAcdm.ForeColor = System.Drawing.Color.Black;
            this.cmb_GradoAcdm.FormattingEnabled = true;
            this.cmb_GradoAcdm.Location = new System.Drawing.Point(166, 117);
            this.cmb_GradoAcdm.Name = "cmb_GradoAcdm";
            this.cmb_GradoAcdm.Size = new System.Drawing.Size(398, 26);
            this.cmb_GradoAcdm.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Grado académico:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_CancelarProf
            // 
            this.btn_CancelarProf.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarProf.FlatAppearance.BorderSize = 0;
            this.btn_CancelarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarProf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarProf.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_CancelarProf.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarProf.Image")));
            this.btn_CancelarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarProf.Location = new System.Drawing.Point(760, 367);
            this.btn_CancelarProf.Name = "btn_CancelarProf";
            this.btn_CancelarProf.Size = new System.Drawing.Size(121, 41);
            this.btn_CancelarProf.TabIndex = 37;
            this.btn_CancelarProf.Text = "Cancelar";
            this.btn_CancelarProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarProf.UseVisualStyleBackColor = false;
            this.btn_CancelarProf.Click += new System.EventHandler(this.btn_CancelarProf_Click);
            // 
            // btn_ModificarProf
            // 
            this.btn_ModificarProf.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ModificarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProf.FlatAppearance.BorderSize = 0;
            this.btn_ModificarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarProf.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarProf.Image")));
            this.btn_ModificarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarProf.Location = new System.Drawing.Point(610, 367);
            this.btn_ModificarProf.Name = "btn_ModificarProf";
            this.btn_ModificarProf.Size = new System.Drawing.Size(130, 41);
            this.btn_ModificarProf.TabIndex = 36;
            this.btn_ModificarProf.Text = "Modificar";
            this.btn_ModificarProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ModificarProf.UseVisualStyleBackColor = false;
            this.btn_ModificarProf.Click += new System.EventHandler(this.btn_ModificarProf_Click);
            // 
            // btn_RegistroProf
            // 
            this.btn_RegistroProf.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_RegistroProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistroProf.FlatAppearance.BorderSize = 0;
            this.btn_RegistroProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistroProf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistroProf.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_RegistroProf.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistroProf.Image")));
            this.btn_RegistroProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistroProf.Location = new System.Drawing.Point(653, 287);
            this.btn_RegistroProf.Name = "btn_RegistroProf";
            this.btn_RegistroProf.Size = new System.Drawing.Size(186, 41);
            this.btn_RegistroProf.TabIndex = 35;
            this.btn_RegistroProf.Text = "Registrar maestro";
            this.btn_RegistroProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RegistroProf.UseVisualStyleBackColor = false;
            this.btn_RegistroProf.Click += new System.EventHandler(this.btn_RegistroProf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_NombresProf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ApellidosProf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_ProvinciaProf);
            this.groupBox1.Controls.Add(this.txt_DireccionProf);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_TelefonoProf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_SectorProf);
            this.groupBox1.Controls.Add(this.txt_CedulaProf);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 156);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_FormatCorreo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_CorreoProf);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmb_GradoAcdm);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 161);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos académicos";
            // 
            // cmb_FormatCorreo
            // 
            this.cmb_FormatCorreo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FormatCorreo.ForeColor = System.Drawing.Color.Black;
            this.cmb_FormatCorreo.FormattingEnabled = true;
            this.cmb_FormatCorreo.Items.AddRange(new object[] {
            "aa0000@univ.edu.do",
            "napellido@univ.edu.do"});
            this.cmb_FormatCorreo.Location = new System.Drawing.Point(166, 35);
            this.cmb_FormatCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_FormatCorreo.Name = "cmb_FormatCorreo";
            this.cmb_FormatCorreo.Size = new System.Drawing.Size(398, 26);
            this.cmb_FormatCorreo.TabIndex = 92;
            this.cmb_FormatCorreo.SelectedIndexChanged += new System.EventHandler(this.cmb_FormatCorreo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 20);
            this.label15.TabIndex = 91;
            this.label15.Text = "Formato de correo:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(324, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "MANTENIMIENTO DE PROFESORES";
            // 
            // foto_uni
            // 
            this.foto_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto_uni.Location = new System.Drawing.Point(13, 12);
            this.foto_uni.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.foto_uni.Name = "foto_uni";
            this.foto_uni.Size = new System.Drawing.Size(144, 66);
            this.foto_uni.TabIndex = 84;
            this.foto_uni.TabStop = false;
            // 
            // data_RegistroProf
            // 
            this.data_RegistroProf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_RegistroProf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_RegistroProf.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_RegistroProf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_RegistroProf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroProf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_RegistroProf.ColumnHeadersHeight = 30;
            this.data_RegistroProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_RegistroProf.EnableHeadersVisualStyles = false;
            this.data_RegistroProf.GridColor = System.Drawing.Color.DarkGreen;
            this.data_RegistroProf.Location = new System.Drawing.Point(14, 453);
            this.data_RegistroProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_RegistroProf.Name = "data_RegistroProf";
            this.data_RegistroProf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroProf.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.data_RegistroProf.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_RegistroProf.Size = new System.Drawing.Size(867, 193);
            this.data_RegistroProf.TabIndex = 85;
            // 
            // btn_ImprimirRepProf
            // 
            this.btn_ImprimirRepProf.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ImprimirRepProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirRepProf.FlatAppearance.BorderSize = 0;
            this.btn_ImprimirRepProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprimirRepProf.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirRepProf.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_ImprimirRepProf.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImprimirRepProf.Image")));
            this.btn_ImprimirRepProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImprimirRepProf.Location = new System.Drawing.Point(702, 654);
            this.btn_ImprimirRepProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ImprimirRepProf.Name = "btn_ImprimirRepProf";
            this.btn_ImprimirRepProf.Size = new System.Drawing.Size(179, 42);
            this.btn_ImprimirRepProf.TabIndex = 86;
            this.btn_ImprimirRepProf.Text = "Imprimir reporte";
            this.btn_ImprimirRepProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImprimirRepProf.UseVisualStyleBackColor = false;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(769, 9);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 93;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 698);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.btn_ImprimirRepProf);
            this.Controls.Add(this.data_RegistroProf);
            this.Controls.Add(this.foto_uni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CancelarProf);
            this.Controls.Add(this.btn_ModificarProf);
            this.Controls.Add(this.btn_RegistroProf);
            this.Controls.Add(this.txt_UniADMIN);
            this.Controls.Add(this.btn_Regreso);
            this.Controls.Add(this.btn_Registrar_prf_Colegio);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FRM_Profesores";
            this.Text = "FRM_Profesores_Colegio";
            this.Load += new System.EventHandler(this.FRM_Profesores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombresProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApellidosProf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DireccionProf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CorreoProf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Regreso;
        private System.Windows.Forms.Button btn_Registrar_prf_Colegio;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.TextBox txt_SectorProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_CedulaProf;
        private System.Windows.Forms.MaskedTextBox txt_TelefonoProf;
        private System.Windows.Forms.ComboBox cmb_ProvinciaProf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_GradoAcdm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_CancelarProf;
        private System.Windows.Forms.Button btn_ModificarProf;
        private System.Windows.Forms.Button btn_RegistroProf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox foto_uni;
        private System.Windows.Forms.DataGridView data_RegistroProf;
        private System.Windows.Forms.Button btn_ImprimirRepProf;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.ComboBox cmb_FormatCorreo;
        private System.Windows.Forms.Label label15;
    }
}