﻿namespace ControlDosimetro
{
    partial class frmConsultaFilmico
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
			this.btnCargarCliente = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColRerencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.id_dosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_estadodosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColMedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cbx_Sucursal = new System.Windows.Forms.ComboBox();
			this.cbx_id_seccion = new System.Windows.Forms.ComboBox();
			this.lbl_id_seccion = new System.Windows.Forms.Label();
			this.grpFiltro = new System.Windows.Forms.GroupBox();
			this.picFiltrarpersonal = new System.Windows.Forms.PictureBox();
			this.txt_NombrePersonal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_RunPersonal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlDatosPeriodo = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.grpFiltro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFiltrarpersonal)).BeginInit();
			this.pnlDatosPeriodo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCargarCliente);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.lbl_rut_cliente);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(844, 99);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// btnCargarCliente
			// 
			this.btnCargarCliente.Location = new System.Drawing.Point(161, 17);
			this.btnCargarCliente.Name = "btnCargarCliente";
			this.btnCargarCliente.Size = new System.Drawing.Size(75, 23);
			this.btnCargarCliente.TabIndex = 54;
			this.btnCargarCliente.Text = "Cargar";
			this.btnCargarCliente.UseVisualStyleBackColor = true;
			this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 76);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 53;
			this.label11.Text = "Rut";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(88, 19);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 50;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(18, 50);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 51;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(242, 17);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(90, 75);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut_cliente.TabIndex = 46;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(223, 28);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 3;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DisplayMember = "Trimestre";
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(78, 28);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 43;
			this.cbx_id_periodo.ValueMember = "Id_Periodo";
			this.cbx_id_periodo.SelectedIndexChanged += new System.EventHandler(this.cbx_id_periodo_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DisplayMember = "anno";
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(78, 3);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			this.cbx_anno.ValueMember = "anno";
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.Cbx_anno_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 6);
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
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(5, 295);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1079, 329);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
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
            this.Id_Personal,
            this.N_pelicula,
            this.ColRerencia,
            this.id_dosimetro,
            this.ColEstado,
            this.N_Cliente,
            this.NDocumento,
            this.Rut,
            this.ColServicio,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.id_sucursal,
            this.id_estadodosimetro,
            this.ColMedicion});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.ReadOnly = true;
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(1073, 310);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			this.grdDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
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
			// ColRerencia
			// 
			this.ColRerencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ColRerencia.DataPropertyName = "Referencia";
			this.ColRerencia.HeaderText = "Ref.";
			this.ColRerencia.Name = "ColRerencia";
			this.ColRerencia.ReadOnly = true;
			this.ColRerencia.ToolTipText = "Referencia";
			this.ColRerencia.Width = 50;
			// 
			// id_dosimetro
			// 
			this.id_dosimetro.DataPropertyName = "id_dosimetro";
			this.id_dosimetro.HeaderText = "Id_dosimetro";
			this.id_dosimetro.Name = "id_dosimetro";
			this.id_dosimetro.ReadOnly = true;
			this.id_dosimetro.Visible = false;
			this.id_dosimetro.Width = 92;
			// 
			// ColEstado
			// 
			this.ColEstado.DataPropertyName = "Estado";
			this.ColEstado.HeaderText = "Estado";
			this.ColEstado.Name = "ColEstado";
			this.ColEstado.ReadOnly = true;
			this.ColEstado.Width = 65;
			// 
			// N_Cliente
			// 
			this.N_Cliente.DataPropertyName = "Id_Cliente";
			this.N_Cliente.HeaderText = "N° Cliente";
			this.N_Cliente.Name = "N_Cliente";
			this.N_Cliente.ReadOnly = true;
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
			this.id_sucursal.ReadOnly = true;
			this.id_sucursal.Visible = false;
			this.id_sucursal.Width = 85;
			// 
			// id_estadodosimetro
			// 
			this.id_estadodosimetro.DataPropertyName = "id_estadodosimetro";
			this.id_estadodosimetro.HeaderText = "id_estadodosimetro";
			this.id_estadodosimetro.Name = "id_estadodosimetro";
			this.id_estadodosimetro.ReadOnly = true;
			this.id_estadodosimetro.Visible = false;
			this.id_estadodosimetro.Width = 123;
			// 
			// ColMedicion
			// 
			this.ColMedicion.DataPropertyName = "Medicion";
			this.ColMedicion.HeaderText = "Dosis";
			this.ColMedicion.Name = "ColMedicion";
			this.ColMedicion.ReadOnly = true;
			this.ColMedicion.Width = 58;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(472, 630);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Sucursal";
			// 
			// cbx_Sucursal
			// 
			this.cbx_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Sucursal.FormattingEnabled = true;
			this.cbx_Sucursal.Location = new System.Drawing.Point(79, 55);
			this.cbx_Sucursal.Name = "cbx_Sucursal";
			this.cbx_Sucursal.Size = new System.Drawing.Size(526, 21);
			this.cbx_Sucursal.TabIndex = 11;
			this.cbx_Sucursal.SelectedIndexChanged += new System.EventHandler(this.cbx_Sucursal_SelectedIndexChanged);
			// 
			// cbx_id_seccion
			// 
			this.cbx_id_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_seccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_seccion.FormattingEnabled = true;
			this.cbx_id_seccion.Location = new System.Drawing.Point(79, 82);
			this.cbx_id_seccion.Name = "cbx_id_seccion";
			this.cbx_id_seccion.Size = new System.Drawing.Size(236, 21);
			this.cbx_id_seccion.TabIndex = 14;
			this.cbx_id_seccion.SelectedIndexChanged += new System.EventHandler(this.cbx_id_seccion_SelectedIndexChanged);
			// 
			// lbl_id_seccion
			// 
			this.lbl_id_seccion.AutoSize = true;
			this.lbl_id_seccion.Location = new System.Drawing.Point(13, 85);
			this.lbl_id_seccion.Name = "lbl_id_seccion";
			this.lbl_id_seccion.Size = new System.Drawing.Size(46, 13);
			this.lbl_id_seccion.TabIndex = 15;
			this.lbl_id_seccion.Text = "Sección";
			// 
			// grpFiltro
			// 
			this.grpFiltro.Controls.Add(this.picFiltrarpersonal);
			this.grpFiltro.Controls.Add(this.txt_NombrePersonal);
			this.grpFiltro.Controls.Add(this.label6);
			this.grpFiltro.Controls.Add(this.txt_RunPersonal);
			this.grpFiltro.Controls.Add(this.label7);
			this.grpFiltro.Location = new System.Drawing.Point(8, 240);
			this.grpFiltro.Name = "grpFiltro";
			this.grpFiltro.Size = new System.Drawing.Size(705, 51);
			this.grpFiltro.TabIndex = 17;
			this.grpFiltro.TabStop = false;
			this.grpFiltro.Text = "Filtrar personal";
			// 
			// picFiltrarpersonal
			// 
			this.picFiltrarpersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFiltrarpersonal.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.picFiltrarpersonal.Location = new System.Drawing.Point(545, 13);
			this.picFiltrarpersonal.Name = "picFiltrarpersonal";
			this.picFiltrarpersonal.Size = new System.Drawing.Size(36, 36);
			this.picFiltrarpersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picFiltrarpersonal.TabIndex = 7;
			this.picFiltrarpersonal.TabStop = false;
			this.picFiltrarpersonal.Click += new System.EventHandler(this.picFiltrarpersonal_Click);
			// 
			// txt_NombrePersonal
			// 
			this.txt_NombrePersonal.Location = new System.Drawing.Point(320, 22);
			this.txt_NombrePersonal.MaxLength = 50;
			this.txt_NombrePersonal.Name = "txt_NombrePersonal";
			this.txt_NombrePersonal.Size = new System.Drawing.Size(219, 20);
			this.txt_NombrePersonal.TabIndex = 6;
			this.txt_NombrePersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NombrePersonal_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(198, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Nombre del personal";
			// 
			// txt_RunPersonal
			// 
			this.txt_RunPersonal.Location = new System.Drawing.Point(57, 23);
			this.txt_RunPersonal.MaxLength = 10;
			this.txt_RunPersonal.Name = "txt_RunPersonal";
			this.txt_RunPersonal.Size = new System.Drawing.Size(100, 20);
			this.txt_RunPersonal.TabIndex = 4;
			this.txt_RunPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_RunPersonal_KeyDown);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Rut";
			// 
			// pnlDatosPeriodo
			// 
			this.pnlDatosPeriodo.Controls.Add(this.cbx_anno);
			this.pnlDatosPeriodo.Controls.Add(this.label3);
			this.pnlDatosPeriodo.Controls.Add(this.lbl_id_seccion);
			this.pnlDatosPeriodo.Controls.Add(this.label4);
			this.pnlDatosPeriodo.Controls.Add(this.btn_cargar);
			this.pnlDatosPeriodo.Controls.Add(this.label1);
			this.pnlDatosPeriodo.Controls.Add(this.cbx_id_seccion);
			this.pnlDatosPeriodo.Controls.Add(this.cbx_id_periodo);
			this.pnlDatosPeriodo.Controls.Add(this.cbx_Sucursal);
			this.pnlDatosPeriodo.Location = new System.Drawing.Point(5, 125);
			this.pnlDatosPeriodo.Name = "pnlDatosPeriodo";
			this.pnlDatosPeriodo.Size = new System.Drawing.Size(1067, 118);
			this.pnlDatosPeriodo.TabIndex = 44;
			// 
			// frmConsultaFilmico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 662);
			this.Controls.Add(this.pnlDatosPeriodo);
			this.Controls.Add(this.grpFiltro);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 462);
			this.Name = "frmConsultaFilmico";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta fílmico";
			this.Load += new System.EventHandler(this.frmConsultaFilmico_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.grpFiltro.ResumeLayout(false);
			this.grpFiltro.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFiltrarpersonal)).EndInit();
			this.pnlDatosPeriodo.ResumeLayout(false);
			this.pnlDatosPeriodo.PerformLayout();
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
								private System.Windows.Forms.ComboBox cbx_id_periodo;
								private System.Windows.Forms.Button btn_cargar;
								private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_filtro;
                                private System.Windows.Forms.GroupBox pnl_Progreso;
                                private System.Windows.Forms.ProgressBar pgb_Barra;
                                private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.ComboBox cbx_Sucursal;
                                private System.Windows.Forms.Label lbl_rut_cliente;
                                private System.Windows.Forms.Label label11;
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.Label lbl_nombreCliente;
		private System.Windows.Forms.ComboBox cbx_id_seccion;
		private System.Windows.Forms.Label lbl_id_seccion;
		private System.Windows.Forms.GroupBox grpFiltro;
		private System.Windows.Forms.PictureBox picFiltrarpersonal;
		private System.Windows.Forms.TextBox txt_NombrePersonal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_RunPersonal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_pelicula;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColRerencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_dosimetro;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn NDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_estadodosimetro;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicion;
		private System.Windows.Forms.Button btnCargarCliente;
		private System.Windows.Forms.Panel pnlDatosPeriodo;
	}
}