namespace Sistema_Gestión_Aula_EduSmart.Capa_Presentación
{
    partial class FRM_Provincias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Provincias));
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.data_RegistroProv = new System.Windows.Forms.DataGridView();
            this.btn_CancelarProv = new System.Windows.Forms.Button();
            this.btn_ModificarProv = new System.Windows.Forms.Button();
            this.btn_RegistroProv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreProv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(716, 17);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 101;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(297, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 22);
            this.label1.TabIndex = 100;
            this.label1.Text = "MANTENIMIENTO DE PROVINCIAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 66);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(172, 14);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(498, 26);
            this.txt_UniADMIN.TabIndex = 97;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_RegistroProv
            // 
            this.data_RegistroProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_RegistroProv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_RegistroProv.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_RegistroProv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_RegistroProv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_RegistroProv.ColumnHeadersHeight = 30;
            this.data_RegistroProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_RegistroProv.EnableHeadersVisualStyles = false;
            this.data_RegistroProv.GridColor = System.Drawing.Color.Green;
            this.data_RegistroProv.Location = new System.Drawing.Point(10, 212);
            this.data_RegistroProv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_RegistroProv.Name = "data_RegistroProv";
            this.data_RegistroProv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroProv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.data_RegistroProv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_RegistroProv.Size = new System.Drawing.Size(843, 319);
            this.data_RegistroProv.TabIndex = 107;
            // 
            // btn_CancelarProv
            // 
            this.btn_CancelarProv.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarProv.FlatAppearance.BorderSize = 0;
            this.btn_CancelarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarProv.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarProv.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_CancelarProv.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarProv.Image")));
            this.btn_CancelarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarProv.Location = new System.Drawing.Point(694, 155);
            this.btn_CancelarProv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_CancelarProv.Name = "btn_CancelarProv";
            this.btn_CancelarProv.Size = new System.Drawing.Size(129, 38);
            this.btn_CancelarProv.TabIndex = 106;
            this.btn_CancelarProv.Text = "Cancelar";
            this.btn_CancelarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarProv.UseVisualStyleBackColor = false;
            this.btn_CancelarProv.Click += new System.EventHandler(this.btn_CancelarProv_Click);
            // 
            // btn_ModificarProv
            // 
            this.btn_ModificarProv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ModificarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProv.FlatAppearance.BorderSize = 0;
            this.btn_ModificarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProv.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarProv.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarProv.Image")));
            this.btn_ModificarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarProv.Location = new System.Drawing.Point(541, 155);
            this.btn_ModificarProv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ModificarProv.Name = "btn_ModificarProv";
            this.btn_ModificarProv.Size = new System.Drawing.Size(129, 38);
            this.btn_ModificarProv.TabIndex = 105;
            this.btn_ModificarProv.Text = "Modificar";
            this.btn_ModificarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ModificarProv.UseVisualStyleBackColor = false;
            // 
            // btn_RegistroProv
            // 
            this.btn_RegistroProv.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_RegistroProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistroProv.FlatAppearance.BorderSize = 0;
            this.btn_RegistroProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistroProv.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistroProv.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_RegistroProv.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistroProv.Image")));
            this.btn_RegistroProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistroProv.Location = new System.Drawing.Point(571, 107);
            this.btn_RegistroProv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_RegistroProv.Name = "btn_RegistroProv";
            this.btn_RegistroProv.Size = new System.Drawing.Size(199, 38);
            this.btn_RegistroProv.TabIndex = 104;
            this.btn_RegistroProv.Text = "Registrar provincia";
            this.btn_RegistroProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RegistroProv.UseVisualStyleBackColor = false;
            this.btn_RegistroProv.Click += new System.EventHandler(this.btn_RegistroProv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Nombre:";
            // 
            // txt_NombreProv
            // 
            this.txt_NombreProv.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProv.Location = new System.Drawing.Point(85, 122);
            this.txt_NombreProv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_NombreProv.MaxLength = 50;
            this.txt_NombreProv.Name = "txt_NombreProv";
            this.txt_NombreProv.Size = new System.Drawing.Size(370, 23);
            this.txt_NombreProv.TabIndex = 102;
            // 
            // FRM_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.data_RegistroProv);
            this.Controls.Add(this.btn_CancelarProv);
            this.Controls.Add(this.btn_ModificarProv);
            this.Controls.Add(this.btn_RegistroProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreProv);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_UniADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Provincias";
            this.Text = "FRM_Provincias";
            this.Load += new System.EventHandler(this.FRM_Provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.DataGridView data_RegistroProv;
        private System.Windows.Forms.Button btn_CancelarProv;
        private System.Windows.Forms.Button btn_ModificarProv;
        private System.Windows.Forms.Button btn_RegistroProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreProv;
    }
}