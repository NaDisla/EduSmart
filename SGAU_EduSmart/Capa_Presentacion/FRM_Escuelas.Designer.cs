namespace Sistema_Gestión_Aula_EduSmart.Capa_Presentación
{
    partial class FRM_Escuelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Escuelas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CancelarEscuela = new System.Windows.Forms.Button();
            this.btn_ModificarEscuela = new System.Windows.Forms.Button();
            this.btn_RegistroEscuela = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.cmb_Facultad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreEscuela = new System.Windows.Forms.TextBox();
            this.data_RegistroEscuela = new System.Windows.Forms.DataGridView();
            this.btn_ImprRepEscuela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroEscuela)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(845, 14);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 103;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(352, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 102;
            this.label1.Text = "MANTENIMIENTO DE ESCUELAS";
            // 
            // btn_CancelarEscuela
            // 
            this.btn_CancelarEscuela.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarEscuela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarEscuela.FlatAppearance.BorderSize = 0;
            this.btn_CancelarEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarEscuela.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarEscuela.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_CancelarEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarEscuela.Image")));
            this.btn_CancelarEscuela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarEscuela.Location = new System.Drawing.Point(810, 119);
            this.btn_CancelarEscuela.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_CancelarEscuela.Name = "btn_CancelarEscuela";
            this.btn_CancelarEscuela.Size = new System.Drawing.Size(117, 44);
            this.btn_CancelarEscuela.TabIndex = 101;
            this.btn_CancelarEscuela.Text = "Cancelar";
            this.btn_CancelarEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarEscuela.UseVisualStyleBackColor = false;
            this.btn_CancelarEscuela.Click += new System.EventHandler(this.btn_CancelarEscuela_Click);
            // 
            // btn_ModificarEscuela
            // 
            this.btn_ModificarEscuela.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ModificarEscuela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarEscuela.FlatAppearance.BorderSize = 0;
            this.btn_ModificarEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarEscuela.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarEscuela.Image")));
            this.btn_ModificarEscuela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarEscuela.Location = new System.Drawing.Point(670, 119);
            this.btn_ModificarEscuela.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ModificarEscuela.Name = "btn_ModificarEscuela";
            this.btn_ModificarEscuela.Size = new System.Drawing.Size(123, 44);
            this.btn_ModificarEscuela.TabIndex = 100;
            this.btn_ModificarEscuela.Text = "Modificar";
            this.btn_ModificarEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ModificarEscuela.UseVisualStyleBackColor = false;
            // 
            // btn_RegistroEscuela
            // 
            this.btn_RegistroEscuela.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_RegistroEscuela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistroEscuela.FlatAppearance.BorderSize = 0;
            this.btn_RegistroEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistroEscuela.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistroEscuela.ForeColor = System.Drawing.Color.White;
            this.btn_RegistroEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistroEscuela.Image")));
            this.btn_RegistroEscuela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistroEscuela.Location = new System.Drawing.Point(470, 119);
            this.btn_RegistroEscuela.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_RegistroEscuela.Name = "btn_RegistroEscuela";
            this.btn_RegistroEscuela.Size = new System.Drawing.Size(180, 44);
            this.btn_RegistroEscuela.TabIndex = 99;
            this.btn_RegistroEscuela.Text = "Registrar escuela";
            this.btn_RegistroEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RegistroEscuela.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 66);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(175, 14);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(634, 26);
            this.txt_UniADMIN.TabIndex = 97;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_Facultad
            // 
            this.cmb_Facultad.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Facultad.FormattingEnabled = true;
            this.cmb_Facultad.Location = new System.Drawing.Point(85, 151);
            this.cmb_Facultad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmb_Facultad.Name = "cmb_Facultad";
            this.cmb_Facultad.Size = new System.Drawing.Size(370, 26);
            this.cmb_Facultad.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "Facultad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Nombre:";
            // 
            // txt_NombreEscuela
            // 
            this.txt_NombreEscuela.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreEscuela.Location = new System.Drawing.Point(85, 109);
            this.txt_NombreEscuela.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_NombreEscuela.MaxLength = 50;
            this.txt_NombreEscuela.Name = "txt_NombreEscuela";
            this.txt_NombreEscuela.Size = new System.Drawing.Size(370, 23);
            this.txt_NombreEscuela.TabIndex = 104;
            // 
            // data_RegistroEscuela
            // 
            this.data_RegistroEscuela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_RegistroEscuela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_RegistroEscuela.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_RegistroEscuela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_RegistroEscuela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroEscuela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_RegistroEscuela.ColumnHeadersHeight = 30;
            this.data_RegistroEscuela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_RegistroEscuela.EnableHeadersVisualStyles = false;
            this.data_RegistroEscuela.GridColor = System.Drawing.Color.DarkGreen;
            this.data_RegistroEscuela.Location = new System.Drawing.Point(13, 198);
            this.data_RegistroEscuela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_RegistroEscuela.Name = "data_RegistroEscuela";
            this.data_RegistroEscuela.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroEscuela.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.data_RegistroEscuela.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_RegistroEscuela.Size = new System.Drawing.Size(914, 231);
            this.data_RegistroEscuela.TabIndex = 110;
            // 
            // btn_ImprRepEscuela
            // 
            this.btn_ImprRepEscuela.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ImprRepEscuela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprRepEscuela.FlatAppearance.BorderSize = 0;
            this.btn_ImprRepEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprRepEscuela.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprRepEscuela.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_ImprRepEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImprRepEscuela.Image")));
            this.btn_ImprRepEscuela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImprRepEscuela.Location = new System.Drawing.Point(748, 437);
            this.btn_ImprRepEscuela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ImprRepEscuela.Name = "btn_ImprRepEscuela";
            this.btn_ImprRepEscuela.Size = new System.Drawing.Size(179, 37);
            this.btn_ImprRepEscuela.TabIndex = 111;
            this.btn_ImprRepEscuela.Text = "Imprimir reporte";
            this.btn_ImprRepEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImprRepEscuela.UseVisualStyleBackColor = false;
            // 
            // FRM_Escuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 483);
            this.Controls.Add(this.btn_ImprRepEscuela);
            this.Controls.Add(this.data_RegistroEscuela);
            this.Controls.Add(this.cmb_Facultad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreEscuela);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelarEscuela);
            this.Controls.Add(this.btn_ModificarEscuela);
            this.Controls.Add(this.btn_RegistroEscuela);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_UniADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Escuelas";
            this.Text = "Mantenimiento de Escuelas - EduSmart";
            this.Load += new System.EventHandler(this.FRM_Escuelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroEscuela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CancelarEscuela;
        private System.Windows.Forms.Button btn_ModificarEscuela;
        private System.Windows.Forms.Button btn_RegistroEscuela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.ComboBox cmb_Facultad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreEscuela;
        private System.Windows.Forms.DataGridView data_RegistroEscuela;
        private System.Windows.Forms.Button btn_ImprRepEscuela;
    }
}