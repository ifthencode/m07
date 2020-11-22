namespace Interfaz_Backup
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionartodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elemento_seleccionado = new System.Windows.Forms.Label();
            this.labelseleccionado = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.seleccionar_carpeta = new System.Windows.Forms.Button();
            this.seleccionar_fichero = new System.Windows.Forms.Button();
            this.configuraciones = new System.Windows.Forms.Button();
            this.btDestino = new System.Windows.Forms.Button();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbdestinoseleccionado = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbtipo = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbRepeticion = new System.Windows.Forms.Label();
            this.lbtiposel = new System.Windows.Forms.Label();
            this.lbFechaSel = new System.Windows.Forms.Label();
            this.lbPeriocidad = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1131, 361);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1117, 174);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel3.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1111, 27);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.13393F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.86607F));
            this.tableLayoutPanel1.Controls.Add(this.lbDestino, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbdestinoseleccionado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelseleccionado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.elemento_seleccionado, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.08197F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.91803F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cortarToolStripMenuItem.Text = "Cor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // seleccionartodoToolStripMenuItem
            // 
            this.seleccionartodoToolStripMenuItem.Name = "seleccionartodoToolStripMenuItem";
            this.seleccionartodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seleccionartodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(66, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPantallaPrincipal";
            // 
            // elemento_seleccionado
            // 
            this.elemento_seleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elemento_seleccionado.Location = new System.Drawing.Point(3, 0);
            this.elemento_seleccionado.Name = "elemento_seleccionado";
            this.elemento_seleccionado.Size = new System.Drawing.Size(136, 53);
            this.elemento_seleccionado.TabIndex = 2;
            this.elemento_seleccionado.Text = "Elemento Origen";
            this.elemento_seleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelseleccionado
            // 
            this.labelseleccionado.BackColor = System.Drawing.SystemColors.Control;
            this.labelseleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelseleccionado.Location = new System.Drawing.Point(145, 0);
            this.labelseleccionado.Name = "labelseleccionado";
            this.labelseleccionado.Size = new System.Drawing.Size(324, 54);
            this.labelseleccionado.TabIndex = 3;
            this.labelseleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.seleccionar_fichero, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.configuraciones, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btDestino, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.seleccionar_carpeta, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1113, 100);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // seleccionar_carpeta
            // 
            this.seleccionar_carpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seleccionar_carpeta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionar_carpeta.Location = new System.Drawing.Point(3, 3);
            this.seleccionar_carpeta.Name = "seleccionar_carpeta";
            this.seleccionar_carpeta.Size = new System.Drawing.Size(550, 44);
            this.seleccionar_carpeta.TabIndex = 1;
            this.seleccionar_carpeta.Text = "Seleccionar Directorio Origen";
            this.seleccionar_carpeta.UseVisualStyleBackColor = true;
            this.seleccionar_carpeta.Click += new System.EventHandler(this.seleccionar_carpeta_Click);
            // 
            // seleccionar_fichero
            // 
            this.seleccionar_fichero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seleccionar_fichero.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionar_fichero.Location = new System.Drawing.Point(559, 3);
            this.seleccionar_fichero.Name = "seleccionar_fichero";
            this.seleccionar_fichero.Size = new System.Drawing.Size(551, 44);
            this.seleccionar_fichero.TabIndex = 3;
            this.seleccionar_fichero.Text = "Seleccionar Fichero Origen";
            this.seleccionar_fichero.UseVisualStyleBackColor = true;
            this.seleccionar_fichero.Click += new System.EventHandler(this.seleccionar_fichero_Click);
            // 
            // configuraciones
            // 
            this.configuraciones.Location = new System.Drawing.Point(3, 53);
            this.configuraciones.Name = "configuraciones";
            this.configuraciones.Size = new System.Drawing.Size(550, 44);
            this.configuraciones.TabIndex = 4;
            this.configuraciones.Text = "Configuraciones";
            this.configuraciones.UseVisualStyleBackColor = true;
            this.configuraciones.Click += new System.EventHandler(this.configuraciones_Click);
            // 
            // btDestino
            // 
            this.btDestino.Location = new System.Drawing.Point(559, 53);
            this.btDestino.Name = "btDestino";
            this.btDestino.Size = new System.Drawing.Size(551, 44);
            this.btDestino.TabIndex = 5;
            this.btDestino.Text = "Seleccionar Directorio Destino";
            this.btDestino.UseVisualStyleBackColor = true;
            this.btDestino.Click += new System.EventHandler(this.btDestino_Click);
            // 
            // lbDestino
            // 
            this.lbDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDestino.Location = new System.Drawing.Point(3, 60);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(136, 50);
            this.lbDestino.TabIndex = 4;
            this.lbDestino.Text = "Carpeta destino";
            this.lbDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdestinoseleccionado
            // 
            this.lbdestinoseleccionado.BackColor = System.Drawing.SystemColors.Control;
            this.lbdestinoseleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbdestinoseleccionado.Location = new System.Drawing.Point(145, 60);
            this.lbdestinoseleccionado.Name = "lbdestinoseleccionado";
            this.lbdestinoseleccionado.Size = new System.Drawing.Size(324, 50);
            this.lbdestinoseleccionado.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbtipo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbtiposel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbFechaSel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbPeriocidad, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbRepeticion, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbFecha, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(481, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(639, 171);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lbtipo
            // 
            this.lbtipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtipo.Location = new System.Drawing.Point(3, 0);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(313, 53);
            this.lbtipo.TabIndex = 0;
            this.lbtipo.Text = "Tipo Copia";
            this.lbtipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFecha
            // 
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.Location = new System.Drawing.Point(3, 54);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(313, 50);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha Inicio";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRepeticion
            // 
            this.lbRepeticion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRepeticion.Location = new System.Drawing.Point(3, 119);
            this.lbRepeticion.Name = "lbRepeticion";
            this.lbRepeticion.Size = new System.Drawing.Size(313, 49);
            this.lbRepeticion.TabIndex = 2;
            this.lbRepeticion.Text = "Periodicidad";
            this.lbRepeticion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtiposel
            // 
            this.lbtiposel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtiposel.Location = new System.Drawing.Point(322, 0);
            this.lbtiposel.Name = "lbtiposel";
            this.lbtiposel.Size = new System.Drawing.Size(313, 53);
            this.lbtiposel.TabIndex = 3;
            // 
            // lbFechaSel
            // 
            this.lbFechaSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFechaSel.Location = new System.Drawing.Point(322, 54);
            this.lbFechaSel.Name = "lbFechaSel";
            this.lbFechaSel.Size = new System.Drawing.Size(313, 50);
            this.lbFechaSel.TabIndex = 4;
            // 
            // lbPeriocidad
            // 
            this.lbPeriocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPeriocidad.Location = new System.Drawing.Point(322, 119);
            this.lbPeriocidad.Name = "lbPeriocidad";
            this.lbPeriocidad.Size = new System.Drawing.Size(313, 49);
            this.lbPeriocidad.TabIndex = 5;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(3, 136);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(136, 32);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1129, 359);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Incidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem seleccionartodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label elemento_seleccionado;
        private System.Windows.Forms.Label labelseleccionado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button seleccionar_carpeta;
        private System.Windows.Forms.Button seleccionar_fichero;
        private System.Windows.Forms.Button configuraciones;
        private System.Windows.Forms.Button btDestino;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbdestinoseleccionado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbtipo;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbRepeticion;
        private System.Windows.Forms.Label lbtiposel;
        private System.Windows.Forms.Label lbFechaSel;
        private System.Windows.Forms.Label lbPeriocidad;
        private System.Windows.Forms.Button btGuardar;
    }
}

