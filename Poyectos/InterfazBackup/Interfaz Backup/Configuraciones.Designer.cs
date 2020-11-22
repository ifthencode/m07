namespace Interfaz_Backup
{
    partial class Configuraciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuraciones));
            this.gpConfiguraciones = new System.Windows.Forms.GroupBox();
            this.cbrepeticion = new System.Windows.Forms.ComboBox();
            this.labelrepeticion = new System.Windows.Forms.Label();
            this.labeltipo = new System.Windows.Forms.Label();
            this.guardarPantallaConf = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.dtApertura = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gpConfiguraciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpConfiguraciones
            // 
            this.gpConfiguraciones.BackColor = System.Drawing.SystemColors.Control;
            this.gpConfiguraciones.Controls.Add(this.cbrepeticion);
            this.gpConfiguraciones.Controls.Add(this.labelrepeticion);
            this.gpConfiguraciones.Controls.Add(this.labeltipo);
            this.gpConfiguraciones.Controls.Add(this.guardarPantallaConf);
            this.gpConfiguraciones.Controls.Add(this.cbTipo);
            this.gpConfiguraciones.Controls.Add(this.dtApertura);
            this.gpConfiguraciones.Controls.Add(this.fechaInicio);
            this.gpConfiguraciones.Location = new System.Drawing.Point(45, 33);
            this.gpConfiguraciones.Name = "gpConfiguraciones";
            this.gpConfiguraciones.Size = new System.Drawing.Size(710, 385);
            this.gpConfiguraciones.TabIndex = 14;
            this.gpConfiguraciones.TabStop = false;
            // 
            // cbrepeticion
            // 
            this.cbrepeticion.BackColor = System.Drawing.SystemColors.Control;
            this.cbrepeticion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrepeticion.FormattingEnabled = true;
            this.cbrepeticion.Location = new System.Drawing.Point(498, 62);
            this.cbrepeticion.Name = "cbrepeticion";
            this.cbrepeticion.Size = new System.Drawing.Size(121, 21);
            this.cbrepeticion.TabIndex = 14;
            this.cbrepeticion.SelectedIndexChanged += new System.EventHandler(this.cbrepeticion_SelectedIndexChanged);
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
            this.cbTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Location = new System.Drawing.Point(22, 63);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // dtApertura
            // 
            this.dtApertura.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
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
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpConfiguraciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuraciones";
            this.Text = "Configuraciones";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gpConfiguraciones.ResumeLayout(false);
            this.gpConfiguraciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpConfiguraciones;
        private System.Windows.Forms.ComboBox cbrepeticion;
        private System.Windows.Forms.Label labelrepeticion;
        private System.Windows.Forms.Label labeltipo;
        private System.Windows.Forms.Button guardarPantallaConf;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DateTimePicker dtApertura;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}