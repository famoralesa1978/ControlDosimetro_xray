namespace ControlDosimetro
{
    partial class frmMantenedorUsuario02
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
            this.stsEstado = new System.Windows.Forms.StatusStrip();
            this.tssDescEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.gpxListado = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
            this.gpxFiltrar = new System.Windows.Forms.GroupBox();
            this.cbx_PerfilBusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_id_estado_Buscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_Usuario = new System.Windows.Forms.GroupBox();
            this.lbl_Id_Usuario = new System.Windows.Forms.Label();
            this.lbl_Fecha_Modificacion = new System.Windows.Forms.Label();
            this.lbl_Fecha_agregado = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Contraseña1 = new System.Windows.Forms.TextBox();
            this.lbl_Paterno = new System.Windows.Forms.Label();
            this.cbx_Id_perfil = new System.Windows.Forms.ComboBox();
            this.txt_Maternos = new System.Windows.Forms.TextBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_id_estado = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Id_perfil = new System.Windows.Forms.Label();
            this.lbl_Maternos = new System.Windows.Forms.Label();
            this.cbx_Id_estado = new System.Windows.Forms.ComboBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dB_A2B812_ControlDataSet = new ControlDosimetro.DB_A2B812_ControlDataSet();
            this.entidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tbl_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2B812_ControlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stsEstado
            // 
            this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
            this.stsEstado.Location = new System.Drawing.Point(0, 339);
            this.stsEstado.Name = "stsEstado";
            this.stsEstado.Size = new System.Drawing.Size(712, 22);
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
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "toolStripButton1";
            this.tsbGuardar.ToolTipText = "Guarda la infomación";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(23, 22);
            this.tsbAgregar.Text = "Permite  Agregar un perfil de usuario";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
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
            this.scPrincipal.Panel2.Controls.Add(this.tbl_Usuario);
            this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scPrincipal.Panel2MinSize = 200;
            this.scPrincipal.Size = new System.Drawing.Size(700, 311);
            this.scPrincipal.SplitterDistance = 283;
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
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 3);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(278, 305);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // gpxListado
            // 
            this.gpxListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxListado.Controls.Add(this.dgvGrilla);
            this.gpxListado.Location = new System.Drawing.Point(3, 99);
            this.gpxListado.Name = "gpxListado";
            this.gpxListado.Size = new System.Drawing.Size(270, 201);
            this.gpxListado.TabIndex = 4;
            this.gpxListado.TabStop = false;
            this.gpxListado.Text = "Listado";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrilla.ColumnHeadersHeight = 42;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUsuario,
            this.Nombres});
            this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(264, 182);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellContentClick);
            this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrilla_CellDoubleClick);
            this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
            this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.DgvGrilla_Paint);
            // 
            // ColUsuario
            // 
            this.ColUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColUsuario.DataPropertyName = "Usuario";
            this.ColUsuario.HeaderText = "Usuario";
            this.ColUsuario.Name = "ColUsuario";
            this.ColUsuario.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // cmsMenuContexto
            // 
            this.cmsMenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripSeparator2,
            this.tsmEliminar,
            this.toolStripSeparator3,
            this.tsmAsignarPermiso});
            this.cmsMenuContexto.Name = "cmsMenuContexto";
            this.cmsMenuContexto.Size = new System.Drawing.Size(161, 82);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(160, 22);
            this.tsmActualizar.Text = "Modificar";
            this.tsmActualizar.Click += new System.EventHandler(this.tsmActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(160, 22);
            this.tsmEliminar.Text = "Eliminar";
            this.tsmEliminar.Visible = false;
            this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // tsmAsignarPermiso
            // 
            this.tsmAsignarPermiso.Name = "tsmAsignarPermiso";
            this.tsmAsignarPermiso.Size = new System.Drawing.Size(160, 22);
            this.tsmAsignarPermiso.Text = "Asignar permiso";
            this.tsmAsignarPermiso.Visible = false;
            // 
            // gpxFiltrar
            // 
            this.gpxFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxFiltrar.Controls.Add(this.cbx_PerfilBusqueda);
            this.gpxFiltrar.Controls.Add(this.label6);
            this.gpxFiltrar.Controls.Add(this.btn_Buscar);
            this.gpxFiltrar.Controls.Add(this.cbx_id_estado_Buscar);
            this.gpxFiltrar.Controls.Add(this.label1);
            this.gpxFiltrar.Location = new System.Drawing.Point(3, 3);
            this.gpxFiltrar.Name = "gpxFiltrar";
            this.gpxFiltrar.Size = new System.Drawing.Size(270, 90);
            this.gpxFiltrar.TabIndex = 0;
            this.gpxFiltrar.TabStop = false;
            this.gpxFiltrar.Text = "Filtrar";
            // 
            // cbx_PerfilBusqueda
            // 
            this.cbx_PerfilBusqueda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbx_PerfilBusqueda.FormattingEnabled = true;
            this.cbx_PerfilBusqueda.Location = new System.Drawing.Point(63, 56);
            this.cbx_PerfilBusqueda.Name = "cbx_PerfilBusqueda";
            this.cbx_PerfilBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbx_PerfilBusqueda.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Perfil";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(207, 28);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(46, 40);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cbx_id_estado_Buscar
            // 
            this.cbx_id_estado_Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.cbx_id_estado_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id_estado_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_id_estado_Buscar.FormattingEnabled = true;
            this.cbx_id_estado_Buscar.Location = new System.Drawing.Point(63, 24);
            this.cbx_id_estado_Buscar.Name = "cbx_id_estado_Buscar";
            this.cbx_id_estado_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cbx_id_estado_Buscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado";
            // 
            // tbl_Usuario
            // 
            this.tbl_Usuario.Controls.Add(this.lbl_Id_Usuario);
            this.tbl_Usuario.Controls.Add(this.lbl_Fecha_Modificacion);
            this.tbl_Usuario.Controls.Add(this.lbl_Fecha_agregado);
            this.tbl_Usuario.Controls.Add(this.txt_Contraseña);
            this.tbl_Usuario.Controls.Add(this.txt_Contraseña1);
            this.tbl_Usuario.Controls.Add(this.lbl_Paterno);
            this.tbl_Usuario.Controls.Add(this.cbx_Id_perfil);
            this.tbl_Usuario.Controls.Add(this.txt_Maternos);
            this.tbl_Usuario.Controls.Add(this.txt_paterno);
            this.tbl_Usuario.Controls.Add(this.txt_Nombres);
            this.tbl_Usuario.Controls.Add(this.lbl_id_estado);
            this.tbl_Usuario.Controls.Add(this.lbl_Contraseña);
            this.tbl_Usuario.Controls.Add(this.lbl_Id_perfil);
            this.tbl_Usuario.Controls.Add(this.lbl_Maternos);
            this.tbl_Usuario.Controls.Add(this.cbx_Id_estado);
            this.tbl_Usuario.Controls.Add(this.lbl_Nombres);
            this.tbl_Usuario.Controls.Add(this.txt_rut);
            this.tbl_Usuario.Controls.Add(this.lbl_rut);
            this.tbl_Usuario.Controls.Add(this.txt_Usuario);
            this.tbl_Usuario.Controls.Add(this.lbl_Usuario);
            this.tbl_Usuario.Controls.Add(this.btn_Minimizar);
            this.tbl_Usuario.Controls.Add(this.btn_Limpiar);
            this.tbl_Usuario.Controls.Add(this.btn_Guardar);
            this.tbl_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Usuario.Location = new System.Drawing.Point(0, 0);
            this.tbl_Usuario.Name = "tbl_Usuario";
            this.tbl_Usuario.Size = new System.Drawing.Size(413, 311);
            this.tbl_Usuario.TabIndex = 6;
            this.tbl_Usuario.TabStop = false;
            this.tbl_Usuario.Text = "Datos";
            this.tbl_Usuario.Enter += new System.EventHandler(this.glo_TipoDocumentos_Enter);
            // 
            // lbl_Id_Usuario
            // 
            this.lbl_Id_Usuario.AutoSize = true;
            this.lbl_Id_Usuario.Location = new System.Drawing.Point(353, 23);
            this.lbl_Id_Usuario.Name = "lbl_Id_Usuario";
            this.lbl_Id_Usuario.Size = new System.Drawing.Size(52, 13);
            this.lbl_Id_Usuario.TabIndex = 35;
            this.lbl_Id_Usuario.Text = "N usuario";
            // 
            // lbl_Fecha_Modificacion
            // 
            this.lbl_Fecha_Modificacion.AutoSize = true;
            this.lbl_Fecha_Modificacion.Location = new System.Drawing.Point(356, 104);
            this.lbl_Fecha_Modificacion.Name = "lbl_Fecha_Modificacion";
            this.lbl_Fecha_Modificacion.Size = new System.Drawing.Size(41, 13);
            this.lbl_Fecha_Modificacion.TabIndex = 34;
            this.lbl_Fecha_Modificacion.Text = "label12";
            this.lbl_Fecha_Modificacion.Visible = false;
            // 
            // lbl_Fecha_agregado
            // 
            this.lbl_Fecha_agregado.AutoSize = true;
            this.lbl_Fecha_agregado.Location = new System.Drawing.Point(355, 138);
            this.lbl_Fecha_agregado.Name = "lbl_Fecha_agregado";
            this.lbl_Fecha_agregado.Size = new System.Drawing.Size(41, 13);
            this.lbl_Fecha_agregado.TabIndex = 33;
            this.lbl_Fecha_agregado.Text = "label11";
            this.lbl_Fecha_agregado.Visible = false;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(356, 185);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(54, 20);
            this.txt_Contraseña.TabIndex = 32;
            this.txt_Contraseña.Visible = false;
            // 
            // txt_Contraseña1
            // 
            this.txt_Contraseña1.Location = new System.Drawing.Point(153, 186);
            this.txt_Contraseña1.Name = "txt_Contraseña1";
            this.txt_Contraseña1.PasswordChar = '*';
            this.txt_Contraseña1.Size = new System.Drawing.Size(197, 20);
            this.txt_Contraseña1.TabIndex = 31;
            // 
            // lbl_Paterno
            // 
            this.lbl_Paterno.AutoSize = true;
            this.lbl_Paterno.Location = new System.Drawing.Point(12, 107);
            this.lbl_Paterno.Name = "lbl_Paterno";
            this.lbl_Paterno.Size = new System.Drawing.Size(84, 13);
            this.lbl_Paterno.TabIndex = 30;
            this.lbl_Paterno.Text = "Apellido Paterno";
            // 
            // cbx_Id_perfil
            // 
            this.cbx_Id_perfil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbx_Id_perfil.FormattingEnabled = true;
            this.cbx_Id_perfil.Location = new System.Drawing.Point(152, 158);
            this.cbx_Id_perfil.Name = "cbx_Id_perfil";
            this.cbx_Id_perfil.Size = new System.Drawing.Size(197, 21);
            this.cbx_Id_perfil.TabIndex = 29;
            // 
            // txt_Maternos
            // 
            this.txt_Maternos.Location = new System.Drawing.Point(152, 131);
            this.txt_Maternos.Name = "txt_Maternos";
            this.txt_Maternos.Size = new System.Drawing.Size(197, 20);
            this.txt_Maternos.TabIndex = 28;
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(152, 104);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(197, 20);
            this.txt_paterno.TabIndex = 27;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(152, 77);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(197, 20);
            this.txt_Nombres.TabIndex = 26;
            // 
            // lbl_id_estado
            // 
            this.lbl_id_estado.AutoSize = true;
            this.lbl_id_estado.Location = new System.Drawing.Point(12, 215);
            this.lbl_id_estado.Name = "lbl_id_estado";
            this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_id_estado.TabIndex = 25;
            this.lbl_id_estado.Text = "Estado";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(12, 188);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 24;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // lbl_Id_perfil
            // 
            this.lbl_Id_perfil.AutoSize = true;
            this.lbl_Id_perfil.Location = new System.Drawing.Point(12, 161);
            this.lbl_Id_perfil.Name = "lbl_Id_perfil";
            this.lbl_Id_perfil.Size = new System.Drawing.Size(30, 13);
            this.lbl_Id_perfil.TabIndex = 23;
            this.lbl_Id_perfil.Text = "Perfil";
            // 
            // lbl_Maternos
            // 
            this.lbl_Maternos.AutoSize = true;
            this.lbl_Maternos.Location = new System.Drawing.Point(12, 134);
            this.lbl_Maternos.Name = "lbl_Maternos";
            this.lbl_Maternos.Size = new System.Drawing.Size(86, 13);
            this.lbl_Maternos.TabIndex = 22;
            this.lbl_Maternos.Text = "Apellido Materno";
            // 
            // cbx_Id_estado
            // 
            this.cbx_Id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Id_estado.FormattingEnabled = true;
            this.cbx_Id_estado.Location = new System.Drawing.Point(152, 213);
            this.cbx_Id_estado.Name = "cbx_Id_estado";
            this.cbx_Id_estado.Size = new System.Drawing.Size(197, 21);
            this.cbx_Id_estado.TabIndex = 21;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(12, 80);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres.TabIndex = 20;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(152, 50);
            this.txt_rut.MaxLength = 10;
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(197, 20);
            this.txt_rut.TabIndex = 19;
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(12, 53);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(140, 13);
            this.lbl_rut.TabIndex = 18;
            this.lbl_rut.Text = "RUT ( formato 12345678-9 )";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(152, 23);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(197, 20);
            this.txt_Usuario.TabIndex = 17;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(12, 26);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 16;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Image = global::ControlDosimetro.Properties.Resources.minimizar;
            this.btn_Minimizar.Location = new System.Drawing.Point(366, 0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(38, 17);
            this.btn_Minimizar.TabIndex = 13;
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(264, 261);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(85, 40);
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(152, 261);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Grabar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dB_A2B812_ControlDataSet
            // 
            this.dB_A2B812_ControlDataSet.DataSetName = "DB_A2B812_ControlDataSet";
            this.dB_A2B812_ControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entidadesBindingSource
            // 
            this.entidadesBindingSource.DataMember = "Entidades";
            this.entidadesBindingSource.DataSource = this.dB_A2B812_ControlDataSet;
            // 
            // frmMantenedorUsuario02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 361);
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsEstado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(645, 300);
            this.Name = "frmMantenedorUsuario02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenedor UsuarioNuevoo";
            this.Load += new System.EventHandler(this.frmMantenedorUsuario02_Load);
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
            this.tbl_Usuario.ResumeLayout(false);
            this.tbl_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2B812_ControlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.GroupBox gpxFiltrar;
        private System.Windows.Forms.ComboBox cbx_id_estado_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox gpxListado;
        private System.Windows.Forms.GroupBox tbl_Usuario;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContexto;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignarPermiso;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.ComboBox cbx_Id_estado;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.Label lbl_rut;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.ComboBox cbx_PerfilBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Maternos;
        private System.Windows.Forms.Label lbl_id_estado;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Id_perfil;
        private System.Windows.Forms.TextBox txt_Maternos;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.ComboBox cbx_Id_perfil;
        private System.Windows.Forms.Label lbl_Paterno;
        private System.Windows.Forms.TextBox txt_Contraseña1;
        private DB_A2B812_ControlDataSet dB_A2B812_ControlDataSet;
        private System.Windows.Forms.BindingSource entidadesBindingSource;
        private System.Windows.Forms.Label lbl_Fecha_Modificacion;
        private System.Windows.Forms.Label lbl_Fecha_agregado;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
    }
}