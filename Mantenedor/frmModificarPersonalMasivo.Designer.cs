namespace ControlDosimetro
{
	partial class frmModificarPersonalMasivo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarPersonalMasivo));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Filtro = new System.Windows.Forms.Button();
			this.btn_cargarCliente = new System.Windows.Forms.Button();
			this.txt_ref_cliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_RazonSocial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Rut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grp_Grilla = new System.Windows.Forms.GroupBox();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.colMod = new System.Windows.Forms.DataGridViewImageColumn();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColServicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.ColSeccion = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.ColFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.ColFechaTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRevision = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
			this.tsbPersonal = new System.Windows.Forms.ToolStripButton();
			this.grpPersonal = new System.Windows.Forms.GroupBox();
			this.chkDireccion = new System.Windows.Forms.CheckBox();
			this.cbx_Direccin = new System.Windows.Forms.ComboBox();
			this.chkVerificarSinDireccion = new System.Windows.Forms.CheckBox();
			this.rbtInactivo = new System.Windows.Forms.RadioButton();
			this.rbtActivo = new System.Windows.Forms.RadioButton();
			this.rbtAmbos = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_id_seccion = new System.Windows.Forms.Label();
			this.cbx_id_seccion = new System.Windows.Forms.ComboBox();
			this.chk_FecNac = new System.Windows.Forms.CheckBox();
			this.picFiltrarpersonal = new System.Windows.Forms.PictureBox();
			this.txt_NombrePersonal = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_RunPersonal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.chk_AsignarTLD = new System.Windows.Forms.CheckBox();
			this.btnDescargarExcel = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.tsbAsignarSucursal = new System.Windows.Forms.ToolStripButton();
			this.tsbAsignarSeccion = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.grp_Grilla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.grpPersonal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFiltrarpersonal)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Filtro);
			this.groupBox1.Controls.Add(this.btn_cargarCliente);
			this.groupBox1.Controls.Add(this.txt_ref_cliente);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_RazonSocial);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_Rut);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(849, 97);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// btn_Filtro
			// 
			this.btn_Filtro.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
			this.btn_Filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Filtro.Location = new System.Drawing.Point(337, 18);
			this.btn_Filtro.Name = "btn_Filtro";
			this.btn_Filtro.Size = new System.Drawing.Size(122, 39);
			this.btn_Filtro.TabIndex = 35;
			this.btn_Filtro.Text = "Limpiar Filtro";
			this.btn_Filtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Filtro.UseVisualStyleBackColor = true;
			this.btn_Filtro.Click += new System.EventHandler(this.btn_Filtro_Click);
			// 
			// btn_cargarCliente
			// 
			this.btn_cargarCliente.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btn_cargarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cargarCliente.Location = new System.Drawing.Point(220, 17);
			this.btn_cargarCliente.Name = "btn_cargarCliente";
			this.btn_cargarCliente.Size = new System.Drawing.Size(111, 40);
			this.btn_cargarCliente.TabIndex = 3;
			this.btn_cargarCliente.Text = "Cargar";
			this.btn_cargarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cargarCliente.UseVisualStyleBackColor = true;
			this.btn_cargarCliente.Click += new System.EventHandler(this.btn_cargarCliente_Click);
			// 
			// txt_ref_cliente
			// 
			this.txt_ref_cliente.Location = new System.Drawing.Point(95, 17);
			this.txt_ref_cliente.MaxLength = 4;
			this.txt_ref_cliente.Name = "txt_ref_cliente";
			this.txt_ref_cliente.Size = new System.Drawing.Size(100, 20);
			this.txt_ref_cliente.TabIndex = 1;
			this.txt_ref_cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ref_cliente_KeyDown_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// txt_RazonSocial
			// 
			this.txt_RazonSocial.Location = new System.Drawing.Point(95, 69);
			this.txt_RazonSocial.MaxLength = 60;
			this.txt_RazonSocial.Name = "txt_RazonSocial";
			this.txt_RazonSocial.ReadOnly = true;
			this.txt_RazonSocial.Size = new System.Drawing.Size(342, 20);
			this.txt_RazonSocial.TabIndex = 3;
			this.txt_RazonSocial.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Razon Social";
			// 
			// txt_Rut
			// 
			this.txt_Rut.Location = new System.Drawing.Point(95, 44);
			this.txt_Rut.MaxLength = 10;
			this.txt_Rut.Name = "txt_Rut";
			this.txt_Rut.ReadOnly = true;
			this.txt_Rut.Size = new System.Drawing.Size(100, 20);
			this.txt_Rut.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rut";
			// 
			// grp_Grilla
			// 
			this.grp_Grilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grp_Grilla.Controls.Add(this.grdDatos);
			this.grp_Grilla.Enabled = false;
			this.grp_Grilla.Location = new System.Drawing.Point(5, 294);
			this.grp_Grilla.Name = "grp_Grilla";
			this.grp_Grilla.Size = new System.Drawing.Size(1060, 408);
			this.grp_Grilla.TabIndex = 6;
			this.grp_Grilla.TabStop = false;
			this.grp_Grilla.Text = "Listado";
			// 
			// grdDatos
			// 
			this.grdDatos.AllowUserToAddRows = false;
			this.grdDatos.AllowUserToDeleteRows = false;
			this.grdDatos.AllowUserToResizeColumns = false;
			this.grdDatos.AllowUserToResizeRows = false;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMod,
            this.Id_Personal,
            this.Rut,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.ColServicio,
            this.ColSeccion,
            this.ColFechaNac,
            this.colFecha_inicio,
            this.ColEstado,
            this.ColFechaTermino,
            this.colRevision});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.MultiSelect = false;
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(1054, 389);
			this.grdDatos.TabIndex = 5;
			this.grdDatos.VirtualMode = true;
			this.grdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellClick);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			this.grdDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdDatos_DataBindingComplete);
			// 
			// colMod
			// 
			this.colMod.HeaderText = "";
			this.colMod.Image = global::ControlDosimetro.Properties.Resources.Modify_24;
			this.colMod.Name = "colMod";
			this.colMod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colMod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colMod.ToolTipText = "Modificar";
			this.colMod.Width = 40;
			// 
			// Id_Personal
			// 
			this.Id_Personal.DataPropertyName = "Id_Personal";
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
			// colFecha_inicio
			// 
			this.colFecha_inicio.DataPropertyName = "Fecha_inicio";
			this.colFecha_inicio.HeaderText = "F. inicio control";
			this.colFecha_inicio.MaxInputLength = 10;
			this.colFecha_inicio.Name = "colFecha_inicio";
			this.colFecha_inicio.ReadOnly = true;
			this.colFecha_inicio.ToolTipText = "Fecha inicio control";
			// 
			// ColEstado
			// 
			this.ColEstado.DataPropertyName = "Id_estado";
			this.ColEstado.DisplayStyleForCurrentCellOnly = true;
			this.ColEstado.HeaderText = "Estado";
			this.ColEstado.Name = "ColEstado";
			this.ColEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColEstado.Width = 80;
			// 
			// ColFechaTermino
			// 
			this.ColFechaTermino.DataPropertyName = "fecha_termino";
			this.ColFechaTermino.HeaderText = "F. Term Control";
			this.ColFechaTermino.MaxInputLength = 10;
			this.ColFechaTermino.Name = "ColFechaTermino";
			this.ColFechaTermino.ToolTipText = "Fecha termino control";
			// 
			// colRevision
			// 
			this.colRevision.DataPropertyName = "Revision";
			this.colRevision.FalseValue = "0";
			this.colRevision.HeaderText = "Rev";
			this.colRevision.Name = "colRevision";
			this.colRevision.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colRevision.TrueValue = "1";
			this.colRevision.Width = 40;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbPersonal,
            this.tsbAsignarSucursal,
            this.tsbAsignarSeccion});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1077, 39);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbGuardar
			// 
			this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbGuardar.Name = "tsbGuardar";
			this.tsbGuardar.Size = new System.Drawing.Size(36, 36);
			this.tsbGuardar.ToolTipText = "Grabar";
			this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
			// 
			// tsbPersonal
			// 
			this.tsbPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPersonal.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.tsbPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPersonal.Name = "tsbPersonal";
			this.tsbPersonal.Size = new System.Drawing.Size(36, 36);
			this.tsbPersonal.Text = "Agregar personal";
			this.tsbPersonal.Click += new System.EventHandler(this.tsbPersonal_Click);
			// 
			// grpPersonal
			// 
			this.grpPersonal.Controls.Add(this.chkDireccion);
			this.grpPersonal.Controls.Add(this.cbx_Direccin);
			this.grpPersonal.Controls.Add(this.chkVerificarSinDireccion);
			this.grpPersonal.Controls.Add(this.rbtInactivo);
			this.grpPersonal.Controls.Add(this.rbtActivo);
			this.grpPersonal.Controls.Add(this.rbtAmbos);
			this.grpPersonal.Controls.Add(this.label6);
			this.grpPersonal.Controls.Add(this.lbl_id_seccion);
			this.grpPersonal.Controls.Add(this.cbx_id_seccion);
			this.grpPersonal.Controls.Add(this.chk_FecNac);
			this.grpPersonal.Controls.Add(this.picFiltrarpersonal);
			this.grpPersonal.Controls.Add(this.txt_NombrePersonal);
			this.grpPersonal.Controls.Add(this.label5);
			this.grpPersonal.Controls.Add(this.txt_RunPersonal);
			this.grpPersonal.Controls.Add(this.label4);
			this.grpPersonal.Enabled = false;
			this.grpPersonal.Location = new System.Drawing.Point(8, 145);
			this.grpPersonal.Name = "grpPersonal";
			this.grpPersonal.Size = new System.Drawing.Size(848, 111);
			this.grpPersonal.TabIndex = 8;
			this.grpPersonal.TabStop = false;
			this.grpPersonal.Text = "Filtrar";
			// 
			// chkDireccion
			// 
			this.chkDireccion.AutoSize = true;
			this.chkDireccion.Location = new System.Drawing.Point(308, 71);
			this.chkDireccion.Name = "chkDireccion";
			this.chkDireccion.Size = new System.Drawing.Size(71, 17);
			this.chkDireccion.TabIndex = 25;
			this.chkDireccion.Text = "Dirección";
			this.chkDireccion.UseVisualStyleBackColor = true;
			// 
			// cbx_Direccin
			// 
			this.cbx_Direccin.DisplayMember = "Descripcion";
			this.cbx_Direccin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Direccin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Direccin.FormattingEnabled = true;
			this.cbx_Direccin.Location = new System.Drawing.Point(382, 69);
			this.cbx_Direccin.Name = "cbx_Direccin";
			this.cbx_Direccin.Size = new System.Drawing.Size(397, 21);
			this.cbx_Direccin.TabIndex = 24;
			this.cbx_Direccin.ValueMember = "Id_sucursal";
			// 
			// chkVerificarSinDireccion
			// 
			this.chkVerificarSinDireccion.AutoSize = true;
			this.chkVerificarSinDireccion.Location = new System.Drawing.Point(518, 15);
			this.chkVerificarSinDireccion.Name = "chkVerificarSinDireccion";
			this.chkVerificarSinDireccion.Size = new System.Drawing.Size(272, 17);
			this.chkVerificarSinDireccion.TabIndex = 9;
			this.chkVerificarSinDireccion.Text = "Verificar el personal que no tiene dirección asignada";
			this.chkVerificarSinDireccion.UseVisualStyleBackColor = true;
			// 
			// rbtInactivo
			// 
			this.rbtInactivo.AutoSize = true;
			this.rbtInactivo.Location = new System.Drawing.Point(191, 42);
			this.rbtInactivo.Name = "rbtInactivo";
			this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
			this.rbtInactivo.TabIndex = 23;
			this.rbtInactivo.TabStop = true;
			this.rbtInactivo.Text = "Inactivo";
			this.rbtInactivo.UseVisualStyleBackColor = true;
			// 
			// rbtActivo
			// 
			this.rbtActivo.AutoSize = true;
			this.rbtActivo.Location = new System.Drawing.Point(130, 42);
			this.rbtActivo.Name = "rbtActivo";
			this.rbtActivo.Size = new System.Drawing.Size(55, 17);
			this.rbtActivo.TabIndex = 22;
			this.rbtActivo.Text = "Activo";
			this.rbtActivo.UseVisualStyleBackColor = true;
			// 
			// rbtAmbos
			// 
			this.rbtAmbos.AutoSize = true;
			this.rbtAmbos.Checked = true;
			this.rbtAmbos.Location = new System.Drawing.Point(66, 42);
			this.rbtAmbos.Name = "rbtAmbos";
			this.rbtAmbos.Size = new System.Drawing.Size(57, 17);
			this.rbtAmbos.TabIndex = 21;
			this.rbtAmbos.TabStop = true;
			this.rbtAmbos.Text = "Ambos";
			this.rbtAmbos.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Estado";
			// 
			// lbl_id_seccion
			// 
			this.lbl_id_seccion.AutoSize = true;
			this.lbl_id_seccion.Location = new System.Drawing.Point(12, 72);
			this.lbl_id_seccion.Name = "lbl_id_seccion";
			this.lbl_id_seccion.Size = new System.Drawing.Size(46, 13);
			this.lbl_id_seccion.TabIndex = 19;
			this.lbl_id_seccion.Text = "Sección";
			// 
			// cbx_id_seccion
			// 
			this.cbx_id_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_seccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_seccion.FormattingEnabled = true;
			this.cbx_id_seccion.Location = new System.Drawing.Point(66, 69);
			this.cbx_id_seccion.Name = "cbx_id_seccion";
			this.cbx_id_seccion.Size = new System.Drawing.Size(236, 21);
			this.cbx_id_seccion.TabIndex = 18;
			// 
			// chk_FecNac
			// 
			this.chk_FecNac.AutoSize = true;
			this.chk_FecNac.Location = new System.Drawing.Point(518, 38);
			this.chk_FecNac.Name = "chk_FecNac";
			this.chk_FecNac.Size = new System.Drawing.Size(153, 17);
			this.chk_FecNac.TabIndex = 8;
			this.chk_FecNac.Text = "Por  Fec. Nac 01/01/1900";
			this.chk_FecNac.UseVisualStyleBackColor = true;
			// 
			// picFiltrarpersonal
			// 
			this.picFiltrarpersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFiltrarpersonal.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.picFiltrarpersonal.Location = new System.Drawing.Point(797, 38);
			this.picFiltrarpersonal.Name = "picFiltrarpersonal";
			this.picFiltrarpersonal.Size = new System.Drawing.Size(36, 36);
			this.picFiltrarpersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picFiltrarpersonal.TabIndex = 7;
			this.picFiltrarpersonal.TabStop = false;
			this.picFiltrarpersonal.Click += new System.EventHandler(this.picFiltrarpersonal_Click);
			// 
			// txt_NombrePersonal
			// 
			this.txt_NombrePersonal.Location = new System.Drawing.Point(293, 15);
			this.txt_NombrePersonal.MaxLength = 50;
			this.txt_NombrePersonal.Name = "txt_NombrePersonal";
			this.txt_NombrePersonal.Size = new System.Drawing.Size(219, 20);
			this.txt_NombrePersonal.TabIndex = 6;
			this.txt_NombrePersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NombrePersonal_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(171, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nombre del personal";
			// 
			// txt_RunPersonal
			// 
			this.txt_RunPersonal.Location = new System.Drawing.Point(57, 14);
			this.txt_RunPersonal.MaxLength = 10;
			this.txt_RunPersonal.Name = "txt_RunPersonal";
			this.txt_RunPersonal.Size = new System.Drawing.Size(100, 20);
			this.txt_RunPersonal.TabIndex = 4;
			this.txt_RunPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_RunPersonal_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Rut";
			// 
			// chk_AsignarTLD
			// 
			this.chk_AsignarTLD.AutoSize = true;
			this.chk_AsignarTLD.Enabled = false;
			this.chk_AsignarTLD.Location = new System.Drawing.Point(8, 262);
			this.chk_AsignarTLD.Name = "chk_AsignarTLD";
			this.chk_AsignarTLD.Size = new System.Drawing.Size(216, 17);
			this.chk_AsignarTLD.TabIndex = 6;
			this.chk_AsignarTLD.Text = "Asignar a todos al personal servicio TLD";
			this.chk_AsignarTLD.UseVisualStyleBackColor = true;
			this.chk_AsignarTLD.CheckedChanged += new System.EventHandler(this.chk_AsignarTLD_CheckedChanged);
			// 
			// btnDescargarExcel
			// 
			this.btnDescargarExcel.Location = new System.Drawing.Point(898, 262);
			this.btnDescargarExcel.Name = "btnDescargarExcel";
			this.btnDescargarExcel.Size = new System.Drawing.Size(167, 23);
			this.btnDescargarExcel.TabIndex = 36;
			this.btnDescargarExcel.Text = "Descargar a excel los activos";
			this.btnDescargarExcel.UseVisualStyleBackColor = true;
			this.btnDescargarExcel.Click += new System.EventHandler(this.btnDescargarExcel_Click);
			// 
			// tsbAsignarSucursal
			// 
			this.tsbAsignarSucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbAsignarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsignarSucursal.Image")));
			this.tsbAsignarSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAsignarSucursal.Name = "tsbAsignarSucursal";
			this.tsbAsignarSucursal.Size = new System.Drawing.Size(98, 36);
			this.tsbAsignarSucursal.Text = "Asignar Sucursal";
			this.tsbAsignarSucursal.Click += new System.EventHandler(this.tsbAsignarSucursal_Click);
			// 
			// tsbAsignarSeccion
			// 
			this.tsbAsignarSeccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbAsignarSeccion.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsignarSeccion.Image")));
			this.tsbAsignarSeccion.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAsignarSeccion.Name = "tsbAsignarSeccion";
			this.tsbAsignarSeccion.Size = new System.Drawing.Size(95, 36);
			this.tsbAsignarSeccion.Text = "Asignar Sección";
			this.tsbAsignarSeccion.Click += new System.EventHandler(this.tsbAsignarSeccion_Click);
			// 
			// frmModificarPersonalMasivo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 702);
			this.Controls.Add(this.btnDescargarExcel);
			this.Controls.Add(this.chk_AsignarTLD);
			this.Controls.Add(this.grpPersonal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.grp_Grilla);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 461);
			this.Name = "frmModificarPersonalMasivo";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar personal masivo";
			this.Load += new System.EventHandler(this.frmModificarPersonalMasivo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grp_Grilla.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.grpPersonal.ResumeLayout(false);
			this.grpPersonal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFiltrarpersonal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Rut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Grilla;
		  private System.Windows.Forms.DataGridView grdDatos;
		  private System.Windows.Forms.ToolStrip toolStrip1;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.TextBox txt_ref_cliente;
								private System.Windows.Forms.Button btn_cargarCliente;
                                private System.Windows.Forms.Button btn_Filtro;
		private System.Windows.Forms.ToolStripButton tsbGuardar;
		private System.Windows.Forms.GroupBox grpPersonal;
		private System.Windows.Forms.PictureBox picFiltrarpersonal;
		private System.Windows.Forms.TextBox txt_NombrePersonal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_RunPersonal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chk_FecNac;
		private System.Windows.Forms.CheckBox chk_AsignarTLD;
		private System.Windows.Forms.Label lbl_id_seccion;
		private System.Windows.Forms.ComboBox cbx_id_seccion;
		private System.Windows.Forms.ToolStripButton tsbPersonal;
		private System.Windows.Forms.RadioButton rbtInactivo;
		private System.Windows.Forms.RadioButton rbtActivo;
		private System.Windows.Forms.RadioButton rbtAmbos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkVerificarSinDireccion;
		private System.Windows.Forms.ComboBox cbx_Direccin;
		private System.Windows.Forms.CheckBox chkDireccion;
		private System.Windows.Forms.DataGridViewImageColumn colMod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColSeccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNac;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_inicio;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColEstado;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaTermino;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colRevision;
		private System.Windows.Forms.Button btnDescargarExcel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ToolStripButton tsbAsignarSucursal;
		private System.Windows.Forms.ToolStripButton tsbAsignarSeccion;
	}
}