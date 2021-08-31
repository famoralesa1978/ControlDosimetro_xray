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
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRut = new System.Windows.Forms.Label();
			this.cbx_id_estadoBuscar = new System.Windows.Forms.ComboBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPrincipal = new System.Windows.Forms.TabControl();
			this.tabCliente = new System.Windows.Forms.TabPage();
			this.tbl_cliente = new System.Windows.Forms.GroupBox();
			this.btn_Limpiar = new System.Windows.Forms.Button();
			this.lbl_Emailfacturacion = new System.Windows.Forms.Label();
			this.txt_Emailfacturacion = new System.Windows.Forms.TextBox();
			this.lbl_Nombre_fantasia = new System.Windows.Forms.Label();
			this.txt_Nombre_fantasia = new System.Windows.Forms.TextBox();
			this.txt_Opr = new System.Windows.Forms.TextBox();
			this.lbl_Opr = new System.Windows.Forms.Label();
			this.txt_Director = new System.Windows.Forms.TextBox();
			this.lbl_Director = new System.Windows.Forms.Label();
			this.cbx_Id_Sector = new System.Windows.Forms.ComboBox();
			this.lbl_Id_Sector = new System.Windows.Forms.Label();
			this.cbx_id_Ministerio = new System.Windows.Forms.ComboBox();
			this.lbl_id_Ministerio = new System.Windows.Forms.Label();
			this.cbx_Id_TipoEntidad = new System.Windows.Forms.ComboBox();
			this.lbl_Id_TipoEntidad = new System.Windows.Forms.Label();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.txt_Clave = new System.Windows.Forms.TextBox();
			this.lbl_Clave = new System.Windows.Forms.Label();
			this.txt_Clave1 = new System.Windows.Forms.TextBox();
			this.txt_Servicio = new System.Windows.Forms.TextBox();
			this.lbl_Servicio = new System.Windows.Forms.Label();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.lbl_Estado_mod = new System.Windows.Forms.Label();
			this.txt_N_Cliente_Ref = new System.Windows.Forms.TextBox();
			this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
			this.lbl_N_Cliente_Ref = new System.Windows.Forms.Label();
			this.lbl_FechaInicio = new System.Windows.Forms.Label();
			this.cbx_id_estado = new System.Windows.Forms.ComboBox();
			this.lbl_id_estado = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbx_Id_TipoFuente = new System.Windows.Forms.ComboBox();
			this.cbx_id_comuna = new System.Windows.Forms.ComboBox();
			this.cbx_id_provincia = new System.Windows.Forms.ComboBox();
			this.cbx_id_region = new System.Windows.Forms.ComboBox();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.btn_Grabar = new System.Windows.Forms.Button();
			this.lbl_Id_TipoFuente = new System.Windows.Forms.Label();
			this.txt_telefono = new System.Windows.Forms.TextBox();
			this.lbl_telefono = new System.Windows.Forms.Label();
			this.lbl_id_comuna = new System.Windows.Forms.Label();
			this.lbl_id_provincia = new System.Windows.Forms.Label();
			this.lbl_id_region = new System.Windows.Forms.Label();
			this.txt_direccion = new System.Windows.Forms.TextBox();
			this.lbl_direccion = new System.Windows.Forms.Label();
			this.txt_Razon_Social = new System.Windows.Forms.TextBox();
			this.lbl_Razon_Social = new System.Windows.Forms.Label();
			this.txt_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.txt_run = new System.Windows.Forms.TextBox();
			this.lbl_run = new System.Windows.Forms.Label();
			this.tabSucursal = new System.Windows.Forms.TabPage();
			this.spcSucursal = new System.Windows.Forms.SplitContainer();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.id_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPersonal = new System.Windows.Forms.TabPage();
			this.spcPersonal = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColServicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.ColSeccion = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.ColFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.colId_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.tbl_cliente.SuspendLayout();
			this.tabSucursal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcSucursal)).BeginInit();
			this.spcSucursal.Panel1.SuspendLayout();
			this.spcSucursal.Panel2.SuspendLayout();
			this.spcSucursal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.tabPersonal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcPersonal)).BeginInit();
			this.spcPersonal.Panel1.SuspendLayout();
			this.spcPersonal.Panel2.SuspendLayout();
			this.spcPersonal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 708);
			this.stsEstado.Name = "stsEstado";
			this.stsEstado.Size = new System.Drawing.Size(1535, 22);
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
			this.toolStrip1.Size = new System.Drawing.Size(1535, 25);
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
			this.scPrincipal.Size = new System.Drawing.Size(1523, 680);
			this.scPrincipal.SplitterDistance = 401;
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
			this.pnlPrincipal.Size = new System.Drawing.Size(381, 674);
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
			this.gpxListado.Size = new System.Drawing.Size(373, 525);
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
            this.colId_cliente,
            this.ColUsuario,
            this.ColNombres});
			this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(367, 506);
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
			this.gpxFiltrar.Size = new System.Drawing.Size(370, 132);
			this.gpxFiltrar.TabIndex = 0;
			this.gpxFiltrar.TabStop = false;
			this.gpxFiltrar.Text = "Busqueda";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(126, 93);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(239, 20);
			this.textBox4.TabIndex = 13;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(126, 69);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(110, 20);
			this.textBox3.TabIndex = 12;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(210, 45);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(57, 20);
			this.textBox2.TabIndex = 11;
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(126, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(57, 20);
			this.textBox1.TabIndex = 9;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Razón social";
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
			// tabPrincipal
			// 
			this.tabPrincipal.Controls.Add(this.tabCliente);
			this.tabPrincipal.Controls.Add(this.tabSucursal);
			this.tabPrincipal.Controls.Add(this.tabPersonal);
			this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
			this.tabPrincipal.Name = "tabPrincipal";
			this.tabPrincipal.SelectedIndex = 0;
			this.tabPrincipal.Size = new System.Drawing.Size(1118, 680);
			this.tabPrincipal.TabIndex = 7;
			// 
			// tabCliente
			// 
			this.tabCliente.Controls.Add(this.tbl_cliente);
			this.tabCliente.Location = new System.Drawing.Point(4, 22);
			this.tabCliente.Name = "tabCliente";
			this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabCliente.Size = new System.Drawing.Size(1110, 654);
			this.tabCliente.TabIndex = 0;
			this.tabCliente.Text = "Cliente";
			this.tabCliente.UseVisualStyleBackColor = true;
			// 
			// tbl_cliente
			// 
			this.tbl_cliente.Controls.Add(this.btn_Limpiar);
			this.tbl_cliente.Controls.Add(this.lbl_Emailfacturacion);
			this.tbl_cliente.Controls.Add(this.txt_Emailfacturacion);
			this.tbl_cliente.Controls.Add(this.lbl_Nombre_fantasia);
			this.tbl_cliente.Controls.Add(this.txt_Nombre_fantasia);
			this.tbl_cliente.Controls.Add(this.txt_Opr);
			this.tbl_cliente.Controls.Add(this.lbl_Opr);
			this.tbl_cliente.Controls.Add(this.txt_Director);
			this.tbl_cliente.Controls.Add(this.lbl_Director);
			this.tbl_cliente.Controls.Add(this.cbx_Id_Sector);
			this.tbl_cliente.Controls.Add(this.lbl_Id_Sector);
			this.tbl_cliente.Controls.Add(this.cbx_id_Ministerio);
			this.tbl_cliente.Controls.Add(this.lbl_id_Ministerio);
			this.tbl_cliente.Controls.Add(this.cbx_Id_TipoEntidad);
			this.tbl_cliente.Controls.Add(this.lbl_Id_TipoEntidad);
			this.tbl_cliente.Controls.Add(this.cbx_id_periodo);
			this.tbl_cliente.Controls.Add(this.txt_Clave);
			this.tbl_cliente.Controls.Add(this.lbl_Clave);
			this.tbl_cliente.Controls.Add(this.txt_Clave1);
			this.tbl_cliente.Controls.Add(this.txt_Servicio);
			this.tbl_cliente.Controls.Add(this.lbl_Servicio);
			this.tbl_cliente.Controls.Add(this.lbl_Email);
			this.tbl_cliente.Controls.Add(this.txt_Email);
			this.tbl_cliente.Controls.Add(this.lbl_Estado_mod);
			this.tbl_cliente.Controls.Add(this.txt_N_Cliente_Ref);
			this.tbl_cliente.Controls.Add(this.dtp_FechaInicio);
			this.tbl_cliente.Controls.Add(this.lbl_N_Cliente_Ref);
			this.tbl_cliente.Controls.Add(this.lbl_FechaInicio);
			this.tbl_cliente.Controls.Add(this.cbx_id_estado);
			this.tbl_cliente.Controls.Add(this.lbl_id_estado);
			this.tbl_cliente.Controls.Add(this.label5);
			this.tbl_cliente.Controls.Add(this.cbx_Id_TipoFuente);
			this.tbl_cliente.Controls.Add(this.cbx_id_comuna);
			this.tbl_cliente.Controls.Add(this.cbx_id_provincia);
			this.tbl_cliente.Controls.Add(this.cbx_id_region);
			this.tbl_cliente.Controls.Add(this.btn_cerrar);
			this.tbl_cliente.Controls.Add(this.btn_Grabar);
			this.tbl_cliente.Controls.Add(this.lbl_Id_TipoFuente);
			this.tbl_cliente.Controls.Add(this.txt_telefono);
			this.tbl_cliente.Controls.Add(this.lbl_telefono);
			this.tbl_cliente.Controls.Add(this.lbl_id_comuna);
			this.tbl_cliente.Controls.Add(this.lbl_id_provincia);
			this.tbl_cliente.Controls.Add(this.lbl_id_region);
			this.tbl_cliente.Controls.Add(this.txt_direccion);
			this.tbl_cliente.Controls.Add(this.lbl_direccion);
			this.tbl_cliente.Controls.Add(this.txt_Razon_Social);
			this.tbl_cliente.Controls.Add(this.lbl_Razon_Social);
			this.tbl_cliente.Controls.Add(this.txt_id_cliente);
			this.tbl_cliente.Controls.Add(this.lbl_id_cliente);
			this.tbl_cliente.Controls.Add(this.txt_run);
			this.tbl_cliente.Controls.Add(this.lbl_run);
			this.tbl_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_cliente.Location = new System.Drawing.Point(3, 3);
			this.tbl_cliente.Name = "tbl_cliente";
			this.tbl_cliente.Size = new System.Drawing.Size(1104, 648);
			this.tbl_cliente.TabIndex = 1;
			this.tbl_cliente.TabStop = false;
			this.tbl_cliente.Text = "Datos";
			// 
			// btn_Limpiar
			// 
			this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
			this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Limpiar.Location = new System.Drawing.Point(415, 602);
			this.btn_Limpiar.Name = "btn_Limpiar";
			this.btn_Limpiar.Size = new System.Drawing.Size(110, 40);
			this.btn_Limpiar.TabIndex = 60;
			this.btn_Limpiar.Text = "Limpiar";
			this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Limpiar.UseVisualStyleBackColor = true;
			// 
			// lbl_Emailfacturacion
			// 
			this.lbl_Emailfacturacion.AutoSize = true;
			this.lbl_Emailfacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Emailfacturacion.Location = new System.Drawing.Point(12, 311);
			this.lbl_Emailfacturacion.Name = "lbl_Emailfacturacion";
			this.lbl_Emailfacturacion.Size = new System.Drawing.Size(88, 13);
			this.lbl_Emailfacturacion.TabIndex = 59;
			this.lbl_Emailfacturacion.Text = "Email facturación";
			// 
			// txt_Emailfacturacion
			// 
			this.txt_Emailfacturacion.Location = new System.Drawing.Point(166, 308);
			this.txt_Emailfacturacion.MaxLength = 200;
			this.txt_Emailfacturacion.Name = "txt_Emailfacturacion";
			this.txt_Emailfacturacion.Size = new System.Drawing.Size(303, 20);
			this.txt_Emailfacturacion.TabIndex = 12;
			// 
			// lbl_Nombre_fantasia
			// 
			this.lbl_Nombre_fantasia.AutoSize = true;
			this.lbl_Nombre_fantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombre_fantasia.Location = new System.Drawing.Point(11, 126);
			this.lbl_Nombre_fantasia.Name = "lbl_Nombre_fantasia";
			this.lbl_Nombre_fantasia.Size = new System.Drawing.Size(84, 13);
			this.lbl_Nombre_fantasia.TabIndex = 57;
			this.lbl_Nombre_fantasia.Text = "Nombre fantasia";
			// 
			// txt_Nombre_fantasia
			// 
			this.txt_Nombre_fantasia.Location = new System.Drawing.Point(167, 123);
			this.txt_Nombre_fantasia.MaxLength = 100;
			this.txt_Nombre_fantasia.Name = "txt_Nombre_fantasia";
			this.txt_Nombre_fantasia.Size = new System.Drawing.Size(313, 20);
			this.txt_Nombre_fantasia.TabIndex = 5;
			// 
			// txt_Opr
			// 
			this.txt_Opr.Location = new System.Drawing.Point(166, 444);
			this.txt_Opr.MaxLength = 50;
			this.txt_Opr.Name = "txt_Opr";
			this.txt_Opr.Size = new System.Drawing.Size(313, 20);
			this.txt_Opr.TabIndex = 17;
			// 
			// lbl_Opr
			// 
			this.lbl_Opr.AutoSize = true;
			this.lbl_Opr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Opr.Location = new System.Drawing.Point(10, 447);
			this.lbl_Opr.Name = "lbl_Opr";
			this.lbl_Opr.Size = new System.Drawing.Size(30, 13);
			this.lbl_Opr.TabIndex = 55;
			this.lbl_Opr.Text = "OPR";
			// 
			// txt_Director
			// 
			this.txt_Director.Location = new System.Drawing.Point(166, 418);
			this.txt_Director.MaxLength = 50;
			this.txt_Director.Name = "txt_Director";
			this.txt_Director.Size = new System.Drawing.Size(313, 20);
			this.txt_Director.TabIndex = 16;
			// 
			// lbl_Director
			// 
			this.lbl_Director.AutoSize = true;
			this.lbl_Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Director.Location = new System.Drawing.Point(10, 421);
			this.lbl_Director.Name = "lbl_Director";
			this.lbl_Director.Size = new System.Drawing.Size(44, 13);
			this.lbl_Director.TabIndex = 53;
			this.lbl_Director.Text = "Director";
			// 
			// cbx_Id_Sector
			// 
			this.cbx_Id_Sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Id_Sector.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Id_Sector.FormattingEnabled = true;
			this.cbx_Id_Sector.Location = new System.Drawing.Point(166, 391);
			this.cbx_Id_Sector.Name = "cbx_Id_Sector";
			this.cbx_Id_Sector.Size = new System.Drawing.Size(150, 21);
			this.cbx_Id_Sector.TabIndex = 15;
			// 
			// lbl_Id_Sector
			// 
			this.lbl_Id_Sector.AutoSize = true;
			this.lbl_Id_Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Id_Sector.Location = new System.Drawing.Point(10, 394);
			this.lbl_Id_Sector.Name = "lbl_Id_Sector";
			this.lbl_Id_Sector.Size = new System.Drawing.Size(38, 13);
			this.lbl_Id_Sector.TabIndex = 51;
			this.lbl_Id_Sector.Text = "Sector";
			// 
			// cbx_id_Ministerio
			// 
			this.cbx_id_Ministerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_Ministerio.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_Ministerio.FormattingEnabled = true;
			this.cbx_id_Ministerio.Location = new System.Drawing.Point(166, 364);
			this.cbx_id_Ministerio.Name = "cbx_id_Ministerio";
			this.cbx_id_Ministerio.Size = new System.Drawing.Size(150, 21);
			this.cbx_id_Ministerio.TabIndex = 14;
			// 
			// lbl_id_Ministerio
			// 
			this.lbl_id_Ministerio.AutoSize = true;
			this.lbl_id_Ministerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_Ministerio.Location = new System.Drawing.Point(11, 372);
			this.lbl_id_Ministerio.Name = "lbl_id_Ministerio";
			this.lbl_id_Ministerio.Size = new System.Drawing.Size(51, 13);
			this.lbl_id_Ministerio.TabIndex = 49;
			this.lbl_id_Ministerio.Text = "Ministerio";
			// 
			// cbx_Id_TipoEntidad
			// 
			this.cbx_Id_TipoEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Id_TipoEntidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Id_TipoEntidad.FormattingEnabled = true;
			this.cbx_Id_TipoEntidad.Location = new System.Drawing.Point(167, 337);
			this.cbx_Id_TipoEntidad.Name = "cbx_Id_TipoEntidad";
			this.cbx_Id_TipoEntidad.Size = new System.Drawing.Size(150, 21);
			this.cbx_Id_TipoEntidad.TabIndex = 13;
			// 
			// lbl_Id_TipoEntidad
			// 
			this.lbl_Id_TipoEntidad.AutoSize = true;
			this.lbl_Id_TipoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Id_TipoEntidad.Location = new System.Drawing.Point(12, 340);
			this.lbl_Id_TipoEntidad.Name = "lbl_Id_TipoEntidad";
			this.lbl_Id_TipoEntidad.Size = new System.Drawing.Size(67, 13);
			this.lbl_Id_TipoEntidad.TabIndex = 47;
			this.lbl_Id_TipoEntidad.Text = "Tipo Entidad";
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(166, 522);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 20;
			// 
			// txt_Clave
			// 
			this.txt_Clave.Location = new System.Drawing.Point(52, 555);
			this.txt_Clave.MaxLength = 100;
			this.txt_Clave.Name = "txt_Clave";
			this.txt_Clave.Size = new System.Drawing.Size(111, 20);
			this.txt_Clave.TabIndex = 45;
			this.txt_Clave.Visible = false;
			// 
			// lbl_Clave
			// 
			this.lbl_Clave.AutoSize = true;
			this.lbl_Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Clave.Location = new System.Drawing.Point(12, 555);
			this.lbl_Clave.Name = "lbl_Clave";
			this.lbl_Clave.Size = new System.Drawing.Size(34, 13);
			this.lbl_Clave.TabIndex = 44;
			this.lbl_Clave.Text = "Clave";
			// 
			// txt_Clave1
			// 
			this.txt_Clave1.Location = new System.Drawing.Point(166, 555);
			this.txt_Clave1.MaxLength = 100;
			this.txt_Clave1.Name = "txt_Clave1";
			this.txt_Clave1.Size = new System.Drawing.Size(313, 20);
			this.txt_Clave1.TabIndex = 21;
			// 
			// txt_Servicio
			// 
			this.txt_Servicio.Location = new System.Drawing.Point(166, 469);
			this.txt_Servicio.MaxLength = 100;
			this.txt_Servicio.Name = "txt_Servicio";
			this.txt_Servicio.Size = new System.Drawing.Size(313, 20);
			this.txt_Servicio.TabIndex = 18;
			// 
			// lbl_Servicio
			// 
			this.lbl_Servicio.AutoSize = true;
			this.lbl_Servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Servicio.Location = new System.Drawing.Point(10, 472);
			this.lbl_Servicio.Name = "lbl_Servicio";
			this.lbl_Servicio.Size = new System.Drawing.Size(45, 13);
			this.lbl_Servicio.TabIndex = 42;
			this.lbl_Servicio.Text = "Servicio";
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Email.Location = new System.Drawing.Point(11, 285);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(32, 13);
			this.lbl_Email.TabIndex = 40;
			this.lbl_Email.Text = "Email";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(167, 282);
			this.txt_Email.MaxLength = 200;
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(303, 20);
			this.txt_Email.TabIndex = 11;
			// 
			// lbl_Estado_mod
			// 
			this.lbl_Estado_mod.AutoSize = true;
			this.lbl_Estado_mod.Location = new System.Drawing.Point(309, 503);
			this.lbl_Estado_mod.Name = "lbl_Estado_mod";
			this.lbl_Estado_mod.Size = new System.Drawing.Size(41, 13);
			this.lbl_Estado_mod.TabIndex = 38;
			this.lbl_Estado_mod.Text = "label14";
			this.lbl_Estado_mod.Visible = false;
			// 
			// txt_N_Cliente_Ref
			// 
			this.txt_N_Cliente_Ref.Location = new System.Drawing.Point(167, 45);
			this.txt_N_Cliente_Ref.MaxLength = 4;
			this.txt_N_Cliente_Ref.Name = "txt_N_Cliente_Ref";
			this.txt_N_Cliente_Ref.Size = new System.Drawing.Size(75, 20);
			this.txt_N_Cliente_Ref.TabIndex = 2;
			// 
			// dtp_FechaInicio
			// 
			this.dtp_FechaInicio.CustomFormat = "dd/MM/yyyy";
			this.dtp_FechaInicio.Enabled = false;
			this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaInicio.Location = new System.Drawing.Point(167, 522);
			this.dtp_FechaInicio.Name = "dtp_FechaInicio";
			this.dtp_FechaInicio.Size = new System.Drawing.Size(98, 20);
			this.dtp_FechaInicio.TabIndex = 19;
			this.dtp_FechaInicio.Value = new System.DateTime(2017, 10, 18, 0, 29, 57, 0);
			// 
			// lbl_N_Cliente_Ref
			// 
			this.lbl_N_Cliente_Ref.AutoSize = true;
			this.lbl_N_Cliente_Ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_N_Cliente_Ref.Location = new System.Drawing.Point(12, 48);
			this.lbl_N_Cliente_Ref.Name = "lbl_N_Cliente_Ref";
			this.lbl_N_Cliente_Ref.Size = new System.Drawing.Size(141, 13);
			this.lbl_N_Cliente_Ref.TabIndex = 32;
			this.lbl_N_Cliente_Ref.Text = "N°  Cliente Referencia(Libro)";
			// 
			// lbl_FechaInicio
			// 
			this.lbl_FechaInicio.AutoSize = true;
			this.lbl_FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_FechaInicio.Location = new System.Drawing.Point(11, 526);
			this.lbl_FechaInicio.Name = "lbl_FechaInicio";
			this.lbl_FechaInicio.Size = new System.Drawing.Size(101, 13);
			this.lbl_FechaInicio.TabIndex = 31;
			this.lbl_FechaInicio.Text = "Fecha Inicio Control";
			// 
			// cbx_id_estado
			// 
			this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_estado.FormattingEnabled = true;
			this.cbx_id_estado.Location = new System.Drawing.Point(166, 495);
			this.cbx_id_estado.Name = "cbx_id_estado";
			this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_estado.TabIndex = 19;
			// 
			// lbl_id_estado
			// 
			this.lbl_id_estado.AutoSize = true;
			this.lbl_id_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_estado.Location = new System.Drawing.Point(11, 498);
			this.lbl_id_estado.Name = "lbl_id_estado";
			this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
			this.lbl_id_estado.TabIndex = 28;
			this.lbl_id_estado.Text = "Estado";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(293, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Formato: 12345678-9";
			// 
			// cbx_Id_TipoFuente
			// 
			this.cbx_Id_TipoFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Id_TipoFuente.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Id_TipoFuente.FormattingEnabled = true;
			this.cbx_Id_TipoFuente.Location = new System.Drawing.Point(335, 19);
			this.cbx_Id_TipoFuente.Name = "cbx_Id_TipoFuente";
			this.cbx_Id_TipoFuente.Size = new System.Drawing.Size(150, 21);
			this.cbx_Id_TipoFuente.TabIndex = 13;
			this.cbx_Id_TipoFuente.Visible = false;
			// 
			// cbx_id_comuna
			// 
			this.cbx_id_comuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_comuna.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_comuna.FormattingEnabled = true;
			this.cbx_id_comuna.Location = new System.Drawing.Point(167, 230);
			this.cbx_id_comuna.Name = "cbx_id_comuna";
			this.cbx_id_comuna.Size = new System.Drawing.Size(303, 21);
			this.cbx_id_comuna.TabIndex = 9;
			this.cbx_id_comuna.TabStop = false;
			// 
			// cbx_id_provincia
			// 
			this.cbx_id_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_provincia.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_provincia.FormattingEnabled = true;
			this.cbx_id_provincia.Location = new System.Drawing.Point(167, 203);
			this.cbx_id_provincia.Name = "cbx_id_provincia";
			this.cbx_id_provincia.Size = new System.Drawing.Size(303, 21);
			this.cbx_id_provincia.TabIndex = 8;
			this.cbx_id_provincia.TabStop = false;
			// 
			// cbx_id_region
			// 
			this.cbx_id_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_region.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_region.FormattingEnabled = true;
			this.cbx_id_region.Location = new System.Drawing.Point(167, 175);
			this.cbx_id_region.Name = "cbx_id_region";
			this.cbx_id_region.Size = new System.Drawing.Size(303, 21);
			this.cbx_id_region.TabIndex = 7;
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.Image = global::ControlDosimetro.Properties.Resources.Close_24;
			this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cerrar.Location = new System.Drawing.Point(253, 602);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(97, 38);
			this.btn_cerrar.TabIndex = 23;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.UseVisualStyleBackColor = true;
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Image = global::ControlDosimetro.Properties.Resources.Save_24;
			this.btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Grabar.Location = new System.Drawing.Point(99, 602);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(104, 38);
			this.btn_Grabar.TabIndex = 22;
			this.btn_Grabar.Text = "Guardar";
			this.btn_Grabar.UseVisualStyleBackColor = true;
			// 
			// lbl_Id_TipoFuente
			// 
			this.lbl_Id_TipoFuente.AutoSize = true;
			this.lbl_Id_TipoFuente.Location = new System.Drawing.Point(267, 19);
			this.lbl_Id_TipoFuente.Name = "lbl_Id_TipoFuente";
			this.lbl_Id_TipoFuente.Size = new System.Drawing.Size(64, 13);
			this.lbl_Id_TipoFuente.TabIndex = 16;
			this.lbl_Id_TipoFuente.Text = "Tipo Fuente";
			this.lbl_Id_TipoFuente.Visible = false;
			// 
			// txt_telefono
			// 
			this.txt_telefono.Location = new System.Drawing.Point(167, 256);
			this.txt_telefono.MaxLength = 15;
			this.txt_telefono.Name = "txt_telefono";
			this.txt_telefono.Size = new System.Drawing.Size(141, 20);
			this.txt_telefono.TabIndex = 10;
			// 
			// lbl_telefono
			// 
			this.lbl_telefono.AutoSize = true;
			this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_telefono.Location = new System.Drawing.Point(11, 259);
			this.lbl_telefono.Name = "lbl_telefono";
			this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
			this.lbl_telefono.TabIndex = 14;
			this.lbl_telefono.Text = "Telefono";
			// 
			// lbl_id_comuna
			// 
			this.lbl_id_comuna.AutoSize = true;
			this.lbl_id_comuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_comuna.Location = new System.Drawing.Point(11, 233);
			this.lbl_id_comuna.Name = "lbl_id_comuna";
			this.lbl_id_comuna.Size = new System.Drawing.Size(46, 13);
			this.lbl_id_comuna.TabIndex = 13;
			this.lbl_id_comuna.Text = "Comuna";
			// 
			// lbl_id_provincia
			// 
			this.lbl_id_provincia.AutoSize = true;
			this.lbl_id_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_provincia.Location = new System.Drawing.Point(11, 205);
			this.lbl_id_provincia.Name = "lbl_id_provincia";
			this.lbl_id_provincia.Size = new System.Drawing.Size(51, 13);
			this.lbl_id_provincia.TabIndex = 12;
			this.lbl_id_provincia.Text = "Provincia";
			// 
			// lbl_id_region
			// 
			this.lbl_id_region.AutoSize = true;
			this.lbl_id_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_region.Location = new System.Drawing.Point(11, 178);
			this.lbl_id_region.Name = "lbl_id_region";
			this.lbl_id_region.Size = new System.Drawing.Size(41, 13);
			this.lbl_id_region.TabIndex = 11;
			this.lbl_id_region.Text = "Región";
			// 
			// txt_direccion
			// 
			this.txt_direccion.Location = new System.Drawing.Point(167, 148);
			this.txt_direccion.MaxLength = 100;
			this.txt_direccion.Name = "txt_direccion";
			this.txt_direccion.Size = new System.Drawing.Size(313, 20);
			this.txt_direccion.TabIndex = 6;
			// 
			// lbl_direccion
			// 
			this.lbl_direccion.AutoSize = true;
			this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_direccion.Location = new System.Drawing.Point(11, 151);
			this.lbl_direccion.Name = "lbl_direccion";
			this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
			this.lbl_direccion.TabIndex = 9;
			this.lbl_direccion.Text = "Dirección";
			// 
			// txt_Razon_Social
			// 
			this.txt_Razon_Social.Location = new System.Drawing.Point(167, 98);
			this.txt_Razon_Social.MaxLength = 60;
			this.txt_Razon_Social.Name = "txt_Razon_Social";
			this.txt_Razon_Social.Size = new System.Drawing.Size(313, 20);
			this.txt_Razon_Social.TabIndex = 4;
			// 
			// lbl_Razon_Social
			// 
			this.lbl_Razon_Social.AutoSize = true;
			this.lbl_Razon_Social.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Razon_Social.Location = new System.Drawing.Point(11, 103);
			this.lbl_Razon_Social.Name = "lbl_Razon_Social";
			this.lbl_Razon_Social.Size = new System.Drawing.Size(70, 13);
			this.lbl_Razon_Social.TabIndex = 7;
			this.lbl_Razon_Social.Text = "Razon Social";
			// 
			// txt_id_cliente
			// 
			this.txt_id_cliente.Location = new System.Drawing.Point(167, 19);
			this.txt_id_cliente.MaxLength = 4;
			this.txt_id_cliente.Name = "txt_id_cliente";
			this.txt_id_cliente.Size = new System.Drawing.Size(75, 20);
			this.txt_id_cliente.TabIndex = 1;
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_cliente.Location = new System.Drawing.Point(11, 22);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(54, 13);
			this.lbl_id_cliente.TabIndex = 5;
			this.lbl_id_cliente.Text = "N° Cliente";
			// 
			// txt_run
			// 
			this.txt_run.Location = new System.Drawing.Point(167, 71);
			this.txt_run.MaxLength = 10;
			this.txt_run.Name = "txt_run";
			this.txt_run.Size = new System.Drawing.Size(120, 20);
			this.txt_run.TabIndex = 3;
			// 
			// lbl_run
			// 
			this.lbl_run.AutoSize = true;
			this.lbl_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_run.Location = new System.Drawing.Point(11, 74);
			this.lbl_run.Name = "lbl_run";
			this.lbl_run.Size = new System.Drawing.Size(24, 13);
			this.lbl_run.TabIndex = 0;
			this.lbl_run.Text = "Rut";
			// 
			// tabSucursal
			// 
			this.tabSucursal.Controls.Add(this.spcSucursal);
			this.tabSucursal.Location = new System.Drawing.Point(4, 22);
			this.tabSucursal.Name = "tabSucursal";
			this.tabSucursal.Padding = new System.Windows.Forms.Padding(3);
			this.tabSucursal.Size = new System.Drawing.Size(1110, 654);
			this.tabSucursal.TabIndex = 1;
			this.tabSucursal.Text = "Sucursal";
			this.tabSucursal.UseVisualStyleBackColor = true;
			// 
			// spcSucursal
			// 
			this.spcSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcSucursal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcSucursal.Location = new System.Drawing.Point(3, 3);
			this.spcSucursal.Name = "spcSucursal";
			this.spcSucursal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spcSucursal.Panel1
			// 
			this.spcSucursal.Panel1.Controls.Add(this.grdDatos);
			// 
			// spcSucursal.Panel2
			// 
			this.spcSucursal.Panel2.Controls.Add(this.button2);
			this.spcSucursal.Panel2.Controls.Add(this.button1);
			this.spcSucursal.Size = new System.Drawing.Size(1104, 648);
			this.spcSucursal.SplitterDistance = 541;
			this.spcSucursal.TabIndex = 7;
			// 
			// grdDatos
			// 
			this.grdDatos.AllowUserToAddRows = false;
			this.grdDatos.AllowUserToDeleteRows = false;
			this.grdDatos.AllowUserToResizeColumns = false;
			this.grdDatos.AllowUserToResizeRows = false;
			this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sucursal,
            this.direccion,
            this.region,
            this.provincia,
            this.comuna,
            this.Telefono,
            this.Estado});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(0, 0);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDatos.Size = new System.Drawing.Size(1104, 541);
			this.grdDatos.TabIndex = 6;
			// 
			// id_sucursal
			// 
			this.id_sucursal.DataPropertyName = "id_sucursal";
			this.id_sucursal.Frozen = true;
			this.id_sucursal.HeaderText = "id_sucursal";
			this.id_sucursal.Name = "id_sucursal";
			this.id_sucursal.ReadOnly = true;
			this.id_sucursal.Visible = false;
			this.id_sucursal.Width = 85;
			// 
			// direccion
			// 
			this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.direccion.DataPropertyName = "direccion";
			this.direccion.FillWeight = 200F;
			this.direccion.HeaderText = "Dirección";
			this.direccion.Name = "direccion";
			this.direccion.ReadOnly = true;
			// 
			// region
			// 
			this.region.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.region.DataPropertyName = "region";
			this.region.HeaderText = "Region";
			this.region.Name = "region";
			this.region.ReadOnly = true;
			// 
			// provincia
			// 
			this.provincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.provincia.DataPropertyName = "provincia";
			this.provincia.FillWeight = 150F;
			this.provincia.HeaderText = "Provincia";
			this.provincia.Name = "provincia";
			this.provincia.ReadOnly = true;
			// 
			// comuna
			// 
			this.comuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.comuna.DataPropertyName = "comuna";
			this.comuna.HeaderText = "Comuna";
			this.comuna.MinimumWidth = 150;
			this.comuna.Name = "comuna";
			this.comuna.ReadOnly = true;
			// 
			// Telefono
			// 
			this.Telefono.DataPropertyName = "Telefono";
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			this.Telefono.Width = 74;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "Estado";
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			this.Estado.Width = 65;
			// 
			// button2
			// 
			this.button2.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(333, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 38);
			this.button2.TabIndex = 24;
			this.button2.Text = "Agregar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Image = global::ControlDosimetro.Properties.Resources.Save_24;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(120, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 38);
			this.button1.TabIndex = 23;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tabPersonal
			// 
			this.tabPersonal.Controls.Add(this.spcPersonal);
			this.tabPersonal.Location = new System.Drawing.Point(4, 22);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Size = new System.Drawing.Size(1110, 654);
			this.tabPersonal.TabIndex = 2;
			this.tabPersonal.Text = "Personal";
			this.tabPersonal.UseVisualStyleBackColor = true;
			// 
			// spcPersonal
			// 
			this.spcPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcPersonal.Location = new System.Drawing.Point(0, 0);
			this.spcPersonal.Name = "spcPersonal";
			this.spcPersonal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spcPersonal.Panel1
			// 
			this.spcPersonal.Panel1.Controls.Add(this.dataGridView1);
			// 
			// spcPersonal.Panel2
			// 
			this.spcPersonal.Panel2.Controls.Add(this.button3);
			this.spcPersonal.Panel2.Controls.Add(this.button4);
			this.spcPersonal.Size = new System.Drawing.Size(1110, 654);
			this.spcPersonal.SplitterDistance = 575;
			this.spcPersonal.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Personal,
            this.Rut,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.ColServicio,
            this.ColSeccion,
            this.ColFechaNac,
            this.ColEstado});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1110, 575);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.VirtualMode = true;
			// 
			// Id_Personal
			// 
			this.Id_Personal.DataPropertyName = "Id_Personal";
			this.Id_Personal.Frozen = true;
			this.Id_Personal.HeaderText = "Id_Personal";
			this.Id_Personal.Name = "Id_Personal";
			this.Id_Personal.Visible = false;
			this.Id_Personal.Width = 88;
			// 
			// Rut
			// 
			this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Rut.DataPropertyName = "Rut";
			this.Rut.HeaderText = "Rut";
			this.Rut.Name = "Rut";
			this.Rut.ReadOnly = true;
			this.Rut.Width = 49;
			// 
			// Nombres
			// 
			this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Nombres.DataPropertyName = "Nombres";
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.MaxInputLength = 100;
			this.Nombres.Name = "Nombres";
			this.Nombres.Width = 74;
			// 
			// Paterno
			// 
			this.Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Paterno.DataPropertyName = "Paterno";
			this.Paterno.FillWeight = 300F;
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.MaxInputLength = 100;
			this.Paterno.Name = "Paterno";
			this.Paterno.Width = 69;
			// 
			// Maternos
			// 
			this.Maternos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Maternos.DataPropertyName = "Maternos";
			this.Maternos.HeaderText = "Maternos";
			this.Maternos.MaxInputLength = 100;
			this.Maternos.MinimumWidth = 150;
			this.Maternos.Name = "Maternos";
			this.Maternos.Width = 150;
			// 
			// ColServicio
			// 
			this.ColServicio.DataPropertyName = "Id_CodServicio";
			this.ColServicio.DisplayStyleForCurrentCellOnly = true;
			this.ColServicio.HeaderText = "Servicio";
			this.ColServicio.Name = "ColServicio";
			this.ColServicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColServicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColServicio.Width = 110;
			// 
			// ColSeccion
			// 
			this.ColSeccion.DataPropertyName = "Id_Seccion";
			this.ColSeccion.DisplayStyleForCurrentCellOnly = true;
			this.ColSeccion.HeaderText = "Sección";
			this.ColSeccion.Name = "ColSeccion";
			this.ColSeccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColSeccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// ColFechaNac
			// 
			this.ColFechaNac.DataPropertyName = "Fecha_Nac";
			this.ColFechaNac.HeaderText = "Fec. nacimiento";
			this.ColFechaNac.MaxInputLength = 10;
			this.ColFechaNac.Name = "ColFechaNac";
			this.ColFechaNac.ToolTipText = "Fecha nacimiento";
			// 
			// ColEstado
			// 
			this.ColEstado.DataPropertyName = "Id_estado";
			this.ColEstado.DisplayStyleForCurrentCellOnly = true;
			this.ColEstado.HeaderText = "Estado";
			this.ColEstado.Name = "ColEstado";
			this.ColEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// button3
			// 
			this.button3.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(488, 18);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(131, 38);
			this.button3.TabIndex = 26;
			this.button3.Text = "Agregar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Image = global::ControlDosimetro.Properties.Resources.Save_24;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(275, 18);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(104, 38);
			this.button4.TabIndex = 25;
			this.button4.Text = "Guardar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// colId_cliente
			// 
			this.colId_cliente.DataPropertyName = "Id_cliente";
			this.colId_cliente.HeaderText = "N°";
			this.colId_cliente.Name = "colId_cliente";
			this.colId_cliente.ReadOnly = true;
			this.colId_cliente.Width = 40;
			// 
			// ColUsuario
			// 
			this.ColUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColUsuario.DataPropertyName = "Razon_Social";
			this.ColUsuario.FillWeight = 108.6294F;
			this.ColUsuario.HeaderText = "Razón social";
			this.ColUsuario.Name = "ColUsuario";
			this.ColUsuario.ReadOnly = true;
			// 
			// ColNombres
			// 
			this.ColNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ColNombres.DataPropertyName = "run";
			this.ColNombres.FillWeight = 91.37056F;
			this.ColNombres.HeaderText = "Rut";
			this.ColNombres.Name = "ColNombres";
			this.ColNombres.ReadOnly = true;
			this.ColNombres.Width = 90;
			// 
			// frmMantenedorCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1535, 730);
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
			this.tbl_cliente.ResumeLayout(false);
			this.tbl_cliente.PerformLayout();
			this.tabSucursal.ResumeLayout(false);
			this.spcSucursal.Panel1.ResumeLayout(false);
			this.spcSucursal.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcSucursal)).EndInit();
			this.spcSucursal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.tabPersonal.ResumeLayout(false);
			this.spcPersonal.Panel1.ResumeLayout(false);
			this.spcPersonal.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcPersonal)).EndInit();
			this.spcPersonal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabCliente;
		private System.Windows.Forms.TabPage tabSucursal;
		private System.Windows.Forms.TabPage tabPersonal;
		private System.Windows.Forms.DataGridView grdDatos;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn region;
		private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
		private System.Windows.Forms.DataGridViewTextBoxColumn comuna;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.SplitContainer spcSucursal;
		private System.Windows.Forms.GroupBox tbl_cliente;
		private System.Windows.Forms.Label lbl_Emailfacturacion;
		private System.Windows.Forms.TextBox txt_Emailfacturacion;
		private System.Windows.Forms.Label lbl_Nombre_fantasia;
		private System.Windows.Forms.TextBox txt_Nombre_fantasia;
		private System.Windows.Forms.TextBox txt_Opr;
		private System.Windows.Forms.Label lbl_Opr;
		private System.Windows.Forms.TextBox txt_Director;
		private System.Windows.Forms.Label lbl_Director;
		private System.Windows.Forms.ComboBox cbx_Id_Sector;
		private System.Windows.Forms.Label lbl_Id_Sector;
		private System.Windows.Forms.ComboBox cbx_id_Ministerio;
		private System.Windows.Forms.Label lbl_id_Ministerio;
		private System.Windows.Forms.ComboBox cbx_Id_TipoEntidad;
		private System.Windows.Forms.Label lbl_Id_TipoEntidad;
		private System.Windows.Forms.ComboBox cbx_id_periodo;
		private System.Windows.Forms.TextBox txt_Clave;
		private System.Windows.Forms.Label lbl_Clave;
		private System.Windows.Forms.TextBox txt_Clave1;
		private System.Windows.Forms.TextBox txt_Servicio;
		private System.Windows.Forms.Label lbl_Servicio;
		private System.Windows.Forms.Label lbl_Email;
		private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.Label lbl_Estado_mod;
		private System.Windows.Forms.TextBox txt_N_Cliente_Ref;
		private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
		private System.Windows.Forms.Label lbl_N_Cliente_Ref;
		private System.Windows.Forms.Label lbl_FechaInicio;
		private System.Windows.Forms.ComboBox cbx_id_estado;
		private System.Windows.Forms.Label lbl_id_estado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbx_Id_TipoFuente;
		private System.Windows.Forms.ComboBox cbx_id_comuna;
		private System.Windows.Forms.ComboBox cbx_id_provincia;
		private System.Windows.Forms.ComboBox cbx_id_region;
		private System.Windows.Forms.Button btn_cerrar;
		private System.Windows.Forms.Button btn_Grabar;
		private System.Windows.Forms.Label lbl_Id_TipoFuente;
		private System.Windows.Forms.TextBox txt_telefono;
		private System.Windows.Forms.Label lbl_telefono;
		private System.Windows.Forms.Label lbl_id_comuna;
		private System.Windows.Forms.Label lbl_id_provincia;
		private System.Windows.Forms.Label lbl_id_region;
		private System.Windows.Forms.TextBox txt_direccion;
		private System.Windows.Forms.Label lbl_direccion;
		private System.Windows.Forms.TextBox txt_Razon_Social;
		private System.Windows.Forms.Label lbl_Razon_Social;
		private System.Windows.Forms.TextBox txt_id_cliente;
		private System.Windows.Forms.Label lbl_id_cliente;
		private System.Windows.Forms.TextBox txt_run;
		private System.Windows.Forms.Label lbl_run;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColSeccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNac;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColEstado;
		private System.Windows.Forms.SplitContainer spcPersonal;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btn_Limpiar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId_cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColNombres;
	}
}