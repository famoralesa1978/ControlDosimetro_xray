namespace ControlDosimetro
{
	partial class frmIngresoDosimetriaDos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoDosimetriaDos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_Agregar = new System.Windows.Forms.Button();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.txt_nombres = new System.Windows.Forms.TextBox();
			this.txt_rut = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grp_ingreso = new System.Windows.Forms.GroupBox();
			this.lbl_fila = new System.Windows.Forms.Label();
			this.btn_ocultar = new System.Windows.Forms.Button();
			this.dgvAyuda = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_PeliculaAyuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.n_documentoAyuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_BuscarDosimetro = new System.Windows.Forms.Button();
			this.txt_NDocumento = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_dosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NDocumento = new GridExtension.IntegerGridColumn();
			this.N_Pelicula = new GridExtension.IntegerGridColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Controlado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.condosis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.valor = new GridExtension.RealGridColumn();
			this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmEliminarPersonal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmModificarPersonal = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnIngresarDosisISP = new System.Windows.Forms.ToolStripButton();
			this.btn_reporte = new System.Windows.Forms.ToolStripDropDownButton();
			this.estadoDosimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.integerGridColumn1 = new GridExtension.IntegerGridColumn();
			this.integerGridColumn2 = new GridExtension.IntegerGridColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.grp_ingreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAyuda)).BeginInit();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.cmsPopup.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_rut_cliente);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.btn_cargar);
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(844, 170);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(358, 20);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(53, 13);
			this.lbl_rut_cliente.TabIndex = 45;
			this.lbl_rut_cliente.Text = "rut cliente";
			this.lbl_rut_cliente.Visible = false;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(297, 67);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(216, 67);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 3;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(87, 67);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 43;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(146, 19);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombreCliente.TabIndex = 42;
			this.lbl_nombreCliente.Text = "label1";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Location = new System.Drawing.Point(92, 20);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_id_cliente.TabIndex = 41;
			this.lbl_id_cliente.Text = "label1";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn_Agregar);
			this.groupBox3.Controls.Add(this.btn_Buscar);
			this.groupBox3.Controls.Add(this.txt_nombres);
			this.groupBox3.Controls.Add(this.txt_rut);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(7, 96);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(571, 73);
			this.groupBox3.TabIndex = 38;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Busqueda";
			// 
			// btn_Agregar
			// 
			this.btn_Agregar.Location = new System.Drawing.Point(239, 15);
			this.btn_Agregar.Name = "btn_Agregar";
			this.btn_Agregar.Size = new System.Drawing.Size(106, 23);
			this.btn_Agregar.TabIndex = 7;
			this.btn_Agregar.Text = "Agregar personal";
			this.btn_Agregar.UseVisualStyleBackColor = true;
			this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.Location = new System.Drawing.Point(354, 15);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
			this.btn_Buscar.TabIndex = 6;
			this.btn_Buscar.Text = "Buscar";
			this.btn_Buscar.UseVisualStyleBackColor = true;
			this.btn_Buscar.Visible = false;
			this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
			// 
			// txt_nombres
			// 
			this.txt_nombres.Location = new System.Drawing.Point(80, 44);
			this.txt_nombres.MaxLength = 200;
			this.txt_nombres.Name = "txt_nombres";
			this.txt_nombres.Size = new System.Drawing.Size(485, 20);
			this.txt_nombres.TabIndex = 5;
			this.txt_nombres.TextChanged += new System.EventHandler(this.txt_nombres_TextChanged);
			// 
			// txt_rut
			// 
			this.txt_rut.Location = new System.Drawing.Point(80, 17);
			this.txt_rut.MaxLength = 10;
			this.txt_rut.Name = "txt_rut";
			this.txt_rut.Size = new System.Drawing.Size(100, 20);
			this.txt_rut.TabIndex = 4;
			this.txt_rut.TextChanged += new System.EventHandler(this.txt_rut_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Nombres";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Rut";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(87, 42);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 45);
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
			this.groupBox2.Controls.Add(this.grp_ingreso);
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(5, 204);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1179, 364);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// grp_ingreso
			// 
			this.grp_ingreso.Controls.Add(this.lbl_fila);
			this.grp_ingreso.Controls.Add(this.btn_ocultar);
			this.grp_ingreso.Controls.Add(this.dgvAyuda);
			this.grp_ingreso.Controls.Add(this.btn_BuscarDosimetro);
			this.grp_ingreso.Controls.Add(this.txt_NDocumento);
			this.grp_ingreso.Controls.Add(this.label6);
			this.grp_ingreso.Location = new System.Drawing.Point(429, 76);
			this.grp_ingreso.Name = "grp_ingreso";
			this.grp_ingreso.Size = new System.Drawing.Size(353, 260);
			this.grp_ingreso.TabIndex = 11;
			this.grp_ingreso.TabStop = false;
			this.grp_ingreso.Text = "Ingreso Datos";
			// 
			// lbl_fila
			// 
			this.lbl_fila.AutoSize = true;
			this.lbl_fila.Location = new System.Drawing.Point(293, 20);
			this.lbl_fila.Name = "lbl_fila";
			this.lbl_fila.Size = new System.Drawing.Size(35, 13);
			this.lbl_fila.TabIndex = 17;
			this.lbl_fila.Text = "label7";
			this.lbl_fila.Visible = false;
			// 
			// btn_ocultar
			// 
			this.btn_ocultar.Location = new System.Drawing.Point(9, 231);
			this.btn_ocultar.Name = "btn_ocultar";
			this.btn_ocultar.Size = new System.Drawing.Size(75, 23);
			this.btn_ocultar.TabIndex = 16;
			this.btn_ocultar.Text = "Ocultar";
			this.btn_ocultar.UseVisualStyleBackColor = true;
			this.btn_ocultar.Click += new System.EventHandler(this.btn_ocultar_Click);
			// 
			// dgvAyuda
			// 
			this.dgvAyuda.AllowUserToAddRows = false;
			this.dgvAyuda.AllowUserToDeleteRows = false;
			this.dgvAyuda.AllowUserToResizeColumns = false;
			this.dgvAyuda.AllowUserToResizeRows = false;
			this.dgvAyuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAyuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.N_PeliculaAyuda,
            this.n_documentoAyuda});
			this.dgvAyuda.Location = new System.Drawing.Point(9, 59);
			this.dgvAyuda.Name = "dgvAyuda";
			this.dgvAyuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAyuda.Size = new System.Drawing.Size(338, 170);
			this.dgvAyuda.TabIndex = 15;
			this.dgvAyuda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAyuda_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// N_PeliculaAyuda
			// 
			this.N_PeliculaAyuda.DataPropertyName = "n_dosimetro";
			this.N_PeliculaAyuda.HeaderText = "N° Pelicula";
			this.N_PeliculaAyuda.Name = "N_PeliculaAyuda";
			this.N_PeliculaAyuda.ReadOnly = true;
			// 
			// n_documentoAyuda
			// 
			this.n_documentoAyuda.DataPropertyName = "N_documento";
			this.n_documentoAyuda.HeaderText = "N° Documento";
			this.n_documentoAyuda.Name = "n_documentoAyuda";
			this.n_documentoAyuda.ReadOnly = true;
			// 
			// btn_BuscarDosimetro
			// 
			this.btn_BuscarDosimetro.Location = new System.Drawing.Point(211, 21);
			this.btn_BuscarDosimetro.Name = "btn_BuscarDosimetro";
			this.btn_BuscarDosimetro.Size = new System.Drawing.Size(75, 23);
			this.btn_BuscarDosimetro.TabIndex = 14;
			this.btn_BuscarDosimetro.Text = "Buscar";
			this.btn_BuscarDosimetro.UseVisualStyleBackColor = true;
			this.btn_BuscarDosimetro.Click += new System.EventHandler(this.btn_BuscarDosimetro_Click);
			// 
			// txt_NDocumento
			// 
			this.txt_NDocumento.Location = new System.Drawing.Point(90, 21);
			this.txt_NDocumento.Name = "txt_NDocumento";
			this.txt_NDocumento.Size = new System.Drawing.Size(100, 20);
			this.txt_NDocumento.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "N° Documento";
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.pgb_Barra);
			this.pnl_Progreso.Location = new System.Drawing.Point(95, 88);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(787, 118);
			this.pnl_Progreso.TabIndex = 10;
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
            this.Id_Personal,
            this.id_dosimetro,
            this.N_Cliente,
            this.NDocumento,
            this.N_Pelicula,
            this.Rut,
            this.Paterno,
            this.Maternos,
            this.Nombres,
            this.Controlado,
            this.condosis,
            this.valor,
            this.Estado});
			this.grdDatos.ContextMenuStrip = this.cmsPopup;
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(1173, 345);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellClick);
			this.grdDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellDoubleClick);
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			this.grdDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
			// 
			// Id_Personal
			// 
			this.Id_Personal.DataPropertyName = "Id_Personal";
			this.Id_Personal.HeaderText = "Id_Personal";
			this.Id_Personal.Name = "Id_Personal";
			this.Id_Personal.ReadOnly = true;
			this.Id_Personal.Visible = false;
			this.Id_Personal.Width = 88;
			// 
			// id_dosimetro
			// 
			this.id_dosimetro.DataPropertyName = "id_dosimetro";
			this.id_dosimetro.HeaderText = "Id_dosimetro";
			this.id_dosimetro.Name = "id_dosimetro";
			this.id_dosimetro.Visible = false;
			this.id_dosimetro.Width = 92;
			// 
			// N_Cliente
			// 
			this.N_Cliente.DataPropertyName = "Id_Cliente";
			this.N_Cliente.HeaderText = "N° Cliente";
			this.N_Cliente.Name = "N_Cliente";
			this.N_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.N_Cliente.Width = 79;
			// 
			// NDocumento
			// 
			this.NDocumento.DataPropertyName = "N_Documento";
			this.NDocumento.HeaderText = "N° Documento";
			this.NDocumento.Name = "NDocumento";
			this.NDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.NDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.NDocumento.Width = 102;
			// 
			// N_Pelicula
			// 
			this.N_Pelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.N_Pelicula.DataPropertyName = "N_Pelicula";
			this.N_Pelicula.HeaderText = "Nº Pelicula";
			this.N_Pelicula.Name = "N_Pelicula";
			this.N_Pelicula.ReadOnly = true;
			this.N_Pelicula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.N_Pelicula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.N_Pelicula.Width = 84;
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
			// Paterno
			// 
			this.Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Paterno.DataPropertyName = "Paterno";
			this.Paterno.FillWeight = 300F;
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.Name = "Paterno";
			this.Paterno.ReadOnly = true;
			this.Paterno.Width = 69;
			// 
			// Maternos
			// 
			this.Maternos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Maternos.DataPropertyName = "Maternos";
			this.Maternos.HeaderText = "Maternos";
			this.Maternos.MinimumWidth = 150;
			this.Maternos.Name = "Maternos";
			this.Maternos.ReadOnly = true;
			this.Maternos.Width = 150;
			// 
			// Nombres
			// 
			this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Nombres.DataPropertyName = "Nombres";
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			this.Nombres.Width = 74;
			// 
			// Controlado
			// 
			this.Controlado.DataPropertyName = "Controlado";
			this.Controlado.FalseValue = "0";
			this.Controlado.HeaderText = "Controlado";
			this.Controlado.IndeterminateValue = "";
			this.Controlado.Name = "Controlado";
			this.Controlado.TrueValue = "1";
			this.Controlado.Width = 64;
			// 
			// condosis
			// 
			this.condosis.DataPropertyName = "condosis";
			this.condosis.FalseValue = "0";
			this.condosis.HeaderText = "Con Dosis";
			this.condosis.IndeterminateValue = "";
			this.condosis.Name = "condosis";
			this.condosis.TrueValue = "1";
			this.condosis.Width = 61;
			// 
			// valor
			// 
			this.valor.DataPropertyName = "dosis";
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.valor.DefaultCellStyle = dataGridViewCellStyle1;
			this.valor.HeaderText = "Valor Ingresar";
			this.valor.Name = "valor";
			this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.valor.Width = 97;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "estadodosis";
			this.Estado.HeaderText = "Estado Controlado";
			this.Estado.Name = "Estado";
			// 
			// cmsPopup
			// 
			this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminarPersonal,
            this.tsmModificarPersonal});
			this.cmsPopup.Name = "contextMenuStrip1";
			this.cmsPopup.Size = new System.Drawing.Size(193, 48);
			// 
			// tsmEliminarPersonal
			// 
			this.tsmEliminarPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsmEliminarPersonal.Name = "tsmEliminarPersonal";
			this.tsmEliminarPersonal.Size = new System.Drawing.Size(192, 22);
			this.tsmEliminarPersonal.Text = "Eliminar Personal";
			this.tsmEliminarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tsmEliminarPersonal.Click += new System.EventHandler(this.tsmEliminarPersonal_Click);
			// 
			// tsmModificarPersonal
			// 
			this.tsmModificarPersonal.Name = "tsmModificarPersonal";
			this.tsmModificarPersonal.Size = new System.Drawing.Size(192, 22);
			this.tsmModificarPersonal.Text = "Modificación Personal";
			this.tsmModificarPersonal.Click += new System.EventHandler(this.tsmModificarPersonal_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIngresarDosisISP,
            this.btn_reporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnIngresarDosisISP
			// 
			this.btnIngresarDosisISP.BackColor = System.Drawing.Color.SkyBlue;
			this.btnIngresarDosisISP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnIngresarDosisISP.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarDosisISP.Image")));
			this.btnIngresarDosisISP.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnIngresarDosisISP.Name = "btnIngresarDosisISP";
			this.btnIngresarDosisISP.Size = new System.Drawing.Size(58, 22);
			this.btnIngresarDosisISP.Text = "Dosis ISP";
			this.btnIngresarDosisISP.ToolTipText = "Dosis ISP";
			this.btnIngresarDosisISP.Click += new System.EventHandler(this.btnIngresarDosisISP_Click);
			// 
			// btn_reporte
			// 
			this.btn_reporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_reporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDosimetroToolStripMenuItem});
			this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
			this.btn_reporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_reporte.Name = "btn_reporte";
			this.btn_reporte.Size = new System.Drawing.Size(61, 22);
			this.btn_reporte.Text = "Reporte";
			this.btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// estadoDosimetroToolStripMenuItem
			// 
			this.estadoDosimetroToolStripMenuItem.Name = "estadoDosimetroToolStripMenuItem";
			this.estadoDosimetroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.estadoDosimetroToolStripMenuItem.Text = "Estado Dosimetro";
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Location = new System.Drawing.Point(350, 575);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
			this.btn_Guardar.TabIndex = 7;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(522, 574);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Personal";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id_Personal";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 88;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_dosimetro";
			this.dataGridViewTextBoxColumn2.HeaderText = "Id_dosimetro";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Visible = false;
			this.dataGridViewTextBoxColumn2.Width = 92;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Cliente";
			this.dataGridViewTextBoxColumn3.HeaderText = "N° Cliente";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.Width = 79;
			// 
			// integerGridColumn1
			// 
			this.integerGridColumn1.DataPropertyName = "N_Documento";
			this.integerGridColumn1.HeaderText = "N° Documento";
			this.integerGridColumn1.Name = "integerGridColumn1";
			this.integerGridColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.integerGridColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.integerGridColumn1.Width = 102;
			// 
			// integerGridColumn2
			// 
			this.integerGridColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.integerGridColumn2.DataPropertyName = "N_Pelicula";
			this.integerGridColumn2.HeaderText = "Nº Pelicula";
			this.integerGridColumn2.Name = "integerGridColumn2";
			this.integerGridColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.integerGridColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "N_Documento";
			this.dataGridViewTextBoxColumn4.HeaderText = "N° Documento";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "N_Pelicula";
			this.dataGridViewTextBoxColumn5.HeaderText = "Nº Pelicula";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Rut";
			this.dataGridViewTextBoxColumn6.FillWeight = 300F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Rut";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombres";
			this.dataGridViewTextBoxColumn7.HeaderText = "Nombres";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Paterno";
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn8.FillWeight = 300F;
			this.dataGridViewTextBoxColumn8.HeaderText = "Paterno";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Maternos";
			this.dataGridViewTextBoxColumn9.HeaderText = "Maternos";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "dosis";
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// frmIngresoDosimetriaDos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 606);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 464);
			this.Name = "frmIngresoDosimetriaDos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso Dosimetria por dosimetro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.grp_ingreso.ResumeLayout(false);
			this.grp_ingreso.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAyuda)).EndInit();
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.cmsPopup.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
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
								private System.Windows.Forms.ComboBox cbx_anno;
								private System.Windows.Forms.GroupBox groupBox3;
								private System.Windows.Forms.Label label5;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.TextBox txt_rut;
								private System.Windows.Forms.TextBox txt_nombres;
								private System.Windows.Forms.Button btn_Buscar;
								private System.Windows.Forms.Button btn_Agregar;
								private System.Windows.Forms.Label lbl_nombreCliente;
								private System.Windows.Forms.Label lbl_id_cliente;
								private System.Windows.Forms.ComboBox cbx_id_periodo;
								private System.Windows.Forms.Button btn_cargar;
								private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.Button btn_Cerrar;
								private System.Windows.Forms.Button btn_filtro;
                                private System.Windows.Forms.ToolStripButton btnIngresarDosisISP;
                                private System.Windows.Forms.GroupBox pnl_Progreso;
                                private System.Windows.Forms.ProgressBar pgb_Barra;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
                                private GridExtension.IntegerGridColumn integerGridColumn1;
                                private GridExtension.IntegerGridColumn integerGridColumn2;
                                private System.Windows.Forms.GroupBox grp_ingreso;
                                private System.Windows.Forms.DataGridView dgvAyuda;
                                private System.Windows.Forms.Button btn_BuscarDosimetro;
                                private System.Windows.Forms.TextBox txt_NDocumento;
                                private System.Windows.Forms.Label label6;
                                private System.Windows.Forms.Button btn_ocultar;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Id;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_PeliculaAyuda;
                                private System.Windows.Forms.DataGridViewTextBoxColumn n_documentoAyuda;
                                private System.Windows.Forms.Label lbl_fila;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id_dosimetro;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_Cliente;
                                private GridExtension.IntegerGridColumn NDocumento;
                                private GridExtension.IntegerGridColumn N_Pelicula;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
                                private System.Windows.Forms.DataGridViewCheckBoxColumn Controlado;
                                private System.Windows.Forms.DataGridViewCheckBoxColumn condosis;
                                private GridExtension.RealGridColumn valor;
                                private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
                                private System.Windows.Forms.ContextMenuStrip cmsPopup;
                                private System.Windows.Forms.ToolStripMenuItem tsmEliminarPersonal;
                                private System.Windows.Forms.Label lbl_rut_cliente;
                                private System.Windows.Forms.ToolStripDropDownButton btn_reporte;
                                private System.Windows.Forms.ToolStripMenuItem estadoDosimetroToolStripMenuItem;
                                private System.Windows.Forms.ToolStripMenuItem tsmModificarPersonal;
    }
}