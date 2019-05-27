namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Asistencia));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodigoSecc = new System.Windows.Forms.TextBox();
            this.txt_Asignatura = new System.Windows.Forms.TextBox();
            this.txt_Prof = new System.Windows.Forms.TextBox();
            this.lb_FechaAisstencia = new System.Windows.Forms.Label();
            this.foto_uni = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.data_AsistenciaEstud = new System.Windows.Forms.DataGridView();
            this.ch_Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cl_Acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_GuardarAsist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_AsistenciaEstud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(259, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 22);
            this.label1.TabIndex = 111;
            this.label1.Text = "LISTADO DE ESTUDIANTES PARA FINES DE ASISTENCIA";
            // 
            // txt_CodigoSecc
            // 
            this.txt_CodigoSecc.Enabled = false;
            this.txt_CodigoSecc.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoSecc.Location = new System.Drawing.Point(791, 99);
            this.txt_CodigoSecc.Name = "txt_CodigoSecc";
            this.txt_CodigoSecc.Size = new System.Drawing.Size(88, 23);
            this.txt_CodigoSecc.TabIndex = 110;
            // 
            // txt_Asignatura
            // 
            this.txt_Asignatura.Enabled = false;
            this.txt_Asignatura.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Asignatura.Location = new System.Drawing.Point(375, 99);
            this.txt_Asignatura.Name = "txt_Asignatura";
            this.txt_Asignatura.Size = new System.Drawing.Size(396, 23);
            this.txt_Asignatura.TabIndex = 109;
            // 
            // txt_Prof
            // 
            this.txt_Prof.Enabled = false;
            this.txt_Prof.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prof.Location = new System.Drawing.Point(12, 99);
            this.txt_Prof.Name = "txt_Prof";
            this.txt_Prof.Size = new System.Drawing.Size(344, 23);
            this.txt_Prof.TabIndex = 108;
            // 
            // lb_FechaAisstencia
            // 
            this.lb_FechaAisstencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_FechaAisstencia.AutoSize = true;
            this.lb_FechaAisstencia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FechaAisstencia.ForeColor = System.Drawing.Color.Green;
            this.lb_FechaAisstencia.Location = new System.Drawing.Point(787, 17);
            this.lb_FechaAisstencia.Name = "lb_FechaAisstencia";
            this.lb_FechaAisstencia.Size = new System.Drawing.Size(54, 22);
            this.lb_FechaAisstencia.TabIndex = 107;
            this.lb_FechaAisstencia.Text = "Fecha";
            this.lb_FechaAisstencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foto_uni
            // 
            this.foto_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto_uni.Location = new System.Drawing.Point(13, 15);
            this.foto_uni.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.foto_uni.Name = "foto_uni";
            this.foto_uni.Size = new System.Drawing.Size(144, 66);
            this.foto_uni.TabIndex = 105;
            this.foto_uni.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(173, 14);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(598, 26);
            this.txt_UniADMIN.TabIndex = 104;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_AsistenciaEstud
            // 
            this.data_AsistenciaEstud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_AsistenciaEstud.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_AsistenciaEstud.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.data_AsistenciaEstud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_AsistenciaEstud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_AsistenciaEstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_AsistenciaEstud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_Estado,
            this.cl_Acumulado});
            this.data_AsistenciaEstud.EnableHeadersVisualStyles = false;
            this.data_AsistenciaEstud.GridColor = System.Drawing.Color.DarkGreen;
            this.data_AsistenciaEstud.Location = new System.Drawing.Point(13, 141);
            this.data_AsistenciaEstud.Name = "data_AsistenciaEstud";
            this.data_AsistenciaEstud.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_AsistenciaEstud.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.data_AsistenciaEstud.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_AsistenciaEstud.Size = new System.Drawing.Size(866, 273);
            this.data_AsistenciaEstud.TabIndex = 112;
            // 
            // ch_Estado
            // 
            this.ch_Estado.HeaderText = "P/A";
            this.ch_Estado.Name = "ch_Estado";
            // 
            // cl_Acumulado
            // 
            this.cl_Acumulado.HeaderText = "Acumulado";
            this.cl_Acumulado.Name = "cl_Acumulado";
            // 
            // btn_GuardarAsist
            // 
            this.btn_GuardarAsist.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_GuardarAsist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GuardarAsist.FlatAppearance.BorderSize = 0;
            this.btn_GuardarAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarAsist.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarAsist.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarAsist.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarAsist.Image")));
            this.btn_GuardarAsist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarAsist.Location = new System.Drawing.Point(13, 420);
            this.btn_GuardarAsist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GuardarAsist.Name = "btn_GuardarAsist";
            this.btn_GuardarAsist.Size = new System.Drawing.Size(187, 42);
            this.btn_GuardarAsist.TabIndex = 113;
            this.btn_GuardarAsist.Text = "Guardar asistencia";
            this.btn_GuardarAsist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarAsist.UseVisualStyleBackColor = false;
            // 
            // FRM_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 475);
            this.Controls.Add(this.btn_GuardarAsist);
            this.Controls.Add(this.data_AsistenciaEstud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CodigoSecc);
            this.Controls.Add(this.txt_Asignatura);
            this.Controls.Add(this.txt_Prof);
            this.Controls.Add(this.lb_FechaAisstencia);
            this.Controls.Add(this.foto_uni);
            this.Controls.Add(this.txt_UniADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Asistencia";
            this.Text = "Asistencia de estudiantes";
            this.Load += new System.EventHandler(this.FRM_Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_AsistenciaEstud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodigoSecc;
        private System.Windows.Forms.TextBox txt_Asignatura;
        private System.Windows.Forms.TextBox txt_Prof;
        private System.Windows.Forms.Label lb_FechaAisstencia;
        private System.Windows.Forms.PictureBox foto_uni;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.DataGridView data_AsistenciaEstud;
        private System.Windows.Forms.Button btn_GuardarAsist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ch_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Acumulado;
    }
}