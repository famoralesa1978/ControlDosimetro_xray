namespace ControlDosimetro
{
    partial class frmIngresoDosimetro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoDosimetro));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.btn_Cargar_cliente = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkSeleccionar = new System.Windows.Forms.CheckBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.ColEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_dosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Generar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.chkGenerado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.N_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_estadodosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Cliente = new System.Windows.Forms.ToolStripButton();
			this.btn_Sucursal = new System.Windows.Forms.ToolStripButton();
			this.btn_Excel = new System.Windows.Forms.ToolStripButton();
			this.tsdReporte = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsbGenerar = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsbGenerarTodos = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbGenerarSeleccionado = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbAsignarSucursal = new System.Windows.Forms.ToolStripButton();
			this.tsbAsignarSeccion = new System.Windows.Forms.ToolStripButton();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.btn_Corregir = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkReferencia = new System.Windows.Forms.CheckBox();
			this.txtHasta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDesde = new System.Windows.Forms.TextBox();
			this.btn_Eliminar = new System.Windows.Forms.Button();
			this.btnAgregarRef = new System.Windows.Forms.Button();
			this.btnResfrescar = new System.Windows.Forms.Button();
			this.cbx_Sucursal = new System.Windows.Forms.ComboBox();
			this.txtNDocumento = new System.Windows.Forms.TextBox();
			this.grpEncabezado = new System.Windows.Forms.GroupBox();
			this.dtp_Fecha_dev = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_Servicio = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tsbAsignar = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.grpEncabezado.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.lbl_rut_cliente);
			this.groupBox1.Controls.Add(this.btn_Cargar_cliente);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(844, 96);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DisplayMember = "Trimestre";
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(280, 64);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 60;
			this.cbx_id_periodo.ValueMember = "Id_Periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DisplayMember = "anno";
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(78, 64);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 59;
			this.cbx_anno.ValueMember = "anno";
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.Cbx_anno_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(225, 43);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 58;
			this.label8.Text = "Nombre";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 42);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 57;
			this.label11.Text = "Rut";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(302, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(0, 13);
			this.label9.TabIndex = 56;
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(83, 42);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut_cliente.TabIndex = 55;
			// 
			// btn_Cargar_cliente
			// 
			this.btn_Cargar_cliente.Location = new System.Drawing.Point(137, 15);
			this.btn_Cargar_cliente.Name = "btn_Cargar_cliente";
			this.btn_Cargar_cliente.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_cliente.TabIndex = 52;
			this.btn_Cargar_cliente.Text = "Cargar Cliente";
			this.btn_Cargar_cliente.UseVisualStyleBackColor = true;
			this.btn_Cargar_cliente.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(78, 17);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 50;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(296, 43);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 51;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(280, 16);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(225, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Año";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.chkSeleccionar);
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(5, 272);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1079, 376);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// chkSeleccionar
			// 
			this.chkSeleccionar.AutoSize = true;
			this.chkSeleccionar.Location = new System.Drawing.Point(729, -1);
			this.chkSeleccionar.Name = "chkSeleccionar";
			this.chkSeleccionar.Size = new System.Drawing.Size(111, 17);
			this.chkSeleccionar.TabIndex = 10;
			this.chkSeleccionar.Text = "Seleccionar todos";
			this.chkSeleccionar.UseVisualStyleBackColor = true;
			this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.pgb_Barra);
			this.pnl_Progreso.Location = new System.Drawing.Point(57, 131);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(787, 118);
			this.pnl_Progreso.TabIndex = 9;
			this.pnl_Progreso.TabStop = false;
			this.pnl_Progreso.Text = "Progreso de Grabado";
			// 
			// pgb_Barra
			// 
			this.pgb_Barra.Location = new System.Drawing.Point(21, 43);
			this.pgb_Barra.Name = "pgb_Barra";
			this.pgb_Barra.Size = new System.Drawing.Size(749, 23);
			this.pgb_Barra.TabIndex = 0;
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
            this.ColEliminar,
            this.Id_Personal,
            this.N_pelicula,
            this.id_dosimetro,
            this.Generar,
            this.chkGenerado,
            this.N_Cliente,
            this.NDocumento,
            this.Rut,
            this.ColServicio,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.id_sucursal,
            this.id_estadodosimetro});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(1073, 357);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			this.grdDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
			// 
			// ColEliminar
			// 
			this.ColEliminar.DataPropertyName = "Eliminar";
			this.ColEliminar.HeaderText = "Eliminar";
			this.ColEliminar.Name = "ColEliminar";
			this.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColEliminar.Width = 68;
			// 
			// Id_Personal
			// 
			this.Id_Personal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Id_Personal.DataPropertyName = "Id_Personal";
			this.Id_Personal.HeaderText = "Id_Personal";
			this.Id_Personal.Name = "Id_Personal";
			this.Id_Personal.ReadOnly = true;
			this.Id_Personal.Visible = false;
			// 
			// N_pelicula
			// 
			this.N_pelicula.DataPropertyName = "N_pelicula";
			this.N_pelicula.HeaderText = "Nº Pelicula";
			this.N_pelicula.Name = "N_pelicula";
			this.N_pelicula.ReadOnly = true;
			this.N_pelicula.Width = 84;
			// 
			// id_dosimetro
			// 
			this.id_dosimetro.DataPropertyName = "id_dosimetro";
			this.id_dosimetro.HeaderText = "Id_dosimetro";
			this.id_dosimetro.Name = "id_dosimetro";
			this.id_dosimetro.Visible = false;
			this.id_dosimetro.Width = 92;
			// 
			// Generar
			// 
			this.Generar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Generar.DataPropertyName = "generar";
			this.Generar.FalseValue = "0";
			this.Generar.HeaderText = "Seleccionar";
			this.Generar.Name = "Generar";
			this.Generar.TrueValue = "1";
			this.Generar.Width = 69;
			// 
			// chkGenerado
			// 
			this.chkGenerado.DataPropertyName = "Generado";
			this.chkGenerado.FalseValue = "0";
			this.chkGenerado.HeaderText = "Generado";
			this.chkGenerado.Name = "chkGenerado";
			this.chkGenerado.TrueValue = "1";
			this.chkGenerado.Width = 60;
			// 
			// N_Cliente
			// 
			this.N_Cliente.DataPropertyName = "Id_Cliente";
			this.N_Cliente.HeaderText = "N° Cliente";
			this.N_Cliente.Name = "N_Cliente";
			this.N_Cliente.Width = 79;
			// 
			// NDocumento
			// 
			this.NDocumento.DataPropertyName = "N_Documento";
			this.NDocumento.HeaderText = "N° Documento";
			this.NDocumento.Name = "NDocumento";
			this.NDocumento.ReadOnly = true;
			this.NDocumento.Width = 102;
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
			// ColServicio
			// 
			this.ColServicio.DataPropertyName = "Servicio";
			this.ColServicio.HeaderText = "Servicio";
			this.ColServicio.Name = "ColServicio";
			this.ColServicio.ReadOnly = true;
			this.ColServicio.Width = 70;
			// 
			// Nombres
			// 
			this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Nombres.DataPropertyName = "Nombres";
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.MinimumWidth = 150;
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			this.Nombres.Width = 150;
			// 
			// Paterno
			// 
			this.Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Paterno.DataPropertyName = "Paterno";
			this.Paterno.FillWeight = 300F;
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.Name = "Paterno";
			this.Paterno.ReadOnly = true;
			// 
			// Maternos
			// 
			this.Maternos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Maternos.DataPropertyName = "Maternos";
			this.Maternos.HeaderText = "Maternos";
			this.Maternos.MinimumWidth = 150;
			this.Maternos.Name = "Maternos";
			this.Maternos.ReadOnly = true;
			// 
			// id_sucursal
			// 
			this.id_sucursal.DataPropertyName = "id_sucursal";
			this.id_sucursal.HeaderText = "id_sucursal";
			this.id_sucursal.Name = "id_sucursal";
			this.id_sucursal.Visible = false;
			this.id_sucursal.Width = 85;
			// 
			// id_estadodosimetro
			// 
			this.id_estadodosimetro.DataPropertyName = "id_estadodosimetro";
			this.id_estadodosimetro.HeaderText = "id_estadodosimetro";
			this.id_estadodosimetro.Name = "id_estadodosimetro";
			this.id_estadodosimetro.Visible = false;
			this.id_estadodosimetro.Width = 123;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cliente,
            this.btn_Sucursal,
            this.btn_Excel,
            this.tsdReporte,
            this.tsbGenerar,
            this.tsbAsignarSucursal,
            this.tsbAsignarSeccion,
            this.tsbAsignar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1084, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Cliente
			// 
			this.btn_Cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Cliente.Image = global::ControlDosimetro.Properties.Resources.cliente;
			this.btn_Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Cliente.Name = "btn_Cliente";
			this.btn_Cliente.Size = new System.Drawing.Size(24, 24);
			this.btn_Cliente.Text = "Cliente";
			this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
			// 
			// btn_Sucursal
			// 
			this.btn_Sucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Sucursal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sucursal.Image")));
			this.btn_Sucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Sucursal.Name = "btn_Sucursal";
			this.btn_Sucursal.Size = new System.Drawing.Size(55, 24);
			this.btn_Sucursal.Text = "Sucursal";
			this.btn_Sucursal.Click += new System.EventHandler(this.btn_Sucursal_Click);
			// 
			// btn_Excel
			// 
			this.btn_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Excel.Image = global::ControlDosimetro.Properties.Resources.excel;
			this.btn_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Excel.Name = "btn_Excel";
			this.btn_Excel.Size = new System.Drawing.Size(24, 24);
			this.btn_Excel.ToolTipText = "Descargar Excel";
			this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
			// 
			// tsdReporte
			// 
			this.tsdReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsdReporte.Image")));
			this.tsdReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdReporte.Name = "tsdReporte";
			this.tsdReporte.Size = new System.Drawing.Size(61, 24);
			this.tsdReporte.Text = "Reporte";
			// 
			// tsbGenerar
			// 
			this.tsbGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGenerar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGenerarTodos,
            this.tsbGenerarSeleccionado});
			this.tsbGenerar.Image = global::ControlDosimetro.Properties.Resources.excel;
			this.tsbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbGenerar.Name = "tsbGenerar";
			this.tsbGenerar.Size = new System.Drawing.Size(33, 24);
			this.tsbGenerar.Text = "toolStripDropDownButton1";
			this.tsbGenerar.Visible = false;
			// 
			// tsbGenerarTodos
			// 
			this.tsbGenerarTodos.Name = "tsbGenerarTodos";
			this.tsbGenerarTodos.Size = new System.Drawing.Size(187, 22);
			this.tsbGenerarTodos.Text = "Generar todos";
			// 
			// tsbGenerarSeleccionado
			// 
			this.tsbGenerarSeleccionado.Name = "tsbGenerarSeleccionado";
			this.tsbGenerarSeleccionado.Size = new System.Drawing.Size(187, 22);
			this.tsbGenerarSeleccionado.Text = "Generar seleccionado";
			// 
			// tsbAsignarSucursal
			// 
			this.tsbAsignarSucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbAsignarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsignarSucursal.Image")));
			this.tsbAsignarSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAsignarSucursal.Name = "tsbAsignarSucursal";
			this.tsbAsignarSucursal.Size = new System.Drawing.Size(98, 24);
			this.tsbAsignarSucursal.Text = "Asignar Sucursal";
			this.tsbAsignarSucursal.Click += new System.EventHandler(this.tsbAsignarSucursal_Click);
			// 
			// tsbAsignarSeccion
			// 
			this.tsbAsignarSeccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbAsignarSeccion.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsignarSeccion.Image")));
			this.tsbAsignarSeccion.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAsignarSeccion.Name = "tsbAsignarSeccion";
			this.tsbAsignarSeccion.Size = new System.Drawing.Size(95, 24);
			this.tsbAsignarSeccion.Text = "Asignar Sección";
			this.tsbAsignarSeccion.Click += new System.EventHandler(this.tsbAsignarSeccion_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Location = new System.Drawing.Point(491, 655);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(139, 23);
			this.btn_Guardar.TabIndex = 7;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(815, 655);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
			// 
			// btn_Corregir
			// 
			this.btn_Corregir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Corregir.Location = new System.Drawing.Point(334, 654);
			this.btn_Corregir.Name = "btn_Corregir";
			this.btn_Corregir.Size = new System.Drawing.Size(126, 23);
			this.btn_Corregir.TabIndex = 9;
			this.btn_Corregir.Text = "Asignar n° TLD";
			this.btn_Corregir.UseVisualStyleBackColor = true;
			this.btn_Corregir.Click += new System.EventHandler(this.btn_Corregir_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Dirección";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkReferencia);
			this.groupBox3.Controls.Add(this.txtHasta);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtDesde);
			this.groupBox3.Location = new System.Drawing.Point(483, 5);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(315, 89);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Asginar N°  de fílmico";
			// 
			// chkReferencia
			// 
			this.chkReferencia.AutoSize = true;
			this.chkReferencia.Location = new System.Drawing.Point(207, 22);
			this.chkReferencia.Name = "chkReferencia";
			this.chkReferencia.Size = new System.Drawing.Size(78, 17);
			this.chkReferencia.TabIndex = 40;
			this.chkReferencia.Text = "Referencia";
			this.chkReferencia.UseVisualStyleBackColor = true;
			// 
			// txtHasta
			// 
			this.txtHasta.Location = new System.Drawing.Point(82, 47);
			this.txtHasta.Name = "txtHasta";
			this.txtHasta.Size = new System.Drawing.Size(100, 20);
			this.txtHasta.TabIndex = 39;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "Hasta";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 37;
			this.label5.Text = "Desde";
			// 
			// txtDesde
			// 
			this.txtDesde.Location = new System.Drawing.Point(82, 19);
			this.txtDesde.Name = "txtDesde";
			this.txtDesde.Size = new System.Drawing.Size(100, 20);
			this.txtDesde.TabIndex = 0;
			// 
			// btn_Eliminar
			// 
			this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Eliminar.Location = new System.Drawing.Point(650, 655);
			this.btn_Eliminar.Name = "btn_Eliminar";
			this.btn_Eliminar.Size = new System.Drawing.Size(139, 23);
			this.btn_Eliminar.TabIndex = 18;
			this.btn_Eliminar.Text = "Eliminar";
			this.btn_Eliminar.UseVisualStyleBackColor = true;
			this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
			// 
			// btnAgregarRef
			// 
			this.btnAgregarRef.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAgregarRef.Location = new System.Drawing.Point(167, 654);
			this.btnAgregarRef.Name = "btnAgregarRef";
			this.btnAgregarRef.Size = new System.Drawing.Size(147, 23);
			this.btnAgregarRef.TabIndex = 11;
			this.btnAgregarRef.Text = "Agregar referencia";
			this.btnAgregarRef.UseVisualStyleBackColor = true;
			this.btnAgregarRef.Click += new System.EventHandler(this.btnAgregarRef_Click);
			// 
			// btnResfrescar
			// 
			this.btnResfrescar.Image = global::ControlDosimetro.Properties.Resources.filter_16;
			this.btnResfrescar.Location = new System.Drawing.Point(625, 130);
			this.btnResfrescar.Name = "btnResfrescar";
			this.btnResfrescar.Size = new System.Drawing.Size(26, 23);
			this.btnResfrescar.TabIndex = 19;
			this.btnResfrescar.UseVisualStyleBackColor = true;
			this.btnResfrescar.Click += new System.EventHandler(this.btnResfrescar_Click);
			// 
			// cbx_Sucursal
			// 
			this.cbx_Sucursal.DisplayMember = "Direccion";
			this.cbx_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Sucursal.FormattingEnabled = true;
			this.cbx_Sucursal.Location = new System.Drawing.Point(83, 130);
			this.cbx_Sucursal.Name = "cbx_Sucursal";
			this.cbx_Sucursal.Size = new System.Drawing.Size(526, 21);
			this.cbx_Sucursal.TabIndex = 20;
			this.cbx_Sucursal.ValueMember = "Id_sucursal";
			// 
			// txtNDocumento
			// 
			this.txtNDocumento.Location = new System.Drawing.Point(134, 23);
			this.txtNDocumento.Name = "txtNDocumento";
			this.txtNDocumento.Size = new System.Drawing.Size(100, 20);
			this.txtNDocumento.TabIndex = 0;
			// 
			// grpEncabezado
			// 
			this.grpEncabezado.Controls.Add(this.dtp_Fecha_dev);
			this.grpEncabezado.Controls.Add(this.label13);
			this.grpEncabezado.Controls.Add(this.txt_Servicio);
			this.grpEncabezado.Controls.Add(this.label10);
			this.grpEncabezado.Controls.Add(this.txtNDocumento);
			this.grpEncabezado.Controls.Add(this.label7);
			this.grpEncabezado.Controls.Add(this.groupBox3);
			this.grpEncabezado.Location = new System.Drawing.Point(8, 157);
			this.grpEncabezado.Name = "grpEncabezado";
			this.grpEncabezado.Size = new System.Drawing.Size(1073, 100);
			this.grpEncabezado.TabIndex = 21;
			this.grpEncabezado.TabStop = false;
			this.grpEncabezado.Text = "Datos";
			// 
			// dtp_Fecha_dev
			// 
			this.dtp_Fecha_dev.CustomFormat = "dd-MMMMMMMMMMM-yyyy";
			this.dtp_Fecha_dev.Enabled = false;
			this.dtp_Fecha_dev.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Fecha_dev.Location = new System.Drawing.Point(134, 75);
			this.dtp_Fecha_dev.Name = "dtp_Fecha_dev";
			this.dtp_Fecha_dev.Size = new System.Drawing.Size(132, 20);
			this.dtp_Fecha_dev.TabIndex = 27;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 79);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "Fecha Devolución";
			// 
			// txt_Servicio
			// 
			this.txt_Servicio.Location = new System.Drawing.Point(134, 49);
			this.txt_Servicio.MaxLength = 100;
			this.txt_Servicio.Name = "txt_Servicio";
			this.txt_Servicio.Size = new System.Drawing.Size(329, 20);
			this.txt_Servicio.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 52);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "Servicio";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Número documento";
			// 
			// tsbAsignar
			// 
			this.tsbAsignar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbAsignar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsignar.Image")));
			this.tsbAsignar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAsignar.Name = "tsbAsignar";
			this.tsbAsignar.Size = new System.Drawing.Size(51, 24);
			this.tsbAsignar.Text = "Asignar";
			this.tsbAsignar.ToolTipText = "Asignar dirección o sección";
			this.tsbAsignar.Click += new System.EventHandler(this.tsbAsignar_Click);
			// 
			// frmIngresoDosimetro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 686);
			this.Controls.Add(this.grpEncabezado);
			this.Controls.Add(this.cbx_Sucursal);
			this.Controls.Add(this.btnResfrescar);
			this.Controls.Add(this.btnAgregarRef);
			this.Controls.Add(this.btn_Eliminar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Corregir);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 462);
			this.Name = "frmIngresoDosimetro";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso filmico";
			this.Load += new System.EventHandler(this.frmIngresoDosimetro_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.grpEncabezado.ResumeLayout(false);
			this.grpEncabezado.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Button btn_Guardar;
								private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_filtro;
                                private System.Windows.Forms.GroupBox pnl_Progreso;
                                private System.Windows.Forms.ProgressBar pgb_Barra;
                                private System.Windows.Forms.Button btn_Corregir;
                                private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.ToolStripButton btn_Sucursal;
                                private System.Windows.Forms.Button btn_Cargar_cliente;
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.ToolStripDropDownButton tsdReporte;
        private System.Windows.Forms.ToolStripButton btn_Cliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDesde;
		private System.Windows.Forms.Button btn_Eliminar;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_pelicula;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_dosimetro;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Generar;
		private System.Windows.Forms.DataGridViewCheckBoxColumn chkGenerado;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn NDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_estadodosimetro;
		private System.Windows.Forms.CheckBox chkSeleccionar;
		private System.Windows.Forms.Button btnAgregarRef;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_rut_cliente;
		private System.Windows.Forms.Button btnResfrescar;
		private System.Windows.Forms.ComboBox cbx_id_periodo;
		private System.Windows.Forms.ComboBox cbx_anno;
		private System.Windows.Forms.ComboBox cbx_Sucursal;
		private System.Windows.Forms.ToolStripDropDownButton tsbGenerar;
		private System.Windows.Forms.ToolStripMenuItem tsbGenerarTodos;
		private System.Windows.Forms.ToolStripMenuItem tsbGenerarSeleccionado;
		private System.Windows.Forms.ToolStripButton tsbAsignarSucursal;
		private System.Windows.Forms.ToolStripButton tsbAsignarSeccion;
		private System.Windows.Forms.TextBox txtHasta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNDocumento;
		private System.Windows.Forms.CheckBox chkReferencia;
		private System.Windows.Forms.GroupBox grpEncabezado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_Servicio;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtp_Fecha_dev;
		private System.Windows.Forms.ToolStripButton tsbAsignar;
	}
}