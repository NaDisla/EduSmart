namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Periodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Periodos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.date_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DescPeriodo = new System.Windows.Forms.TextBox();
            this.cmb_FormatDescrip = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_GuardarAsist = new System.Windows.Forms.Button();
            this.btn_CancelarAsignt = new System.Windows.Forms.Button();
            this.btn_ModificarAsignt = new System.Windows.Forms.Button();
            this.data_RegistroPer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroPer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(301, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "MANTENIMIENTO DE PERÍODOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 13);
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
            this.txt_UniADMIN.Location = new System.Drawing.Point(179, 13);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(492, 29);
            this.txt_UniADMIN.TabIndex = 75;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(696, 16);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 93;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Fecha Inicio:";
            // 
            // date_FechaInicio
            // 
            this.date_FechaInicio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_FechaInicio.Location = new System.Drawing.Point(117, 112);
            this.date_FechaInicio.Name = "date_FechaInicio";
            this.date_FechaInicio.Size = new System.Drawing.Size(261, 23);
            this.date_FechaInicio.TabIndex = 95;
            // 
            // date_FechaFin
            // 
            this.date_FechaFin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_FechaFin.Location = new System.Drawing.Point(497, 112);
            this.date_FechaFin.Name = "date_FechaFin";
            this.date_FechaFin.Size = new System.Drawing.Size(259, 23);
            this.date_FechaFin.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Fecha Fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Descripción:";
            // 
            // txt_DescPeriodo
            // 
            this.txt_DescPeriodo.Enabled = false;
            this.txt_DescPeriodo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescPeriodo.Location = new System.Drawing.Point(512, 157);
            this.txt_DescPeriodo.Name = "txt_DescPeriodo";
            this.txt_DescPeriodo.Size = new System.Drawing.Size(244, 23);
            this.txt_DescPeriodo.TabIndex = 99;
            // 
            // cmb_FormatDescrip
            // 
            this.cmb_FormatDescrip.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FormatDescrip.FormattingEnabled = true;
            this.cmb_FormatDescrip.Items.AddRange(new object[] {
            "3 meses (MES-MES-AÑO)",
            "4 meses (MES-MES-AÑO)"});
            this.cmb_FormatDescrip.Location = new System.Drawing.Point(198, 157);
            this.cmb_FormatDescrip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmb_FormatDescrip.Name = "cmb_FormatDescrip";
            this.cmb_FormatDescrip.Size = new System.Drawing.Size(180, 26);
            this.cmb_FormatDescrip.TabIndex = 101;
            this.cmb_FormatDescrip.SelectedIndexChanged += new System.EventHandler(this.cmb_FormatDescrip_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Formato de descripción:";
            // 
            // btn_GuardarAsist
            // 
            this.btn_GuardarAsist.BackColor = System.Drawing.Color.Green;
            this.btn_GuardarAsist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GuardarAsist.FlatAppearance.BorderSize = 0;
            this.btn_GuardarAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarAsist.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarAsist.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarAsist.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarAsist.Image")));
            this.btn_GuardarAsist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarAsist.Location = new System.Drawing.Point(16, 207);
            this.btn_GuardarAsist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GuardarAsist.Name = "btn_GuardarAsist";
            this.btn_GuardarAsist.Size = new System.Drawing.Size(187, 40);
            this.btn_GuardarAsist.TabIndex = 114;
            this.btn_GuardarAsist.Text = "Registrar período";
            this.btn_GuardarAsist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarAsist.UseVisualStyleBackColor = false;
            // 
            // btn_CancelarAsignt
            // 
            this.btn_CancelarAsignt.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarAsignt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarAsignt.FlatAppearance.BorderSize = 0;
            this.btn_CancelarAsignt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarAsignt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarAsignt.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_CancelarAsignt.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarAsignt.Image")));
            this.btn_CancelarAsignt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarAsignt.Location = new System.Drawing.Point(556, 207);
            this.btn_CancelarAsignt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_CancelarAsignt.Name = "btn_CancelarAsignt";
            this.btn_CancelarAsignt.Size = new System.Drawing.Size(199, 42);
            this.btn_CancelarAsignt.TabIndex = 116;
            this.btn_CancelarAsignt.Text = "Cancelar";
            this.btn_CancelarAsignt.UseVisualStyleBackColor = false;
            this.btn_CancelarAsignt.Click += new System.EventHandler(this.btn_CancelarAsignt_Click);
            // 
            // btn_ModificarAsignt
            // 
            this.btn_ModificarAsignt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ModificarAsignt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarAsignt.FlatAppearance.BorderSize = 0;
            this.btn_ModificarAsignt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarAsignt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarAsignt.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarAsignt.Image")));
            this.btn_ModificarAsignt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarAsignt.Location = new System.Drawing.Point(268, 207);
            this.btn_ModificarAsignt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ModificarAsignt.Name = "btn_ModificarAsignt";
            this.btn_ModificarAsignt.Size = new System.Drawing.Size(199, 42);
            this.btn_ModificarAsignt.TabIndex = 115;
            this.btn_ModificarAsignt.Text = "Modificar";
            this.btn_ModificarAsignt.UseVisualStyleBackColor = false;
            // 
            // data_RegistroPer
            // 
            this.data_RegistroPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_RegistroPer.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_RegistroPer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_RegistroPer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroPer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_RegistroPer.ColumnHeadersHeight = 30;
            this.data_RegistroPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_RegistroPer.EnableHeadersVisualStyles = false;
            this.data_RegistroPer.GridColor = System.Drawing.Color.DarkGreen;
            this.data_RegistroPer.Location = new System.Drawing.Point(16, 258);
            this.data_RegistroPer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_RegistroPer.Name = "data_RegistroPer";
            this.data_RegistroPer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroPer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.data_RegistroPer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_RegistroPer.Size = new System.Drawing.Size(740, 223);
            this.data_RegistroPer.TabIndex = 117;
            // 
            // FRM_Periodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 494);
            this.Controls.Add(this.data_RegistroPer);
            this.Controls.Add(this.btn_CancelarAsignt);
            this.Controls.Add(this.btn_ModificarAsignt);
            this.Controls.Add(this.btn_GuardarAsist);
            this.Controls.Add(this.cmb_FormatDescrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DescPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_FechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_FechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_UniADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Periodos";
            this.Text = "FRM_Periodos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_FechaInicio;
        private System.Windows.Forms.DateTimePicker date_FechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DescPeriodo;
        private System.Windows.Forms.ComboBox cmb_FormatDescrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_GuardarAsist;
        private System.Windows.Forms.Button btn_CancelarAsignt;
        private System.Windows.Forms.Button btn_ModificarAsignt;
        private System.Windows.Forms.DataGridView data_RegistroPer;
    }
}