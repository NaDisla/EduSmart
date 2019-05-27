namespace Capa_Presentacion
{
    partial class FRM_Carreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Carreras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ImprimirRepFac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CancelarCarr = new System.Windows.Forms.Button();
            this.btn_ModificarCarr = new System.Windows.Forms.Button();
            this.btn_RegistroCarr = new System.Windows.Forms.Button();
            this.foto_uni = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NombreCarr = new System.Windows.Forms.TextBox();
            this.data_RegistroCarr = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_FacultadCarr = new System.Windows.Forms.ComboBox();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.cmb_EscuelaCarr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_InactivarCarr = new System.Windows.Forms.Button();
            this.btn_BuscarCarrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroCarr)).BeginInit();
            this.SuspendLayout();
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
            this.btn_ImprimirRepFac.Location = new System.Drawing.Point(877, 482);
            this.btn_ImprimirRepFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ImprimirRepFac.Name = "btn_ImprimirRepFac";
            this.btn_ImprimirRepFac.Size = new System.Drawing.Size(179, 41);
            this.btn_ImprimirRepFac.TabIndex = 84;
            this.btn_ImprimirRepFac.Text = "Imprimir reporte";
            this.btn_ImprimirRepFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImprimirRepFac.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(421, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "MANTENIMIENTO DE CARRERAS";
            // 
            // btn_CancelarCarr
            // 
            this.btn_CancelarCarr.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CancelarCarr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarCarr.FlatAppearance.BorderSize = 0;
            this.btn_CancelarCarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarCarr.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarCarr.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_CancelarCarr.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarCarr.Image")));
            this.btn_CancelarCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarCarr.Location = new System.Drawing.Point(12, 200);
            this.btn_CancelarCarr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_CancelarCarr.Name = "btn_CancelarCarr";
            this.btn_CancelarCarr.Size = new System.Drawing.Size(123, 37);
            this.btn_CancelarCarr.TabIndex = 80;
            this.btn_CancelarCarr.Text = "Cancelar";
            this.btn_CancelarCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarCarr.UseVisualStyleBackColor = false;
            this.btn_CancelarCarr.Click += new System.EventHandler(this.btn_CancelarCarr_Click);
            // 
            // btn_ModificarCarr
            // 
            this.btn_ModificarCarr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ModificarCarr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarCarr.FlatAppearance.BorderSize = 0;
            this.btn_ModificarCarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarCarr.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarCarr.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarCarr.Image")));
            this.btn_ModificarCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarCarr.Location = new System.Drawing.Point(770, 151);
            this.btn_ModificarCarr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_ModificarCarr.Name = "btn_ModificarCarr";
            this.btn_ModificarCarr.Size = new System.Drawing.Size(129, 40);
            this.btn_ModificarCarr.TabIndex = 79;
            this.btn_ModificarCarr.Text = "Modificar";
            this.btn_ModificarCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ModificarCarr.UseVisualStyleBackColor = false;
            this.btn_ModificarCarr.Click += new System.EventHandler(this.btn_ModificarCarr_Click);
            // 
            // btn_RegistroCarr
            // 
            this.btn_RegistroCarr.BackColor = System.Drawing.Color.Green;
            this.btn_RegistroCarr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistroCarr.FlatAppearance.BorderSize = 0;
            this.btn_RegistroCarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistroCarr.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistroCarr.ForeColor = System.Drawing.Color.White;
            this.btn_RegistroCarr.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistroCarr.Image")));
            this.btn_RegistroCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistroCarr.Location = new System.Drawing.Point(615, 151);
            this.btn_RegistroCarr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_RegistroCarr.Name = "btn_RegistroCarr";
            this.btn_RegistroCarr.Size = new System.Drawing.Size(119, 40);
            this.btn_RegistroCarr.TabIndex = 78;
            this.btn_RegistroCarr.Text = "Registrar";
            this.btn_RegistroCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RegistroCarr.UseVisualStyleBackColor = false;
            this.btn_RegistroCarr.Click += new System.EventHandler(this.btn_RegistroCarr_Click);
            // 
            // foto_uni
            // 
            this.foto_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto_uni.Location = new System.Drawing.Point(12, 15);
            this.foto_uni.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.foto_uni.Name = "foto_uni";
            this.foto_uni.Size = new System.Drawing.Size(144, 66);
            this.foto_uni.TabIndex = 77;
            this.foto_uni.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(172, 14);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(734, 26);
            this.txt_UniADMIN.TabIndex = 76;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 88;
            this.label4.Text = "Nombre:";
            // 
            // txt_NombreCarr
            // 
            this.txt_NombreCarr.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreCarr.Location = new System.Drawing.Point(93, 110);
            this.txt_NombreCarr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NombreCarr.MaxLength = 63;
            this.txt_NombreCarr.Name = "txt_NombreCarr";
            this.txt_NombreCarr.Size = new System.Drawing.Size(490, 23);
            this.txt_NombreCarr.TabIndex = 87;
            // 
            // data_RegistroCarr
            // 
            this.data_RegistroCarr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_RegistroCarr.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_RegistroCarr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_RegistroCarr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroCarr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_RegistroCarr.ColumnHeadersHeight = 30;
            this.data_RegistroCarr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_RegistroCarr.EnableHeadersVisualStyles = false;
            this.data_RegistroCarr.GridColor = System.Drawing.Color.Green;
            this.data_RegistroCarr.Location = new System.Drawing.Point(10, 247);
            this.data_RegistroCarr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_RegistroCarr.Name = "data_RegistroCarr";
            this.data_RegistroCarr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_RegistroCarr.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.data_RegistroCarr.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_RegistroCarr.Size = new System.Drawing.Size(1046, 227);
            this.data_RegistroCarr.TabIndex = 93;
            this.data_RegistroCarr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_RegistroCarr_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Facultad:";
            // 
            // cmb_FacultadCarr
            // 
            this.cmb_FacultadCarr.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FacultadCarr.FormattingEnabled = true;
            this.cmb_FacultadCarr.Location = new System.Drawing.Point(93, 155);
            this.cmb_FacultadCarr.Name = "cmb_FacultadCarr";
            this.cmb_FacultadCarr.Size = new System.Drawing.Size(490, 26);
            this.cmb_FacultadCarr.TabIndex = 94;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha.ForeColor = System.Drawing.Color.Green;
            this.lb_Fecha.Location = new System.Drawing.Point(962, 15);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(54, 22);
            this.lb_Fecha.TabIndex = 95;
            this.lb_Fecha.Text = "Fecha";
            this.lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_EscuelaCarr
            // 
            this.cmb_EscuelaCarr.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EscuelaCarr.FormattingEnabled = true;
            this.cmb_EscuelaCarr.Location = new System.Drawing.Point(698, 110);
            this.cmb_EscuelaCarr.Name = "cmb_EscuelaCarr";
            this.cmb_EscuelaCarr.Size = new System.Drawing.Size(358, 26);
            this.cmb_EscuelaCarr.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Escuela:";
            // 
            // btn_InactivarCarr
            // 
            this.btn_InactivarCarr.BackColor = System.Drawing.Color.IndianRed;
            this.btn_InactivarCarr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InactivarCarr.FlatAppearance.BorderSize = 0;
            this.btn_InactivarCarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InactivarCarr.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InactivarCarr.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_InactivarCarr.Image = ((System.Drawing.Image)(resources.GetObject("btn_InactivarCarr.Image")));
            this.btn_InactivarCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InactivarCarr.Location = new System.Drawing.Point(930, 151);
            this.btn_InactivarCarr.Name = "btn_InactivarCarr";
            this.btn_InactivarCarr.Size = new System.Drawing.Size(126, 40);
            this.btn_InactivarCarr.TabIndex = 118;
            this.btn_InactivarCarr.Text = "Inactivar";
            this.btn_InactivarCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InactivarCarr.UseVisualStyleBackColor = false;
            // 
            // btn_BuscarCarrera
            // 
            this.btn_BuscarCarrera.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_BuscarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarCarrera.FlatAppearance.BorderSize = 0;
            this.btn_BuscarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCarrera.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCarrera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BuscarCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarCarrera.Image")));
            this.btn_BuscarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarCarrera.Location = new System.Drawing.Point(869, 200);
            this.btn_BuscarCarrera.Name = "btn_BuscarCarrera";
            this.btn_BuscarCarrera.Size = new System.Drawing.Size(187, 41);
            this.btn_BuscarCarrera.TabIndex = 119;
            this.btn_BuscarCarrera.Text = "Buscar por escuela";
            this.btn_BuscarCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscarCarrera.UseVisualStyleBackColor = false;
            this.btn_BuscarCarrera.Click += new System.EventHandler(this.btn_BuscarCarrera_Click);
            // 
            // FRM_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 530);
            this.Controls.Add(this.btn_BuscarCarrera);
            this.Controls.Add(this.btn_InactivarCarr);
            this.Controls.Add(this.cmb_EscuelaCarr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.cmb_FacultadCarr);
            this.Controls.Add(this.data_RegistroCarr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreCarr);
            this.Controls.Add(this.btn_ImprimirRepFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelarCarr);
            this.Controls.Add(this.btn_ModificarCarr);
            this.Controls.Add(this.btn_RegistroCarr);
            this.Controls.Add(this.foto_uni);
            this.Controls.Add(this.txt_UniADMIN);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FRM_Carreras";
            this.Text = "EduSmart - Mantenimeinto de Carreras";
            this.Load += new System.EventHandler(this.FRM_Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RegistroCarr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ImprimirRepFac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CancelarCarr;
        private System.Windows.Forms.Button btn_ModificarCarr;
        private System.Windows.Forms.Button btn_RegistroCarr;
        private System.Windows.Forms.PictureBox foto_uni;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NombreCarr;
        private System.Windows.Forms.DataGridView data_RegistroCarr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_FacultadCarr;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.ComboBox cmb_EscuelaCarr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_InactivarCarr;
        private System.Windows.Forms.Button btn_BuscarCarrera;
    }
}