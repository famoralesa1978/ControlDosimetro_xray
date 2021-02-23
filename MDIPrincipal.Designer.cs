namespace ControlDosimetro
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Versión 8.0.1.0");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Versión 8.0.1.1");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Versión 8.0.1.2");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Versión 8.0.1.3");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Versión 8.0.1.5");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Versión del sistema y sus actualizaciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.mnuProceso = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuProcesoIngresarDosis = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuProcesoDosisISP = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuProcesoInformeGenerado = new System.Windows.Forms.ToolStripMenuItem();
			this.porFacturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFactura = new System.Windows.Forms.ToolStripMenuItem();
			this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tstUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tstNombre = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.stsHora = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.tsbPrincipal = new System.Windows.Forms.ToolStrip();
			this.tsbPrincipalCambioContraseña = new System.Windows.Forms.ToolStripButton();
			this.tsbPrincipalCambioContraseñaCliente = new System.Windows.Forms.ToolStripButton();
			this.tsbPrincipalCliente = new System.Windows.Forms.ToolStripButton();
			this.tsbPrincipalPersonal = new System.Windows.Forms.ToolStripButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tsbPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProceso,
            this.mnuFactura});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1059, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// mnuProceso
			// 
			this.mnuProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcesoIngresarDosis,
            this.mnuProcesoDosisISP,
            this.mnuProcesoInformeGenerado,
            this.porFacturarToolStripMenuItem});
			this.mnuProceso.Name = "mnuProceso";
			this.mnuProceso.Size = new System.Drawing.Size(61, 20);
			this.mnuProceso.Tag = "200";
			this.mnuProceso.Text = "Proceso";
			this.mnuProceso.Visible = false;
			// 
			// mnuProcesoIngresarDosis
			// 
			this.mnuProcesoIngresarDosis.Name = "mnuProcesoIngresarDosis";
			this.mnuProcesoIngresarDosis.Size = new System.Drawing.Size(181, 22);
			this.mnuProcesoIngresarDosis.Text = "Ingresar Dosis";
			this.mnuProcesoIngresarDosis.Visible = false;
			this.mnuProcesoIngresarDosis.Click += new System.EventHandler(this.MnuProcesoIngresarDosis_Click);
			// 
			// mnuProcesoDosisISP
			// 
			this.mnuProcesoDosisISP.Name = "mnuProcesoDosisISP";
			this.mnuProcesoDosisISP.Size = new System.Drawing.Size(181, 22);
			this.mnuProcesoDosisISP.Text = "Dosis ISP";
			this.mnuProcesoDosisISP.Click += new System.EventHandler(this.MnuProcesoDosisISP_Click);
			// 
			// mnuProcesoInformeGenerado
			// 
			this.mnuProcesoInformeGenerado.Name = "mnuProcesoInformeGenerado";
			this.mnuProcesoInformeGenerado.Size = new System.Drawing.Size(181, 22);
			this.mnuProcesoInformeGenerado.Text = "Proceso Facturación";
			this.mnuProcesoInformeGenerado.Click += new System.EventHandler(this.MnuProcesoInformeGenerado_Click);
			// 
			// porFacturarToolStripMenuItem
			// 
			this.porFacturarToolStripMenuItem.Name = "porFacturarToolStripMenuItem";
			this.porFacturarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.porFacturarToolStripMenuItem.Text = "Por Facturar";
			this.porFacturarToolStripMenuItem.Click += new System.EventHandler(this.PorFacturarToolStripMenuItem_Click);
			// 
			// mnuFactura
			// 
			this.mnuFactura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
			this.mnuFactura.Name = "mnuFactura";
			this.mnuFactura.Size = new System.Drawing.Size(63, 20);
			this.mnuFactura.Tag = "700";
			this.mnuFactura.Text = "Facturas";
			this.mnuFactura.Visible = false;
			// 
			// facturaciónToolStripMenuItem
			// 
			this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
			this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.facturaciónToolStripMenuItem.Text = "Facturación";
			this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.FacturaciónToolStripMenuItem_Click);
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tstUsuario,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tstNombre,
            this.toolStripStatusLabel4,
            this.stsHora});
			this.statusStrip.Location = new System.Drawing.Point(0, 431);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1059, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 17);
			this.toolStripStatusLabel1.Text = "Usuario";
			// 
			// tstUsuario
			// 
			this.tstUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tstUsuario.Name = "tstUsuario";
			this.tstUsuario.Size = new System.Drawing.Size(99, 17);
			this.tstUsuario.Text = "Nombre Usuario";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel2.Text = "|";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(58, 17);
			this.toolStripStatusLabel3.Text = "Nombre :";
			// 
			// tstNombre
			// 
			this.tstNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tstNombre.Name = "tstNombre";
			this.tstNombre.Size = new System.Drawing.Size(99, 17);
			this.tstNombre.Text = "Nombre Usuario";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel4.Text = "|";
			// 
			// stsHora
			// 
			this.stsHora.Name = "stsHora";
			this.stsHora.Size = new System.Drawing.Size(0, 17);
			this.stsHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.stsHora.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
			this.toolStripStatusLabel.Text = "Estado";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1059, 368);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1059, 407);
			this.toolStripContainer1.TabIndex = 3;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsbPrincipal);
			this.toolStripContainer1.TopToolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(209, 29);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(542, 319);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(206, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Actualizaciones del sistema";
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(859, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 368);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 368);
			this.panel1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Nodo1";
			treeNode1.Text = "Versión 8.0.1.0";
			treeNode2.Name = "Nodo2";
			treeNode2.Text = "Versión 8.0.1.1";
			treeNode3.Name = "Nodo3";
			treeNode3.Text = "Versión 8.0.1.2";
			treeNode4.Name = "Nodo4";
			treeNode4.Text = "Versión 8.0.1.3";
			treeNode5.Name = "Nodo5";
			treeNode5.Text = "Versión 8.0.1.5";
			treeNode6.Name = "Nodo0";
			treeNode6.Text = "Versión del sistema y sus actualizaciones";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
			this.treeView1.Size = new System.Drawing.Size(200, 368);
			this.treeView1.TabIndex = 0;
			this.treeView1.Click += new System.EventHandler(this.TreeView1_Click);
			this.treeView1.DoubleClick += new System.EventHandler(this.TreeView1_DoubleClick);
			// 
			// tsbPrincipal
			// 
			this.tsbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tsbPrincipal.Dock = System.Windows.Forms.DockStyle.None;
			this.tsbPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.tsbPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrincipalCambioContraseña,
            this.tsbPrincipalCambioContraseñaCliente,
            this.tsbPrincipalCliente,
            this.tsbPrincipalPersonal});
			this.tsbPrincipal.Location = new System.Drawing.Point(0, 0);
			this.tsbPrincipal.Name = "tsbPrincipal";
			this.tsbPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tsbPrincipal.Size = new System.Drawing.Size(1059, 39);
			this.tsbPrincipal.Stretch = true;
			this.tsbPrincipal.TabIndex = 2;
			// 
			// tsbPrincipalCambioContraseña
			// 
			this.tsbPrincipalCambioContraseña.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrincipalCambioContraseña.Image = global::ControlDosimetro.Properties.Resources.CambioContrasena;
			this.tsbPrincipalCambioContraseña.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrincipalCambioContraseña.Name = "tsbPrincipalCambioContraseña";
			this.tsbPrincipalCambioContraseña.Size = new System.Drawing.Size(36, 36);
			this.tsbPrincipalCambioContraseña.Text = "Cambio contraseña";
			this.tsbPrincipalCambioContraseña.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.tsbPrincipalCambioContraseña.Click += new System.EventHandler(this.TsbPrincipal_Click);
			// 
			// tsbPrincipalCambioContraseñaCliente
			// 
			this.tsbPrincipalCambioContraseñaCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrincipalCambioContraseñaCliente.Image = global::ControlDosimetro.Properties.Resources.CambioContrasenaCliente;
			this.tsbPrincipalCambioContraseñaCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrincipalCambioContraseñaCliente.Name = "tsbPrincipalCambioContraseñaCliente";
			this.tsbPrincipalCambioContraseñaCliente.Size = new System.Drawing.Size(36, 36);
			this.tsbPrincipalCambioContraseñaCliente.Text = "Restablecer";
			this.tsbPrincipalCambioContraseñaCliente.ToolTipText = "Restablecer  contraseña cliente";
			this.tsbPrincipalCambioContraseñaCliente.Click += new System.EventHandler(this.TsbPrincipal_Click);
			// 
			// tsbPrincipalCliente
			// 
			this.tsbPrincipalCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrincipalCliente.Image = global::ControlDosimetro.Properties.Resources.client;
			this.tsbPrincipalCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrincipalCliente.Name = "tsbPrincipalCliente";
			this.tsbPrincipalCliente.Size = new System.Drawing.Size(36, 36);
			this.tsbPrincipalCliente.Text = "Cliente";
			this.tsbPrincipalCliente.ToolTipText = "Cliente";
			this.tsbPrincipalCliente.Click += new System.EventHandler(this.TsbPrincipal_Click);
			// 
			// tsbPrincipalPersonal
			// 
			this.tsbPrincipalPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrincipalPersonal.Image = global::ControlDosimetro.Properties.Resources.Personal1;
			this.tsbPrincipalPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrincipalPersonal.Name = "tsbPrincipalPersonal";
			this.tsbPrincipalPersonal.Size = new System.Drawing.Size(36, 36);
			this.tsbPrincipalPersonal.Text = "Personal";
			this.tsbPrincipalPersonal.Click += new System.EventHandler(this.TsbPrincipal_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// MDIPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 453);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MDIPrincipal";
			this.Text = "Sistema de control dosimetro";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIPrincipal_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tsbPrincipal.ResumeLayout(false);
			this.tsbPrincipal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip tsbPrincipal;
        private System.Windows.Forms.ToolStripButton tsbPrincipalCliente;
		  private System.Windows.Forms.ToolStripButton tsbPrincipalPersonal;
          private System.Windows.Forms.ToolStripMenuItem mnuProceso;
          private System.Windows.Forms.ToolStripMenuItem mnuProcesoInformeGenerado;
          private System.Windows.Forms.ToolStripMenuItem porFacturarToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem mnuFactura;
          private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem mnuProcesoIngresarDosis;
          private System.Windows.Forms.ToolStripMenuItem mnuProcesoDosisISP;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
          private System.Windows.Forms.ToolStripStatusLabel tstUsuario;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
          private System.Windows.Forms.ToolStripStatusLabel tstNombre;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
          private System.Windows.Forms.ToolStripStatusLabel stsHora;
          private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.RichTextBox richTextBox1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton tsbPrincipalCambioContraseña;
        private System.Windows.Forms.ToolStripButton tsbPrincipalCambioContraseñaCliente;
	}
}



