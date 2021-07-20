namespace ControlDosimetro
{
    partial class frmMantenedorCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenedorCliente));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.stsEstado = new System.Windows.Forms.StatusStrip();
			this.tssDescEstado = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssEstado = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
			this.tsdReporte = new System.Windows.Forms.ToolStripDropDownButton();
			this.scPrincipal = new System.Windows.Forms.SplitContainer();
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.gpxListado = new System.Windows.Forms.GroupBox();
			this.dgvGrilla = new System.Windows.Forms.DataGridView();
			this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
			this.gpxFiltrar = new System.Windows.Forms.GroupBox();
			this.cbx_id_estadoBuscar = new System.Windows.Forms.ComboBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRut = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPrincipal = new System.Windows.Forms.TabControl();
			this.tabCliente = new System.Windows.Forms.TabPage();
			this.tabSucursal = new System.Windows.Forms.TabPage();
			this.tbl_Usuario = new System.Windows.Forms.GroupBox();
			this.txt_id_tipo_doc = new System.Windows.Forms.TextBox();
			this.lbl_Fecha_agregado = new System.Windows.Forms.Label();
			this.lbl_Fecha_Modificacion = new System.Windows.Forms.Label();
			this.lbl_Id_Usuario = new System.Windows.Forms.Label();
			this.cbx_Id_estado = new System.Windows.Forms.ComboBox();
			this.cbx_Id_perfil = new System.Windows.Forms.ComboBox();
			this.txt_Contraseña = new System.Windows.Forms.TextBox();
			this.txt_Contraseña1 = new System.Windows.Forms.TextBox();
			this.txt_Maternos = new System.Windows.Forms.TextBox();
			this.txt_paterno = new System.Windows.Forms.TextBox();
			this.txt_Nombres = new System.Windows.Forms.TextBox();
			this.txt_rut = new System.Windows.Forms.TextBox();
			this.txt_Usuario = new System.Windows.Forms.TextBox();
			this.lbl_Contraseña = new System.Windows.Forms.Label();
			this.lbl_id_estado = new System.Windows.Forms.Label();
			this.lbl_Id_perfil = new System.Windows.Forms.Label();
			this.lbl_Maternos = new System.Windows.Forms.Label();
			this.lbl_Paterno = new System.Windows.Forms.Label();
			this.lbl_Nombres = new System.Windows.Forms.Label();
			this.lbl_rut = new System.Windows.Forms.Label();
			this.lbl_Usuario = new System.Windows.Forms.Label();
			this.btn_Minimizar = new System.Windows.Forms.Button();
			this.btn_Limpiar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.tabPersonal = new System.Windows.Forms.TabPage();
			this.stsEstado.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
			this.scPrincipal.Panel1.SuspendLayout();
			this.scPrincipal.Panel2.SuspendLayout();
			this.scPrincipal.SuspendLayout();
			this.pnlPrincipal.SuspendLayout();
			this.gpxListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
			this.cmsMenuContexto.SuspendLayout();
			this.gpxFiltrar.SuspendLayout();
			this.tabPrincipal.SuspendLayout();
			this.tabCliente.SuspendLayout();
			this.tbl_Usuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 551);
			this.stsEstado.Name = "stsEstado";
			this.stsEstado.Size = new System.Drawing.Size(854, 22);
			this.stsEstado.TabIndex = 0;
			this.stsEstado.Text = "statusStrip1";
			// 
			// tssDescEstado
			// 
			this.tssDescEstado.Name = "tssDescEstado";
			this.tssDescEstado.Size = new System.Drawing.Size(42, 17);
			this.tssDescEstado.Text = "Estado";
			// 
			// tssEstado
			// 
			this.tssEstado.Name = "tssEstado";
			this.tssEstado.Size = new System.Drawing.Size(39, 17);
			this.tssEstado.Text = "Status";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsdReporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(854, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAgregar
			// 
			this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregar.Name = "tsbAgregar";
			this.tsbAgregar.Size = new System.Drawing.Size(23, 22);
			this.tsbAgregar.Text = "Permite  agregar un perfil de usuario";
			this.tsbAgregar.Click += new System.EventHandler(this.TsbAgregar_Click);
			// 
			// tsdReporte
			// 
			this.tsdReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsdReporte.Image")));
			this.tsdReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdReporte.Name = "tsdReporte";
			this.tsdReporte.Size = new System.Drawing.Size(61, 22);
			this.tsdReporte.Text = "Reporte";
			// 
			// scPrincipal
			// 
			this.scPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scPrincipal.Location = new System.Drawing.Point(0, 25);
			this.scPrincipal.Name = "scPrincipal";
			// 
			// scPrincipal.Panel1
			// 
			this.scPrincipal.Panel1.AutoScroll = true;
			this.scPrincipal.Panel1.AutoScrollMinSize = new System.Drawing.Size(200, 0);
			this.scPrincipal.Panel1.Controls.Add(this.pnlPrincipal);
			this.scPrincipal.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel1MinSize = 250;
			// 
			// scPrincipal.Panel2
			// 
			this.scPrincipal.Panel2.Controls.Add(this.tabPrincipal);
			this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel2MinSize = 200;
			this.scPrincipal.Size = new System.Drawing.Size(842, 523);
			this.scPrincipal.SplitterDistance = 417;
			this.scPrincipal.TabIndex = 2;
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPrincipal.Controls.Add(this.gpxListado);
			this.pnlPrincipal.Controls.Add(this.gpxFiltrar);
			this.pnlPrincipal.Location = new System.Drawing.Point(15, 3);
			this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(397, 517);
			this.pnlPrincipal.TabIndex = 1;
			// 
			// gpxListado
			// 
			this.gpxListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpxListado.Controls.Add(this.dgvGrilla);
			this.gpxListado.Location = new System.Drawing.Point(3, 144);
			this.gpxListado.Name = "gpxListado";
			this.gpxListado.Size = new System.Drawing.Size(389, 368);
			this.gpxListado.TabIndex = 4;
			this.gpxListado.TabStop = false;
			this.gpxListado.Text = "Listado";
			// 
			// dgvGrilla
			// 
			this.dgvGrilla.AllowUserToAddRows = false;
			this.dgvGrilla.AllowUserToDeleteRows = false;
			this.dgvGrilla.AllowUserToOrderColumns = true;
			this.dgvGrilla.AllowUserToResizeColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvGrilla.ColumnHeadersHeight = 42;
			this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUsuario,
            this.ColNombres});
			this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(383, 349);
			this.dgvGrilla.TabIndex = 0;
			this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrilla_CellDoubleClick);
			this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DgvGrilla_ColumnWidthChanged);
			this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.DgvGrilla_Paint);
			// 
			// cmsMenuContexto
			// 
			this.cmsMenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.tsmAsignarPermiso});
			this.cmsMenuContexto.Name = "cmsMenuContexto";
			this.cmsMenuContexto.Size = new System.Drawing.Size(161, 60);
			// 
			// tsmActualizar
			// 
			this.tsmActualizar.Name = "tsmActualizar";
			this.tsmActualizar.Size = new System.Drawing.Size(160, 22);
			this.tsmActualizar.Text = "Modificar";
			this.tsmActualizar.Click += new System.EventHandler(this.TsmActualizar_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
			// 
			// tsmAsignarPermiso
			// 
			this.tsmAsignarPermiso.Name = "tsmAsignarPermiso";
			this.tsmAsignarPermiso.Size = new System.Drawing.Size(160, 22);
			this.tsmAsignarPermiso.Text = "Asignar permiso";
			// 
			// gpxFiltrar
			// 
			this.gpxFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpxFiltrar.Controls.Add(this.textBox4);
			this.gpxFiltrar.Controls.Add(this.textBox3);
			this.gpxFiltrar.Controls.Add(this.textBox2);
			this.gpxFiltrar.Controls.Add(this.label4);
			this.gpxFiltrar.Controls.Add(this.textBox1);
			this.gpxFiltrar.Controls.Add(this.label3);
			this.gpxFiltrar.Controls.Add(this.label2);
			this.gpxFiltrar.Controls.Add(this.lblRut);
			this.gpxFiltrar.Controls.Add(this.cbx_id_estadoBuscar);
			this.gpxFiltrar.Controls.Add(this.btn_Buscar);
			this.gpxFiltrar.Controls.Add(this.label1);
			this.gpxFiltrar.Location = new System.Drawing.Point(3, 3);
			this.gpxFiltrar.Name = "gpxFiltrar";
			this.gpxFiltrar.Size = new System.Drawing.Size(386, 132);
			this.gpxFiltrar.TabIndex = 0;
			this.gpxFiltrar.TabStop = false;
			this.gpxFiltrar.Text = "Busqueda";
			// 
			// cbx_id_estadoBuscar
			// 
			this.cbx_id_estadoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estadoBuscar.FormattingEnabled = true;
			this.cbx_id_estadoBuscar.Location = new System.Drawing.Point(126, 19);
			this.cbx_id_estadoBuscar.Name = "cbx_id_estadoBuscar";
			this.cbx_id_estadoBuscar.Size = new System.Drawing.Size(158, 21);
			this.cbx_id_estadoBuscar.TabIndex = 5;
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Buscar.Location = new System.Drawing.Point(318, 24);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(47, 46);
			this.btn_Buscar.TabIndex = 3;
			this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Buscar.UseVisualStyleBackColor = true;
			this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Estado";
			// 
			// lblRut
			// 
			this.lblRut.AutoSize = true;
			this.lblRut.Location = new System.Drawing.Point(22, 72);
			this.lblRut.Name = "lblRut";
			this.lblRut.Size = new System.Drawing.Size(30, 13);
			this.lblRut.TabIndex = 6;
			this.lblRut.Text = "RUT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Razón social";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "N° Cliente desde";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(126, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(57, 20);
			this.textBox1.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(189, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "al";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(210, 45);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(57, 20);
			this.textBox2.TabIndex = 11;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(126, 69);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(110, 20);
			this.textBox3.TabIndex = 12;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(126, 93);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(239, 20);
			this.textBox4.TabIndex = 13;
			// 
			// ColUsuario
			// 
			this.ColUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColUsuario.DataPropertyName = "Usuario";
			this.ColUsuario.FillWeight = 108.6294F;
			this.ColUsuario.HeaderText = "Razón social";
			this.ColUsuario.Name = "ColUsuario";
			this.ColUsuario.ReadOnly = true;
			// 
			// ColNombres
			// 
			this.ColNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ColNombres.DataPropertyName = "Nombres";
			this.ColNombres.FillWeight = 91.37056F;
			this.ColNombres.HeaderText = "Rut";
			this.ColNombres.Name = "ColNombres";
			this.ColNombres.ReadOnly = true;
			this.ColNombres.Width = 90;
			// 
			// tabPrincipal
			// 
			this.tabPrincipal.Controls.Add(this.tabCliente);
			this.tabPrincipal.Controls.Add(this.tabSucursal);
			this.tabPrincipal.Controls.Add(this.tabPersonal);
			this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
			this.tabPrincipal.Name = "tabPrincipal";
			this.tabPrincipal.SelectedIndex = 0;
			this.tabPrincipal.Size = new System.Drawing.Size(421, 523);
			this.tabPrincipal.TabIndex = 7;
			// 
			// tabCliente
			// 
			this.tabCliente.Controls.Add(this.tbl_Usuario);
			this.tabCliente.Location = new System.Drawing.Point(4, 22);
			this.tabCliente.Name = "tabCliente";
			this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabCliente.Size = new System.Drawing.Size(413, 497);
			this.tabCliente.TabIndex = 0;
			this.tabCliente.Text = "Cliente";
			this.tabCliente.UseVisualStyleBackColor = true;
			// 
			// tabSucursal
			// 
			this.tabSucursal.Location = new System.Drawing.Point(4, 22);
			this.tabSucursal.Name = "tabSucursal";
			this.tabSucursal.Padding = new System.Windows.Forms.Padding(3);
			this.tabSucursal.Size = new System.Drawing.Size(597, 497);
			this.tabSucursal.TabIndex = 1;
			this.tabSucursal.Text = "Sucursal";
			this.tabSucursal.UseVisualStyleBackColor = true;
			// 
			// tbl_Usuario
			// 
			this.tbl_Usuario.Controls.Add(this.txt_id_tipo_doc);
			this.tbl_Usuario.Controls.Add(this.lbl_Fecha_agregado);
			this.tbl_Usuario.Controls.Add(this.lbl_Fecha_Modificacion);
			this.tbl_Usuario.Controls.Add(this.lbl_Id_Usuario);
			this.tbl_Usuario.Controls.Add(this.cbx_Id_estado);
			this.tbl_Usuario.Controls.Add(this.cbx_Id_perfil);
			this.tbl_Usuario.Controls.Add(this.txt_Contraseña);
			this.tbl_Usuario.Controls.Add(this.txt_Contraseña1);
			this.tbl_Usuario.Controls.Add(this.txt_Maternos);
			this.tbl_Usuario.Controls.Add(this.txt_paterno);
			this.tbl_Usuario.Controls.Add(this.txt_Nombres);
			this.tbl_Usuario.Controls.Add(this.txt_rut);
			this.tbl_Usuario.Controls.Add(this.txt_Usuario);
			this.tbl_Usuario.Controls.Add(this.lbl_Contraseña);
			this.tbl_Usuario.Controls.Add(this.lbl_id_estado);
			this.tbl_Usuario.Controls.Add(this.lbl_Id_perfil);
			this.tbl_Usuario.Controls.Add(this.lbl_Maternos);
			this.tbl_Usuario.Controls.Add(this.lbl_Paterno);
			this.tbl_Usuario.Controls.Add(this.lbl_Nombres);
			this.tbl_Usuario.Controls.Add(this.lbl_rut);
			this.tbl_Usuario.Controls.Add(this.lbl_Usuario);
			this.tbl_Usuario.Controls.Add(this.btn_Minimizar);
			this.tbl_Usuario.Controls.Add(this.btn_Limpiar);
			this.tbl_Usuario.Controls.Add(this.btn_Guardar);
			this.tbl_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_Usuario.Location = new System.Drawing.Point(3, 3);
			this.tbl_Usuario.Name = "tbl_Usuario";
			this.tbl_Usuario.Size = new System.Drawing.Size(407, 491);
			this.tbl_Usuario.TabIndex = 7;
			this.tbl_Usuario.TabStop = false;
			this.tbl_Usuario.Text = "Datos";
			// 
			// txt_id_tipo_doc
			// 
			this.txt_id_tipo_doc.Location = new System.Drawing.Point(27, 273);
			this.txt_id_tipo_doc.Name = "txt_id_tipo_doc";
			this.txt_id_tipo_doc.Size = new System.Drawing.Size(46, 20);
			this.txt_id_tipo_doc.TabIndex = 34;
			this.txt_id_tipo_doc.Visible = false;
			// 
			// lbl_Fecha_agregado
			// 
			this.lbl_Fecha_agregado.AutoSize = true;
			this.lbl_Fecha_agregado.Location = new System.Drawing.Point(323, 177);
			this.lbl_Fecha_agregado.Name = "lbl_Fecha_agregado";
			this.lbl_Fecha_agregado.Size = new System.Drawing.Size(35, 13);
			this.lbl_Fecha_agregado.TabIndex = 33;
			this.lbl_Fecha_agregado.Text = "label5";
			this.lbl_Fecha_agregado.Visible = false;
			// 
			// lbl_Fecha_Modificacion
			// 
			this.lbl_Fecha_Modificacion.AutoSize = true;
			this.lbl_Fecha_Modificacion.Location = new System.Drawing.Point(323, 148);
			this.lbl_Fecha_Modificacion.Name = "lbl_Fecha_Modificacion";
			this.lbl_Fecha_Modificacion.Size = new System.Drawing.Size(35, 13);
			this.lbl_Fecha_Modificacion.TabIndex = 32;
			this.lbl_Fecha_Modificacion.Text = "label4";
			this.lbl_Fecha_Modificacion.Visible = false;
			// 
			// lbl_Id_Usuario
			// 
			this.lbl_Id_Usuario.AutoSize = true;
			this.lbl_Id_Usuario.Location = new System.Drawing.Point(317, 35);
			this.lbl_Id_Usuario.Name = "lbl_Id_Usuario";
			this.lbl_Id_Usuario.Size = new System.Drawing.Size(58, 13);
			this.lbl_Id_Usuario.TabIndex = 31;
			this.lbl_Id_Usuario.Text = "N° Usuario";
			this.lbl_Id_Usuario.Visible = false;
			// 
			// cbx_Id_estado
			// 
			this.cbx_Id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Id_estado.FormattingEnabled = true;
			this.cbx_Id_estado.Location = new System.Drawing.Point(164, 234);
			this.cbx_Id_estado.Name = "cbx_Id_estado";
			this.cbx_Id_estado.Size = new System.Drawing.Size(152, 21);
			this.cbx_Id_estado.TabIndex = 30;
			// 
			// cbx_Id_perfil
			// 
			this.cbx_Id_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Id_perfil.FormattingEnabled = true;
			this.cbx_Id_perfil.Location = new System.Drawing.Point(164, 174);
			this.cbx_Id_perfil.Name = "cbx_Id_perfil";
			this.cbx_Id_perfil.Size = new System.Drawing.Size(152, 21);
			this.cbx_Id_perfil.TabIndex = 29;
			// 
			// txt_Contraseña
			// 
			this.txt_Contraseña.Location = new System.Drawing.Point(322, 205);
			this.txt_Contraseña.Name = "txt_Contraseña";
			this.txt_Contraseña.Size = new System.Drawing.Size(36, 20);
			this.txt_Contraseña.TabIndex = 28;
			this.txt_Contraseña.Visible = false;
			// 
			// txt_Contraseña1
			// 
			this.txt_Contraseña1.Location = new System.Drawing.Point(164, 205);
			this.txt_Contraseña1.Name = "txt_Contraseña1";
			this.txt_Contraseña1.PasswordChar = '*';
			this.txt_Contraseña1.Size = new System.Drawing.Size(152, 20);
			this.txt_Contraseña1.TabIndex = 27;
			// 
			// txt_Maternos
			// 
			this.txt_Maternos.Location = new System.Drawing.Point(164, 148);
			this.txt_Maternos.Name = "txt_Maternos";
			this.txt_Maternos.Size = new System.Drawing.Size(152, 20);
			this.txt_Maternos.TabIndex = 26;
			// 
			// txt_paterno
			// 
			this.txt_paterno.Location = new System.Drawing.Point(164, 119);
			this.txt_paterno.Name = "txt_paterno";
			this.txt_paterno.Size = new System.Drawing.Size(152, 20);
			this.txt_paterno.TabIndex = 25;
			// 
			// txt_Nombres
			// 
			this.txt_Nombres.Location = new System.Drawing.Point(164, 90);
			this.txt_Nombres.Name = "txt_Nombres";
			this.txt_Nombres.Size = new System.Drawing.Size(152, 20);
			this.txt_Nombres.TabIndex = 24;
			// 
			// txt_rut
			// 
			this.txt_rut.Location = new System.Drawing.Point(164, 60);
			this.txt_rut.MaxLength = 10;
			this.txt_rut.Name = "txt_rut";
			this.txt_rut.Size = new System.Drawing.Size(152, 20);
			this.txt_rut.TabIndex = 23;
			// 
			// txt_Usuario
			// 
			this.txt_Usuario.Location = new System.Drawing.Point(164, 32);
			this.txt_Usuario.Name = "txt_Usuario";
			this.txt_Usuario.Size = new System.Drawing.Size(152, 20);
			this.txt_Usuario.TabIndex = 22;
			// 
			// lbl_Contraseña
			// 
			this.lbl_Contraseña.AutoSize = true;
			this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Contraseña.Location = new System.Drawing.Point(24, 213);
			this.lbl_Contraseña.Name = "lbl_Contraseña";
			this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
			this.lbl_Contraseña.TabIndex = 21;
			this.lbl_Contraseña.Text = "Contraseña";
			// 
			// lbl_id_estado
			// 
			this.lbl_id_estado.AutoSize = true;
			this.lbl_id_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_estado.Location = new System.Drawing.Point(24, 242);
			this.lbl_id_estado.Name = "lbl_id_estado";
			this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
			this.lbl_id_estado.TabIndex = 20;
			this.lbl_id_estado.Text = "Estado";
			// 
			// lbl_Id_perfil
			// 
			this.lbl_Id_perfil.AutoSize = true;
			this.lbl_Id_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Id_perfil.Location = new System.Drawing.Point(24, 184);
			this.lbl_Id_perfil.Name = "lbl_Id_perfil";
			this.lbl_Id_perfil.Size = new System.Drawing.Size(30, 13);
			this.lbl_Id_perfil.TabIndex = 19;
			this.lbl_Id_perfil.Text = "Perfil";
			// 
			// lbl_Maternos
			// 
			this.lbl_Maternos.AutoSize = true;
			this.lbl_Maternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Maternos.Location = new System.Drawing.Point(24, 155);
			this.lbl_Maternos.Name = "lbl_Maternos";
			this.lbl_Maternos.Size = new System.Drawing.Size(86, 13);
			this.lbl_Maternos.TabIndex = 18;
			this.lbl_Maternos.Text = "Apellido Materno";
			// 
			// lbl_Paterno
			// 
			this.lbl_Paterno.AutoSize = true;
			this.lbl_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Paterno.Location = new System.Drawing.Point(24, 126);
			this.lbl_Paterno.Name = "lbl_Paterno";
			this.lbl_Paterno.Size = new System.Drawing.Size(84, 13);
			this.lbl_Paterno.TabIndex = 17;
			this.lbl_Paterno.Text = "Apellido Paterno";
			// 
			// lbl_Nombres
			// 
			this.lbl_Nombres.AutoSize = true;
			this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombres.Location = new System.Drawing.Point(24, 97);
			this.lbl_Nombres.Name = "lbl_Nombres";
			this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
			this.lbl_Nombres.TabIndex = 16;
			this.lbl_Nombres.Text = "Nombres";
			// 
			// lbl_rut
			// 
			this.lbl_rut.AutoSize = true;
			this.lbl_rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_rut.Location = new System.Drawing.Point(24, 68);
			this.lbl_rut.Name = "lbl_rut";
			this.lbl_rut.Size = new System.Drawing.Size(36, 13);
			this.lbl_rut.TabIndex = 15;
			this.lbl_rut.Text = "RUT  ";
			// 
			// lbl_Usuario
			// 
			this.lbl_Usuario.AutoSize = true;
			this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Usuario.Location = new System.Drawing.Point(24, 39);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
			this.lbl_Usuario.TabIndex = 14;
			this.lbl_Usuario.Text = "Usuario";
			// 
			// btn_Minimizar
			// 
			this.btn_Minimizar.Image = global::ControlDosimetro.Properties.Resources.minimizar;
			this.btn_Minimizar.Location = new System.Drawing.Point(320, 0);
			this.btn_Minimizar.Name = "btn_Minimizar";
			this.btn_Minimizar.Size = new System.Drawing.Size(38, 17);
			this.btn_Minimizar.TabIndex = 13;
			this.btn_Minimizar.UseVisualStyleBackColor = true;
			// 
			// btn_Limpiar
			// 
			this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
			this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Limpiar.Location = new System.Drawing.Point(266, 441);
			this.btn_Limpiar.Name = "btn_Limpiar";
			this.btn_Limpiar.Size = new System.Drawing.Size(85, 40);
			this.btn_Limpiar.TabIndex = 10;
			this.btn_Limpiar.Text = "Limpiar";
			this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Limpiar.UseVisualStyleBackColor = true;
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(161, 441);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
			this.btn_Guardar.TabIndex = 9;
			this.btn_Guardar.Text = "Grabar";
			this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Guardar.UseVisualStyleBackColor = true;
			// 
			// tabPersonal
			// 
			this.tabPersonal.Location = new System.Drawing.Point(4, 22);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Size = new System.Drawing.Size(597, 497);
			this.tabPersonal.TabIndex = 2;
			this.tabPersonal.Text = "Personal";
			this.tabPersonal.UseVisualStyleBackColor = true;
			// 
			// frmMantenedorCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 573);
			this.Controls.Add(this.scPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.stsEstado);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(764, 412);
			this.Name = "frmMantenedorCliente";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mantenedor cliente";
			this.Load += new System.EventHandler(this.frmMantenedorCliente_Load);
			this.stsEstado.ResumeLayout(false);
			this.stsEstado.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.scPrincipal.Panel1.ResumeLayout(false);
			this.scPrincipal.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
			this.scPrincipal.ResumeLayout(false);
			this.pnlPrincipal.ResumeLayout(false);
			this.gpxListado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
			this.cmsMenuContexto.ResumeLayout(false);
			this.gpxFiltrar.ResumeLayout(false);
			this.gpxFiltrar.PerformLayout();
			this.tabPrincipal.ResumeLayout(false);
			this.tabCliente.ResumeLayout(false);
			this.tbl_Usuario.ResumeLayout(false);
			this.tbl_Usuario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.GroupBox gpxFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox gpxListado;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContexto;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignarPermiso;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.ComboBox cbx_id_estadoBuscar;
		private System.Windows.Forms.ToolStripDropDownButton tsdReporte;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRut;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColNombres;
		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabCliente;
		private System.Windows.Forms.GroupBox tbl_Usuario;
		private System.Windows.Forms.TextBox txt_id_tipo_doc;
		private System.Windows.Forms.Label lbl_Fecha_agregado;
		private System.Windows.Forms.Label lbl_Fecha_Modificacion;
		private System.Windows.Forms.Label lbl_Id_Usuario;
		private System.Windows.Forms.ComboBox cbx_Id_estado;
		private System.Windows.Forms.ComboBox cbx_Id_perfil;
		private System.Windows.Forms.TextBox txt_Contraseña;
		private System.Windows.Forms.TextBox txt_Contraseña1;
		private System.Windows.Forms.TextBox txt_Maternos;
		private System.Windows.Forms.TextBox txt_paterno;
		private System.Windows.Forms.TextBox txt_Nombres;
		private System.Windows.Forms.TextBox txt_rut;
		private System.Windows.Forms.TextBox txt_Usuario;
		private System.Windows.Forms.Label lbl_Contraseña;
		private System.Windows.Forms.Label lbl_id_estado;
		private System.Windows.Forms.Label lbl_Id_perfil;
		private System.Windows.Forms.Label lbl_Maternos;
		private System.Windows.Forms.Label lbl_Paterno;
		private System.Windows.Forms.Label lbl_Nombres;
		private System.Windows.Forms.Label lbl_rut;
		private System.Windows.Forms.Label lbl_Usuario;
		private System.Windows.Forms.Button btn_Minimizar;
		private System.Windows.Forms.Button btn_Limpiar;
		private System.Windows.Forms.Button btn_Guardar;
		private System.Windows.Forms.TabPage tabSucursal;
		private System.Windows.Forms.TabPage tabPersonal;
	}
}