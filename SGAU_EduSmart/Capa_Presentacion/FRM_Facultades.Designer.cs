namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Facultades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Facultades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_CancelarFac = new System.Windows.Forms.Button();
            this.btn_ModificarFac = new System.Windows.Forms.Button();
            this.btn_RegistroFac = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreFac = new System.Windows.Forms.TextBox();
            this.foto_uni = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ImprimirRepFac = new System.Windows.Forms.Button();
            this.data_RegistroFac = new System.Windows.Forms.DataGridView();
            this.lb_Fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroFac)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CancelarFac
            // 
            this.btn_CancelarFac.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarFac.FlatAppearance.BorderSize = 0;
            this.btn_CancelarFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarFac.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarFac.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_CancelarFac.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarFac.Image")));
            this.btn_CancelarFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarFac.Location = new System.Drawing.Point(632, 152);
            this.btn_CancelarFac.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_CancelarFac.Name = "btn_CancelarFac";
            this.btn_CancelarFac.Size = new System.Drawing.Size(181, 44);
            this.btn_CancelarFac.TabIndex = 70;
            this.btn_CancelarFac.Text = "Cancelar";
            this.btn_CancelarFac.UseVisualStyleBackColor = false;
            this.btn_CancelarFac.Click += new System.EventHandler(this.btn_CancelarFac_Click);
            // 
            // btn_ModificarFac
            // 
            this.btn_ModificarFac.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ModificarFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarFac.FlatAppearance.BorderSize = 0;
            this.btn_ModificarFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarFac.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarFac.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarFac.Image")));
            this.btn_ModificarFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarFac.Location = new System.Drawing.Point(339, 152);
            this.btn_ModificarFac.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ModificarFac.Name = "btn_ModificarFac";
            this.btn_ModificarFac.Size = new System.Drawing.Size(181, 44);
            this.btn_ModificarFac.TabIndex = 69;
            this.btn_ModificarFac.Text = "Modificar";
            this.btn_ModificarFac.UseVisualStyleBackColor = false;
            // 
            // btn_RegistroFac
            // 
            this.btn_RegistroFac.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_RegistroFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistroFac.FlatAppearance.BorderSize = 0;
            this.btn_RegistroFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistroFac.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistroFac.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_RegistroFac.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistroFac.Image")));
            this.btn_RegistroFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistroFac.Location = new System.Drawing.Point(10, 152);
            this.btn_RegistroFac.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_RegistroFac.Name = "btn_RegistroFac";
            this.btn_RegistroFac.Size = new System.Drawing.Size(181, 44);
            this.btn_RegistroFac.TabIndex = 68;
            this.btn_RegistroFac.Text = "Registrar facultad";
            this.btn_RegistroFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RegistroFac.UseVisualStyleBackColor = false;
            this.btn_RegistroFac.Click += new System.EventHandler(this.btn_RegistroFac_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nombre:";
            // 
            // txt_NombreFac
            // 
            this.txt_NombreFac.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreFac.Location = new System.Drawing.Point(81, 103);
            this.txt_NombreFac.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_NombreFac.MaxLength = 50;
            this.txt_NombreFac.Name = "txt_NombreFac";
            this.txt_NombreFac.Size = new System.Drawing.Size(732, 23);
            this.txt_NombreFac.TabIndex = 66;
            // 
            // foto_uni
            // 
            this.foto_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto_uni.Location = new System.Drawing.Point(11, 14);
            this.foto_uni.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.foto_uni.Name = "foto_uni";
            this.foto_uni.Size = new System.Drawing.Size(144, 66);
            this.foto_uni.TabIndex = 65;
            this.foto_uni.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(175, 14);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(496, 26);
            this.txt_UniADMIN.TabIndex = 63;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(300, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 72;
            this.label1.Text = "MANTENIMIENTO DE FACULTADES";
            // 
            // btn_ImprimirRepFac
            // 
            this.btn_ImprimirRepFac.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ImprimirRepFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirRepFac.FlatAppearance.BorderSize = 0;
            this.btn_ImprimirRepFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprimirRepFac.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirRepFac.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_ImprimirRepFac.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImprimirRepFac.Image")));
            this.btn_ImprimirRepFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImprimirRepFac.Location = new System.Drawing.Point(632, 483);
            this.btn_ImprimirRepFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ImprimirRepFac.Name = "btn_ImprimirRepFac";
            this.btn_ImprimirRepFac.Size = new System.Drawing.Size(179, 41);
            this.btn_ImprimirRepFac.TabIndex = 74;
            this.btn_ImprimirRepFac.Text = "Imprimir reporte";
            this.btn_ImprimirRepFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImprimirRepFac.UseVisualStyleBackColor = false;
            // 
            // data_RegistroFac
            // 
            this.data_RegistroFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_RegistroFac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_RegistroFac.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_RegistroFac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_RegistroFac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroFac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_RegistroFac.ColumnHeadersHeight = 30;
            this.data_RegistroFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_RegistroFac.EnableHeadersVisualStyles = false;
            this.data_RegistroFac.GridColor = System.Drawing.Color.DarkGreen;
            this.data_RegistroFac.Location = new System.Drawing.Point(9, 216);
            this.data_RegistroFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_RegistroFac.Name = "data_RegistroFac";
            this.data_RegistroFac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroFac.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.data_RegistroFac.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_RegistroFac.Size = new System.Drawing.Size(804, 259);
            this.data_RegistroFac.TabIndex = 75;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(721, 14);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 93;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Facultades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 537);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.data_RegistroFac);
            this.Controls.Add(this.btn_ImprimirRepFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelarFac);
            this.Controls.Add(this.btn_ModificarFac);
            this.Controls.Add(this.btn_RegistroFac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreFac);
            this.Controls.Add(this.foto_uni);
            this.Controls.Add(this.txt_UniADMIN);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FRM_Facultades";
            this.Text = "Registro de facultades - EduSmart";
            this.Load += new System.EventHandler(this.FRM_Facultades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroFac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CancelarFac;
        private System.Windows.Forms.Button btn_ModificarFac;
        private System.Windows.Forms.Button btn_RegistroFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreFac;
        private System.Windows.Forms.PictureBox foto_uni;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ImprimirRepFac;
        private System.Windows.Forms.DataGridView data_RegistroFac;
        private System.Windows.Forms.Label lb_Fecha;
    }
}