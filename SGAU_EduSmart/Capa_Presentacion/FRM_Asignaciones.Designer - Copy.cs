namespace Sistema_Gestión_Aula_EduSmart
{
    partial class FRM_Asignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Asignaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.icono_cerrar_form = new System.Windows.Forms.PictureBox();
            this.foto_uni = new System.Windows.Forms.PictureBox();
            this.txt_UniADMIN = new System.Windows.Forms.TextBox();
            this.txt_FechaADMIN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icono_cerrar_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(337, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "MANTENIMIENTO DE CARRERAS";
            // 
            // icono_cerrar_form
            // 
            this.icono_cerrar_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icono_cerrar_form.Image = ((System.Drawing.Image)(resources.GetObject("icono_cerrar_form.Image")));
            this.icono_cerrar_form.Location = new System.Drawing.Point(877, 2);
            this.icono_cerrar_form.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.icono_cerrar_form.Name = "icono_cerrar_form";
            this.icono_cerrar_form.Size = new System.Drawing.Size(25, 38);
            this.icono_cerrar_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono_cerrar_form.TabIndex = 86;
            this.icono_cerrar_form.TabStop = false;
            // 
            // foto_uni
            // 
            this.foto_uni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto_uni.Location = new System.Drawing.Point(8, 15);
            this.foto_uni.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.foto_uni.Name = "foto_uni";
            this.foto_uni.Size = new System.Drawing.Size(144, 66);
            this.foto_uni.TabIndex = 85;
            this.foto_uni.TabStop = false;
            // 
            // txt_UniADMIN
            // 
            this.txt_UniADMIN.Enabled = false;
            this.txt_UniADMIN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UniADMIN.Location = new System.Drawing.Point(168, 14);
            this.txt_UniADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_UniADMIN.Multiline = true;
            this.txt_UniADMIN.Name = "txt_UniADMIN";
            this.txt_UniADMIN.Size = new System.Drawing.Size(587, 26);
            this.txt_UniADMIN.TabIndex = 84;
            this.txt_UniADMIN.Text = "Nombre de la universidad";
            this.txt_UniADMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_FechaADMIN
            // 
            this.txt_FechaADMIN.Enabled = false;
            this.txt_FechaADMIN.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaADMIN.Location = new System.Drawing.Point(764, 14);
            this.txt_FechaADMIN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_FechaADMIN.Name = "txt_FechaADMIN";
            this.txt_FechaADMIN.Size = new System.Drawing.Size(98, 25);
            this.txt_FechaADMIN.TabIndex = 83;
            // 
            // FRM_Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icono_cerrar_form);
            this.Controls.Add(this.foto_uni);
            this.Controls.Add(this.txt_UniADMIN);
            this.Controls.Add(this.txt_FechaADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Asignaciones";
            this.Text = "FRM_Asignaciones";
            ((System.ComponentModel.ISupportInitialize)(this.icono_cerrar_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_uni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icono_cerrar_form;
        private System.Windows.Forms.PictureBox foto_uni;
        private System.Windows.Forms.TextBox txt_UniADMIN;
        private System.Windows.Forms.TextBox txt_FechaADMIN;
    }
}