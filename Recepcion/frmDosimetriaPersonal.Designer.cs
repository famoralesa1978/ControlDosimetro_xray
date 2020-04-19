namespace ControlDosimetro
{
    partial class frmDosimetriaPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_id_cliente = new System.Windows.Forms.TextBox();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.btn_filtro = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.grp_Ingreso = new System.Windows.Forms.GroupBox();
            this.cbx_Sucursal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGrabarMod = new System.Windows.Forms.Button();
            this.txt_NDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_NDocumento = new System.Windows.Forms.ComboBox();
            this.txt_Servicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_Fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_anno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl_Progreso = new System.Windows.Forms.GroupBox();
            this.pgb_Barra = new System.Windows.Forms.ProgressBar();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estadodosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Pelicula = new GridExtension.IntegerGridColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.sistiamc_controlDataSet111 = new ControlDosimetro.sistiamc_controlDataSet11();
            this.pctAgregarSucursal = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grp_Ingreso.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_Progreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.cmsPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgregarSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_id_cliente);
            this.groupBox1.Controls.Add(this.lbl_rut);
            this.groupBox1.Controls.Add(this.btn_filtro);
            this.groupBox1.Controls.Add(this.btn_cargar);
            this.groupBox1.Controls.Add(this.cbx_id_periodo);
            this.groupBox1.Controls.Add(this.lbl_nombreCliente);
            this.groupBox1.Controls.Add(this.grp_Ingreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_anno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dato Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Rut";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Location = new System.Drawing.Point(87, 16);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
            this.lbl_id_cliente.TabIndex = 51;
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(84, 43);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(35, 13);
            this.lbl_rut.TabIndex = 50;
            this.lbl_rut.Text = "label1";
            // 
            // btn_filtro
            // 
            this.btn_filtro.Location = new System.Drawing.Point(307, 93);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(95, 23);
            this.btn_filtro.TabIndex = 44;
            this.btn_filtro.Text = "Limpiar filtro";
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(226, 93);
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
            this.cbx_id_periodo.Location = new System.Drawing.Point(82, 92);
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
            // grp_Ingreso
            // 
            this.grp_Ingreso.Controls.Add(this.pctAgregarSucursal);
            this.grp_Ingreso.Controls.Add(this.cbx_Sucursal);
            this.grp_Ingreso.Controls.Add(this.label10);
            this.grp_Ingreso.Controls.Add(this.btnGrabarMod);
            this.grp_Ingreso.Controls.Add(this.txt_NDocumento);
            this.grp_Ingreso.Controls.Add(this.label6);
            this.grp_Ingreso.Controls.Add(this.txt_Observacion);
            this.grp_Ingreso.Controls.Add(this.label9);
            this.grp_Ingreso.Controls.Add(this.cbx_NDocumento);
            this.grp_Ingreso.Controls.Add(this.txt_Servicio);
            this.grp_Ingreso.Controls.Add(this.label4);
            this.grp_Ingreso.Controls.Add(this.label8);
            this.grp_Ingreso.Controls.Add(this.dtp_Fecha_inicio);
            this.grp_Ingreso.Controls.Add(this.btn_Agregar);
            this.grp_Ingreso.Controls.Add(this.label5);
            this.grp_Ingreso.Location = new System.Drawing.Point(3, 122);
            this.grp_Ingreso.Name = "grp_Ingreso";
            this.grp_Ingreso.Size = new System.Drawing.Size(452, 159);
            this.grp_Ingreso.TabIndex = 38;
            this.grp_Ingreso.TabStop = false;
            this.grp_Ingreso.Text = "Ingreso Pelicula";
            // 
            // cbx_Sucursal
            // 
            this.cbx_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Sucursal.FormattingEnabled = true;
            this.cbx_Sucursal.Location = new System.Drawing.Point(109, 94);
            this.cbx_Sucursal.Name = "cbx_Sucursal";
            this.cbx_Sucursal.Size = new System.Drawing.Size(310, 21);
            this.cbx_Sucursal.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sucursal";
            // 
            // btnGrabarMod
            // 
            this.btnGrabarMod.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGrabarMod.Location = new System.Drawing.Point(395, 11);
            this.btnGrabarMod.Name = "btnGrabarMod";
            this.btnGrabarMod.Size = new System.Drawing.Size(35, 23);
            this.btnGrabarMod.TabIndex = 22;
            this.btnGrabarMod.Text = "Ok";
            this.btnGrabarMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabarMod.UseVisualStyleBackColor = true;
            this.btnGrabarMod.Click += new System.EventHandler(this.btnGrabarMod_Click);
            // 
            // txt_NDocumento
            // 
            this.txt_NDocumento.Location = new System.Drawing.Point(304, 13);
            this.txt_NDocumento.MaxLength = 10;
            this.txt_NDocumento.Name = "txt_NDocumento";
            this.txt_NDocumento.Size = new System.Drawing.Size(85, 20);
            this.txt_NDocumento.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cambiar por";
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(109, 121);
            this.txt_Observacion.MaxLength = 200;
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(233, 20);
            this.txt_Observacion.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Observación";
            // 
            // cbx_NDocumento
            // 
            this.cbx_NDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NDocumento.FormattingEnabled = true;
            this.cbx_NDocumento.Location = new System.Drawing.Point(109, 13);
            this.cbx_NDocumento.Name = "cbx_NDocumento";
            this.cbx_NDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbx_NDocumento.TabIndex = 17;
            this.cbx_NDocumento.SelectedIndexChanged += new System.EventHandler(this.cbx_NDocumento_SelectedIndexChanged);
            // 
            // txt_Servicio
            // 
            this.txt_Servicio.Location = new System.Drawing.Point(109, 43);
            this.txt_Servicio.MaxLength = 100;
            this.txt_Servicio.Name = "txt_Servicio";
            this.txt_Servicio.Size = new System.Drawing.Size(329, 20);
            this.txt_Servicio.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "N° Documento";
            // 
            // dtp_Fecha_inicio
            // 
            this.dtp_Fecha_inicio.CustomFormat = "dd-MMMMMMMMMMM-yyyy";
            this.dtp_Fecha_inicio.Enabled = false;
            this.dtp_Fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha_inicio.Location = new System.Drawing.Point(109, 69);
            this.dtp_Fecha_inicio.Name = "dtp_Fecha_inicio";
            this.dtp_Fecha_inicio.Size = new System.Drawing.Size(132, 20);
            this.dtp_Fecha_inicio.TabIndex = 7;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(344, 119);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(106, 23);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "Grabar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Devolución";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "periodo";
            // 
            // cbx_anno
            // 
            this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_anno.FormattingEnabled = true;
            this.cbx_anno.Location = new System.Drawing.Point(82, 66);
            this.cbx_anno.Name = "cbx_anno";
            this.cbx_anno.Size = new System.Drawing.Size(121, 21);
            this.cbx_anno.TabIndex = 1;
            this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "N°  Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
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
            this.groupBox2.Location = new System.Drawing.Point(5, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 279);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // pnl_Progreso
            // 
            this.pnl_Progreso.Controls.Add(this.pgb_Barra);
            this.pnl_Progreso.Location = new System.Drawing.Point(54, 89);
            this.pnl_Progreso.Name = "pnl_Progreso";
            this.pnl_Progreso.Size = new System.Drawing.Size(338, 118);
            this.pnl_Progreso.TabIndex = 10;
            this.pnl_Progreso.TabStop = false;
            this.pnl_Progreso.Text = "Progreso de Grabado";
            // 
            // pgb_Barra
            // 
            this.pgb_Barra.Location = new System.Drawing.Point(21, 43);
            this.pgb_Barra.Name = "pgb_Barra";
            this.pgb_Barra.Size = new System.Drawing.Size(311, 23);
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
            this.id,
            this.id_estadodosimetro,
            this.N_Pelicula,
            this.Descripcion,
            this.N_documento});
            this.grdDatos.ContextMenuStrip = this.cmsPopup;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 16);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(459, 260);
            this.grdDatos.TabIndex = 8;
            this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
            this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
            this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 40;
            // 
            // id_estadodosimetro
            // 
            this.id_estadodosimetro.DataPropertyName = "id_estadodosimetro";
            this.id_estadodosimetro.HeaderText = "id_estadodosimetro";
            this.id_estadodosimetro.Name = "id_estadodosimetro";
            this.id_estadodosimetro.Visible = false;
            this.id_estadodosimetro.Width = 123;
            // 
            // N_Pelicula
            // 
            this.N_Pelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.N_Pelicula.DataPropertyName = "n_dosimetro";
            this.N_Pelicula.HeaderText = "Nº Pelicula";
            this.N_Pelicula.Name = "N_Pelicula";
            this.N_Pelicula.ReadOnly = true;
            this.N_Pelicula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.N_Pelicula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.N_Pelicula.Width = 84;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // N_documento
            // 
            this.N_documento.DataPropertyName = "N_documento";
            this.N_documento.HeaderText = "N° Documento";
            this.N_documento.Name = "N_documento";
            this.N_documento.ReadOnly = true;
            this.N_documento.Width = 102;
            // 
            // cmsPopup
            // 
            this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminar});
            this.cmsPopup.Name = "contextMenuStrip1";
            this.cmsPopup.Size = new System.Drawing.Size(118, 26);
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(117, 22);
            this.tsmEliminar.Text = "Eliminar";
            this.tsmEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(470, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
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
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 97;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(35, 600);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(203, 23);
            this.btn_Imprimir.TabIndex = 7;
            this.btn_Imprimir.Text = "Imprimir Documento Dosimetria Personal";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cerrar.Location = new System.Drawing.Point(371, 600);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // sistiamc_controlDataSet111
            // 
            this.sistiamc_controlDataSet111.DataSetName = "sistiamc_controlDataSet11";
            this.sistiamc_controlDataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pctAgregarSucursal
            // 
            this.pctAgregarSucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctAgregarSucursal.Image = global::ControlDosimetro.Properties.Resources.Agregar;
            this.pctAgregarSucursal.Location = new System.Drawing.Point(422, 91);
            this.pctAgregarSucursal.Name = "pctAgregarSucursal";
            this.pctAgregarSucursal.Size = new System.Drawing.Size(24, 22);
            this.pctAgregarSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAgregarSucursal.TabIndex = 34;
            this.pctAgregarSucursal.TabStop = false;
            this.pctAgregarSucursal.Click += new System.EventHandler(this.pctAgregarSucursal_Click);
            // 
            // frmDosimetriaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 632);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDosimetriaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosimetria Personal";
            this.Load += new System.EventHandler(this.frmIngresoPelicula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_Ingreso.ResumeLayout(false);
            this.grp_Ingreso.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnl_Progreso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.cmsPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgregarSucursal)).EndInit();
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
								private System.Windows.Forms.GroupBox grp_Ingreso;
                                private System.Windows.Forms.Label label5;
								private System.Windows.Forms.Button btn_Agregar;
                                private System.Windows.Forms.Label lbl_nombreCliente;
								private System.Windows.Forms.ComboBox cbx_id_periodo;
                                private System.Windows.Forms.Button btn_cargar;
                                private System.Windows.Forms.Button btn_filtro;
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
                                private System.Windows.Forms.DateTimePicker dtp_Fecha_inicio;
                                private System.Windows.Forms.ContextMenuStrip cmsPopup;
                                private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
                                private System.Windows.Forms.Button btn_Imprimir;
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Label label8;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id_estadodosimetro;
                                private GridExtension.IntegerGridColumn N_Pelicula;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_documento;
                                private System.Windows.Forms.TextBox txt_Servicio;
                                private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.ComboBox cbx_NDocumento;
                                private System.Windows.Forms.TextBox txt_Observacion;
                                private System.Windows.Forms.Label label9;
                                private System.Windows.Forms.Label label6;
                                private System.Windows.Forms.TextBox txt_NDocumento;
                                private System.Windows.Forms.Button btnGrabarMod;
                                private System.Windows.Forms.ComboBox cbx_Sucursal;
                                private System.Windows.Forms.Label label10;
                                private System.Windows.Forms.Label lbl_rut;
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.Label label11;
                                private sistiamc_controlDataSet11 sistiamc_controlDataSet111;
                                private System.Windows.Forms.PictureBox pctAgregarSucursal;
    }
}