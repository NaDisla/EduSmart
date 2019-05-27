namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Acceso_Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Acceso_Sistema));
            this.pn_TituloAcceso = new System.Windows.Forms.Panel();
            this.icono_cerrar_AccesoES = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_CancelarAcceso = new System.Windows.Forms.Button();
            this.btn_IngresoSistema = new System.Windows.Forms.Button();
            this.link_Usuario = new System.Windows.Forms.LinkLabel();
            this.pn_TituloAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_cerrar_AccesoES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_TituloAcceso
            // 
            this.pn_TituloAcceso.BackColor = System.Drawing.Color.Green;
            this.pn_TituloAcceso.Controls.Add(this.icono_cerrar_AccesoES);
            this.pn_TituloAcceso.Controls.Add(this.label1);
            this.pn_TituloAcceso.Controls.Add(this.pictureBox1);
            this.pn_TituloAcceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_TituloAcceso.Location = new System.Drawing.Point(0, 0);
            this.pn_TituloAcceso.Name = "pn_TituloAcceso";
            this.pn_TituloAcceso.Size = new System.Drawing.Size(515, 39);
            this.pn_TituloAcceso.TabIndex = 0;
            this.pn_TituloAcceso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Título_Acceso_Colegio_MouseDown);
            // 
            // icono_cerrar_AccesoES
            // 
            this.icono_cerrar_AccesoES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icono_cerrar_AccesoES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icono_cerrar_AccesoES.Image = ((System.Drawing.Image)(resources.GetObject("icono_cerrar_AccesoES.Image")));
            this.icono_cerrar_AccesoES.Location = new System.Drawing.Point(476, 3);
            this.icono_cerrar_AccesoES.Name = "icono_cerrar_AccesoES";
            this.icono_cerrar_AccesoES.Size = new System.Drawing.Size(36, 33);
            this.icono_cerrar_AccesoES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono_cerrar_AccesoES.TabIndex = 2;
            this.icono_cerrar_AccesoES.TabStop = false;
            this.icono_cerrar_AccesoES.Click += new System.EventHandler(this.icono_cerrar_AccesoES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "EduSmart - Ventana de acceso";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(313, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(98, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acceder a EduSmart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(261, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // txt_User
            // 
            this.txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_User.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(99, 123);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(111, 23);
            this.txt_User.TabIndex = 13;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(383, 123);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(111, 23);
            this.txt_Password.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // btn_CancelarAcceso
            // 
            this.btn_CancelarAcceso.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarAcceso.FlatAppearance.BorderSize = 0;
            this.btn_CancelarAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarAcceso.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarAcceso.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarAcceso.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarAcceso.Image")));
            this.btn_CancelarAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarAcceso.Location = new System.Drawing.Point(375, 164);
            this.btn_CancelarAcceso.Name = "btn_CancelarAcceso";
            this.btn_CancelarAcceso.Size = new System.Drawing.Size(119, 38);
            this.btn_CancelarAcceso.TabIndex = 29;
            this.btn_CancelarAcceso.Text = "Cancelar";
            this.btn_CancelarAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarAcceso.UseVisualStyleBackColor = false;
            // 
            // btn_IngresoSistema
            // 
            this.btn_IngresoSistema.BackColor = System.Drawing.Color.Green;
            this.btn_IngresoSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IngresoSistema.FlatAppearance.BorderSize = 0;
            this.btn_IngresoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresoSistema.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngresoSistema.ForeColor = System.Drawing.Color.White;
            this.btn_IngresoSistema.Image = ((System.Drawing.Image)(resources.GetObject("btn_IngresoSistema.Image")));
            this.btn_IngresoSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IngresoSistema.Location = new System.Drawing.Point(198, 164);
            this.btn_IngresoSistema.Name = "btn_IngresoSistema";
            this.btn_IngresoSistema.Size = new System.Drawing.Size(116, 38);
            this.btn_IngresoSistema.TabIndex = 28;
            this.btn_IngresoSistema.Text = "Ingresar";
            this.btn_IngresoSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_IngresoSistema.UseVisualStyleBackColor = false;
            this.btn_IngresoSistema.Click += new System.EventHandler(this.btn_IngresoSistema_Click);
            // 
            // link_Usuario
            // 
            this.link_Usuario.AutoSize = true;
            this.link_Usuario.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Usuario.Location = new System.Drawing.Point(9, 175);
            this.link_Usuario.Name = "link_Usuario";
            this.link_Usuario.Size = new System.Drawing.Size(133, 18);
            this.link_Usuario.TabIndex = 30;
            this.link_Usuario.TabStop = true;
            this.link_Usuario.Text = "Crear nuevo usuario";
            this.link_Usuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Usuario_LinkClicked);
            // 
            // FRM_Acceso_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 220);
            this.Controls.Add(this.link_Usuario);
            this.Controls.Add(this.btn_CancelarAcceso);
            this.Controls.Add(this.btn_IngresoSistema);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pn_TituloAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Acceso_Sistema";
            this.ShowInTaskbar = false;
            this.pn_TituloAcceso.ResumeLayout(false);
            this.pn_TituloAcceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_cerrar_AccesoES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_TituloAcceso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icono_cerrar_AccesoES;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_CancelarAcceso;
        private System.Windows.Forms.Button btn_IngresoSistema;
        private System.Windows.Forms.LinkLabel link_Usuario;
    }
}