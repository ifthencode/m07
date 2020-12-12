namespace Interfaz_Backup
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.lbtipo = new System.Windows.Forms.Label();
            this.lbtiposel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbFechaSel = new System.Windows.Forms.Label();
            this.lbPeriocidad = new System.Windows.Forms.Label();
            this.lbRepeticion = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbdestinoseleccionado = new System.Windows.Forms.Label();
            this.labelseleccionado = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.elemento_seleccionado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.seleccionar_carpeta = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSeltipoEle = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbfichero = new System.Windows.Forms.RadioButton();
            this.rbCarpeta = new System.Windows.Forms.RadioButton();
            this.configuraciones = new System.Windows.Forms.Button();
            this.btDestino = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbSeltipoEle.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtipo
            // 
            this.lbtipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtipo.Location = new System.Drawing.Point(3, 0);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(276, 53);
            this.lbtipo.TabIndex = 0;
            this.lbtipo.Text = "Tipo Copia";
            this.lbtipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtiposel
            // 
            this.lbtiposel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtiposel.Location = new System.Drawing.Point(285, 0);
            this.lbtiposel.Name = "lbtiposel";
            this.lbtiposel.Size = new System.Drawing.Size(276, 53);
            this.lbtiposel.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbFechaSel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbPeriocidad, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbRepeticion, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbFecha, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbtipo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbtiposel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(579, 378);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.89916F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.10084F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 171);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lbFechaSel
            // 
            this.lbFechaSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFechaSel.Location = new System.Drawing.Point(285, 57);
            this.lbFechaSel.Name = "lbFechaSel";
            this.lbFechaSel.Size = new System.Drawing.Size(276, 50);
            this.lbFechaSel.TabIndex = 4;
            // 
            // lbPeriocidad
            // 
            this.lbPeriocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPeriocidad.Location = new System.Drawing.Point(285, 119);
            this.lbPeriocidad.Name = "lbPeriocidad";
            this.lbPeriocidad.Size = new System.Drawing.Size(276, 49);
            this.lbPeriocidad.TabIndex = 5;
            // 
            // lbRepeticion
            // 
            this.lbRepeticion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRepeticion.Location = new System.Drawing.Point(3, 119);
            this.lbRepeticion.Name = "lbRepeticion";
            this.lbRepeticion.Size = new System.Drawing.Size(276, 49);
            this.lbRepeticion.TabIndex = 2;
            this.lbRepeticion.Text = "Periodicidad";
            this.lbRepeticion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFecha
            // 
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.Location = new System.Drawing.Point(3, 57);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(276, 50);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha Inicio";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDestino
            // 
            this.lbDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDestino.Location = new System.Drawing.Point(3, 59);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(269, 50);
            this.lbDestino.TabIndex = 4;
            this.lbDestino.Text = "Carpeta destino";
            this.lbDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdestinoseleccionado
            // 
            this.lbdestinoseleccionado.BackColor = System.Drawing.SystemColors.Control;
            this.lbdestinoseleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbdestinoseleccionado.Location = new System.Drawing.Point(284, 59);
            this.lbdestinoseleccionado.Name = "lbdestinoseleccionado";
            this.lbdestinoseleccionado.Size = new System.Drawing.Size(282, 50);
            this.lbdestinoseleccionado.TabIndex = 5;
            // 
            // labelseleccionado
            // 
            this.labelseleccionado.BackColor = System.Drawing.SystemColors.Control;
            this.labelseleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelseleccionado.Location = new System.Drawing.Point(284, 0);
            this.labelseleccionado.Name = "labelseleccionado";
            this.labelseleccionado.Size = new System.Drawing.Size(282, 53);
            this.labelseleccionado.TabIndex = 3;
            this.labelseleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(3, 121);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(136, 32);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // elemento_seleccionado
            // 
            this.elemento_seleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elemento_seleccionado.Location = new System.Drawing.Point(3, 0);
            this.elemento_seleccionado.Name = "elemento_seleccionado";
            this.elemento_seleccionado.Size = new System.Drawing.Size(269, 53);
            this.elemento_seleccionado.TabIndex = 2;
            this.elemento_seleccionado.Text = "Elemento Origen";
            this.elemento_seleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.55117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.44883F));
            this.tableLayoutPanel1.Controls.Add(this.lbDestino, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbdestinoseleccionado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.elemento_seleccionado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelseleccionado, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 378);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 171);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // seleccionar_carpeta
            // 
            this.seleccionar_carpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seleccionar_carpeta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionar_carpeta.Location = new System.Drawing.Point(6, 75);
            this.seleccionar_carpeta.Name = "seleccionar_carpeta";
            this.seleccionar_carpeta.Size = new System.Drawing.Size(490, 45);
            this.seleccionar_carpeta.TabIndex = 1;
            this.seleccionar_carpeta.Text = "Seleccionar Directorio Origen";
            this.seleccionar_carpeta.UseVisualStyleBackColor = true;
            this.seleccionar_carpeta.Visible = false;
            this.seleccionar_carpeta.Click += new System.EventHandler(this.seleccionar_carpeta_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1132, 41);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel3.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1021, 32);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(124, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPantallaPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D6)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionesToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "&Edicion";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.configuracionesToolStripMenuItem.Text = "&Configuraciones";
            this.configuracionesToolStripMenuItem.Click += new System.EventHandler(this.configuracionesToolStripMenuItem_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.04492F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.95508F));
            this.tableLayoutPanel3.Controls.Add(this.gbSeltipoEle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.configuraciones, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btDestino, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 99);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.63731F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.36269F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1131, 263);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // gbSeltipoEle
            // 
            this.gbSeltipoEle.Controls.Add(this.tableLayoutPanel4);
            this.gbSeltipoEle.Controls.Add(this.seleccionar_carpeta);
            this.gbSeltipoEle.Location = new System.Drawing.Point(3, 3);
            this.gbSeltipoEle.Name = "gbSeltipoEle";
            this.gbSeltipoEle.Size = new System.Drawing.Size(499, 156);
            this.gbSeltipoEle.TabIndex = 8;
            this.gbSeltipoEle.TabStop = false;
            this.gbSeltipoEle.Text = "Selecciona Tipo Elemento";
            this.gbSeltipoEle.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rbfichero, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbCarpeta, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 29);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(279, 40);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // rbfichero
            // 
            this.rbfichero.AutoSize = true;
            this.rbfichero.Location = new System.Drawing.Point(3, 3);
            this.rbfichero.Name = "rbfichero";
            this.rbfichero.Size = new System.Drawing.Size(60, 17);
            this.rbfichero.TabIndex = 5;
            this.rbfichero.TabStop = true;
            this.rbfichero.Text = "Fichero";
            this.rbfichero.UseVisualStyleBackColor = true;
            this.rbfichero.CheckedChanged += new System.EventHandler(this.rbfichero_CheckedChanged);
            // 
            // rbCarpeta
            // 
            this.rbCarpeta.AutoSize = true;
            this.rbCarpeta.Location = new System.Drawing.Point(142, 3);
            this.rbCarpeta.Name = "rbCarpeta";
            this.rbCarpeta.Size = new System.Drawing.Size(70, 17);
            this.rbCarpeta.TabIndex = 6;
            this.rbCarpeta.TabStop = true;
            this.rbCarpeta.Text = "Directorio";
            this.rbCarpeta.UseVisualStyleBackColor = true;
            this.rbCarpeta.CheckedChanged += new System.EventHandler(this.rbCarpeta_CheckedChanged);
            // 
            // configuraciones
            // 
            this.configuraciones.Location = new System.Drawing.Point(569, 196);
            this.configuraciones.Name = "configuraciones";
            this.configuraciones.Size = new System.Drawing.Size(499, 44);
            this.configuraciones.TabIndex = 6;
            this.configuraciones.Text = "Configuraciones";
            this.configuraciones.UseVisualStyleBackColor = true;
            this.configuraciones.Click += new System.EventHandler(this.configuraciones_Click_1);
            // 
            // btDestino
            // 
            this.btDestino.Location = new System.Drawing.Point(3, 196);
            this.btDestino.Name = "btDestino";
            this.btDestino.Size = new System.Drawing.Size(550, 44);
            this.btDestino.TabIndex = 5;
            this.btDestino.Text = "Seleccionar Directorio Destino";
            this.btDestino.UseVisualStyleBackColor = true;
            this.btDestino.Click += new System.EventHandler(this.btDestino_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1133, 45);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(52, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Interfaz_Backup.Properties.Resources._53344360_signo_icono_salir_salir_botón_;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 30);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.ToolTipText = "Salir(Ctrl+Alt+6)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.Text = "Interfaz Backup";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gbSeltipoEle.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbtipo;
        private System.Windows.Forms.Label lbtiposel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbFechaSel;
        private System.Windows.Forms.Label lbPeriocidad;
        private System.Windows.Forms.Label lbRepeticion;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbdestinoseleccionado;
        private System.Windows.Forms.Label labelseleccionado;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label elemento_seleccionado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button seleccionar_carpeta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btDestino;
        private System.Windows.Forms.Button configuraciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rbfichero;
        private System.Windows.Forms.RadioButton rbCarpeta;
        private System.Windows.Forms.GroupBox gbSeltipoEle;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

