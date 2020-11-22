namespace Interfaz_Backup
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbrepeticion = new System.Windows.Forms.ComboBox();
            this.labelrepeticion = new System.Windows.Forms.Label();
            this.labeltipo = new System.Windows.Forms.Label();
            this.guardarPantallaConf = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.dtApertura = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbrepeticion);
            this.groupBox1.Controls.Add(this.labelrepeticion);
            this.groupBox1.Controls.Add(this.labeltipo);
            this.groupBox1.Controls.Add(this.guardarPantallaConf);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.dtApertura);
            this.groupBox1.Controls.Add(this.fechaInicio);
            this.groupBox1.Location = new System.Drawing.Point(45, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 385);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // cbrepeticion
            // 
            this.cbrepeticion.FormattingEnabled = true;
            this.cbrepeticion.Location = new System.Drawing.Point(498, 62);
            this.cbrepeticion.Name = "cbrepeticion";
            this.cbrepeticion.Size = new System.Drawing.Size(121, 21);
            this.cbrepeticion.TabIndex = 14;
            // 
            // labelrepeticion
            // 
            this.labelrepeticion.AutoSize = true;
            this.labelrepeticion.Location = new System.Drawing.Point(505, 28);
            this.labelrepeticion.Name = "labelrepeticion";
            this.labelrepeticion.Size = new System.Drawing.Size(114, 13);
            this.labelrepeticion.TabIndex = 13;
            this.labelrepeticion.Text = "Repeticion de la Copia";
            // 
            // labeltipo
            // 
            this.labeltipo.AutoSize = true;
            this.labeltipo.Location = new System.Drawing.Point(36, 28);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(58, 13);
            this.labeltipo.TabIndex = 0;
            this.labeltipo.Text = "Tipo Copia";
            // 
            // guardarPantallaConf
            // 
            this.guardarPantallaConf.Location = new System.Drawing.Point(508, 255);
            this.guardarPantallaConf.Name = "guardarPantallaConf";
            this.guardarPantallaConf.Size = new System.Drawing.Size(75, 23);
            this.guardarPantallaConf.TabIndex = 12;
            this.guardarPantallaConf.Text = "Guardar";
            this.guardarPantallaConf.UseVisualStyleBackColor = true;
            this.guardarPantallaConf.Click += new System.EventHandler(this.guardarPantallaConf_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Location = new System.Drawing.Point(17, 62);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            // 
            // dtApertura
            // 
            this.dtApertura.Location = new System.Drawing.Point(228, 63);
            this.dtApertura.Name = "dtApertura";
            this.dtApertura.Size = new System.Drawing.Size(200, 20);
            this.dtApertura.TabIndex = 9;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Location = new System.Drawing.Point(265, 28);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(105, 13);
            this.fechaInicio.TabIndex = 8;
            this.fechaInicio.Text = "Fecha Inicio Backup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbrepeticion;
        private System.Windows.Forms.Label labelrepeticion;
        private System.Windows.Forms.Label labeltipo;
        private System.Windows.Forms.Button guardarPantallaConf;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DateTimePicker dtApertura;
        private System.Windows.Forms.Label fechaInicio;
    }
}