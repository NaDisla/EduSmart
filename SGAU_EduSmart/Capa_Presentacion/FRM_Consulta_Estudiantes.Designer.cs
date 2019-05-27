namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Consulta_Estudiantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.txt_NombresEstud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Matricula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CodigoSecc = new System.Windows.Forms.TextBox();
            this.txt_Asignatura = new System.Windows.Forms.TextBox();
            this.txt_Prof = new System.Windows.Forms.TextBox();
            this.txt_ApellidosEstud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PromParciales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PromPracticas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_InfoEstud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_AcumAsistencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(307, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "CONSULTA DE ESTUDIANTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 66);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(172, 13);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(501, 29);
            this.txt_UniADMIN.TabIndex = 75;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NombresEstud
            // 
            this.txt_NombresEstud.Enabled = false;
            this.txt_NombresEstud.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombresEstud.Location = new System.Drawing.Point(444, 149);
            this.txt_NombresEstud.Name = "txt_NombresEstud";
            this.txt_NombresEstud.Size = new System.Drawing.Size(380, 23);
            this.txt_NombresEstud.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Nombres:";
            // 
            // cmb_Matricula
            // 
            this.cmb_Matricula.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Matricula.FormattingEnabled = true;
            this.cmb_Matricula.Location = new System.Drawing.Point(92, 150);
            this.cmb_Matricula.Name = "cmb_Matricula";
            this.cmb_Matricula.Size = new System.Drawing.Size(153, 26);
            this.cmb_Matricula.TabIndex = 88;
            this.cmb_Matricula.SelectedIndexChanged += new System.EventHandler(this.cmb_Matricula_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Matrícula:";
            // 
            // txt_CodigoSecc
            // 
            this.txt_CodigoSecc.Enabled = false;
            this.txt_CodigoSecc.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoSecc.Location = new System.Drawing.Point(736, 105);
            this.txt_CodigoSecc.Name = "txt_CodigoSecc";
            this.txt_CodigoSecc.Size = new System.Drawing.Size(88, 23);
            this.txt_CodigoSecc.TabIndex = 86;
            // 
            // txt_Asignatura
            // 
            this.txt_Asignatura.Enabled = false;
            this.txt_Asignatura.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Asignatura.Location = new System.Drawing.Point(344, 105);
            this.txt_Asignatura.Name = "txt_Asignatura";
            this.txt_Asignatura.Size = new System.Drawing.Size(376, 23);
            this.txt_Asignatura.TabIndex = 85;
            // 
            // txt_Prof
            // 
            this.txt_Prof.Enabled = false;
            this.txt_Prof.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prof.Location = new System.Drawing.Point(10, 105);
            this.txt_Prof.Name = "txt_Prof";
            this.txt_Prof.Size = new System.Drawing.Size(319, 23);
            this.txt_Prof.TabIndex = 84;
            // 
            // txt_ApellidosEstud
            // 
            this.txt_ApellidosEstud.Enabled = false;
            this.txt_ApellidosEstud.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApellidosEstud.Location = new System.Drawing.Point(444, 187);
            this.txt_ApellidosEstud.Name = "txt_ApellidosEstud";
            this.txt_ApellidosEstud.Size = new System.Drawing.Size(380, 23);
            this.txt_ApellidosEstud.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Apellidos:";
            // 
            // txt_PromParciales
            // 
            this.txt_PromParciales.Enabled = false;
            this.txt_PromParciales.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PromParciales.Location = new System.Drawing.Point(179, 193);
            this.txt_PromParciales.Name = "txt_PromParciales";
            this.txt_PromParciales.Size = new System.Drawing.Size(66, 23);
            this.txt_PromParciales.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Promedio Parciales:";
            // 
            // txt_PromPracticas
            // 
            this.txt_PromPracticas.Enabled = false;
            this.txt_PromPracticas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PromPracticas.Location = new System.Drawing.Point(179, 231);
            this.txt_PromPracticas.Name = "txt_PromPracticas";
            this.txt_PromPracticas.Size = new System.Drawing.Size(66, 23);
            this.txt_PromPracticas.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Promedio Prácticas:";
            // 
            // txt_InfoEstud
            // 
            this.txt_InfoEstud.Enabled = false;
            this.txt_InfoEstud.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InfoEstud.Location = new System.Drawing.Point(444, 230);
            this.txt_InfoEstud.Multiline = true;
            this.txt_InfoEstud.Name = "txt_InfoEstud";
            this.txt_InfoEstud.Size = new System.Drawing.Size(380, 61);
            this.txt_InfoEstud.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Información:";
            // 
            // txt_AcumAsistencia
            // 
            this.txt_AcumAsistencia.Enabled = false;
            this.txt_AcumAsistencia.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AcumAsistencia.Location = new System.Drawing.Point(179, 271);
            this.txt_AcumAsistencia.Name = "txt_AcumAsistencia";
            this.txt_AcumAsistencia.Size = new System.Drawing.Size(66, 23);
            this.txt_AcumAsistencia.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Acumulado Asistencia:";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(732, 16);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 101;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Consulta_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 384);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.txt_AcumAsistencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_InfoEstud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PromPracticas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PromParciales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ApellidosEstud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombresEstud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CodigoSecc);
            this.Controls.Add(this.txt_Asignatura);
            this.Controls.Add(this.txt_Prof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_UniADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Consulta_Estudiantes";
            this.Text = "Consulta Estudiantil - EduSmart";
            this.Load += new System.EventHandler(this.FRM_Consulta_Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.TextBox txt_NombresEstud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CodigoSecc;
        private System.Windows.Forms.TextBox txt_Asignatura;
        private System.Windows.Forms.TextBox txt_ApellidosEstud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PromParciales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PromPracticas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_InfoEstud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_AcumAsistencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_Fecha;
        public System.Windows.Forms.TextBox txt_Prof;
    }
}