namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Consulta_Estudiantil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Consulta_Estudiantil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_RegistroProf = new System.Windows.Forms.Button();
            this.txt_FechaADMIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icono_cerrar_form = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono_cerrar_form)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 65);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
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
            this.btn_RegistroProf.Location = new System.Drawing.Point(563, 262);
            this.btn_RegistroProf.Name = "btn_RegistroProf";
            this.btn_RegistroProf.Size = new System.Drawing.Size(186, 41);
            this.btn_RegistroProf.TabIndex = 43;
            this.btn_RegistroProf.Text = "Consultar estudiante";
            this.btn_RegistroProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RegistroProf.UseVisualStyleBackColor = false;
            // 
            // txt_FechaADMIN
            // 
            this.txt_FechaADMIN.Enabled = false;
            this.txt_FechaADMIN.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaADMIN.Location = new System.Drawing.Point(690, 46);
            this.txt_FechaADMIN.Name = "txt_FechaADMIN";
            this.txt_FechaADMIN.Size = new System.Drawing.Size(98, 25);
            this.txt_FechaADMIN.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(306, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Registro de profesores";
            // 
            // icono_cerrar_form
            // 
            this.icono_cerrar_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icono_cerrar_form.Image = ((System.Drawing.Image)(resources.GetObject("icono_cerrar_form.Image")));
            this.icono_cerrar_form.Location = new System.Drawing.Point(763, 8);
            this.icono_cerrar_form.Name = "icono_cerrar_form";
            this.icono_cerrar_form.Size = new System.Drawing.Size(25, 25);
            this.icono_cerrar_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono_cerrar_form.TabIndex = 46;
            this.icono_cerrar_form.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(224, 12);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(360, 28);
            this.txt_UniADMIN.TabIndex = 45;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_Consulta_Estudiantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.icono_cerrar_form);
            this.Controls.Add(this.txt_UniADMIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_RegistroProf);
            this.Controls.Add(this.txt_FechaADMIN);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Consulta_Estudiantil";
            this.Text = "FRM_Consulta_Estudiantil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono_cerrar_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_RegistroProf;
        private System.Windows.Forms.TextBox txt_FechaADMIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox icono_cerrar_form;
        private System.Windows.Forms.TextBox txt_UniADMIN;
    }
}