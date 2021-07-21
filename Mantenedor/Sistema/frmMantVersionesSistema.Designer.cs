namespace ControlDosimetro
{
    partial class frmMantVersionesSistema
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
			this.tsdReporte = new System.Windows.Forms.ToolStripDropDownButton();
			this.scPrincipal = new System.Windows.Forms.SplitContainer();
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.gpxListado = new System.Windows.Forms.GroupBox();
			this.dgvGrilla = new System.Windows.Forms.DataGridView();
			this.GVS_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PK_VSISTEMA = new GridExtension.IntegerGridColumn();
			this.PK_SISTEMA = new GridExtension.IntegerGridColumn();
			this.GVS_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GVS_N_VERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GVS_AMBIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AMBIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
			this.gpxFiltrar = new System.Windows.Forms.GroupBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.cbx_GVS_AMBIENTE_Buscar = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.GES_VERSIONES_SISTEMA = new System.Windows.Forms.GroupBox();
			this.lbl_PK_VSISTEMA = new System.Windows.Forms.Label();
			this.txt_PK_VSISTEMA = new System.Windows.Forms.TextBox();
			this.lbl_PK_SISTEMA = new System.Windows.Forms.Label();
			this.txt_PK_SISTEMA = new System.Windows.Forms.TextBox();
			this.cbx_GVS_AMBIENTE = new System.Windows.Forms.ComboBox();
			this.lbl_GVS_AMBIENTE = new System.Windows.Forms.Label();
			this.txt_GVS_N_VERSION = new System.Windows.Forms.TextBox();
			this.lbl_GVS_N_VERSION = new System.Windows.Forms.Label();
			this.btn_Minimizar = new System.Windows.Forms.Button();
			this.btn_Limpiar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.txt_GVS_NOMBRE = new System.Windows.Forms.TextBox();
			this.lbl_GVS_NOMBRE = new System.Windows.Forms.Label();
			this.txt_GVS_DESCRIPCION = new System.Windows.Forms.TextBox();
			this.lbl_GVS_DESCRIPCION = new System.Windows.Forms.Label();
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
			this.GES_VERSIONES_SISTEMA.SuspendLayout();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 362);
			this.stsEstado.Name = "stsEstado";
			this.stsEstado.Size = new System.Drawing.Size(937, 22);
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
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbAgregar,
            this.tsdReporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(937, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbGuardar
			// 
			this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbGuardar.Name = "tsbGuardar";
			this.tsbGuardar.Size = new System.Drawing.Size(24, 24);
			this.tsbGuardar.Text = "toolStripButton1";
			this.tsbGuardar.ToolTipText = "Guarda la infomación";
			this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// tsbAgregar
			// 
			this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregar.Name = "tsbAgregar";
			this.tsbAgregar.Size = new System.Drawing.Size(24, 24);
			this.tsbAgregar.Text = "Permite  Agregar un perfil de usuario";
			this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
			// 
			// tsdReporte
			// 
			this.tsdReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdReporte.Name = "tsdReporte";
			this.tsdReporte.Size = new System.Drawing.Size(61, 24);
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
			this.scPrincipal.Panel2.Controls.Add(this.GES_VERSIONES_SISTEMA);
			this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel2MinSize = 200;
			this.scPrincipal.Size = new System.Drawing.Size(925, 334);
			this.scPrincipal.SplitterDistance = 546;
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
			this.pnlPrincipal.Size = new System.Drawing.Size(541, 328);
			this.pnlPrincipal.TabIndex = 1;
			// 
			// gpxListado
			// 
			this.gpxListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpxListado.Controls.Add(this.dgvGrilla);
			this.gpxListado.Location = new System.Drawing.Point(3, 71);
			this.gpxListado.Name = "gpxListado";
			this.gpxListado.Size = new System.Drawing.Size(533, 252);
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
            this.GVS_NOMBRE,
            this.PK_VSISTEMA,
            this.PK_SISTEMA,
            this.GVS_DESCRIPCION,
            this.GVS_N_VERSION,
            this.GVS_AMBIENTE,
            this.AMBIENTE});
			this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(527, 233);
			this.dgvGrilla.TabIndex = 0;
			this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
			this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
			this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
			// 
			// GVS_NOMBRE
			// 
			this.GVS_NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.GVS_NOMBRE.DataPropertyName = "GVS_NOMBRE";
			this.GVS_NOMBRE.HeaderText = "Nombre";
			this.GVS_NOMBRE.Name = "GVS_NOMBRE";
			this.GVS_NOMBRE.ReadOnly = true;
			// 
			// PK_VSISTEMA
			// 
			this.PK_VSISTEMA.DataPropertyName = "PK_VSISTEMA";
			this.PK_VSISTEMA.HeaderText = "VSistema";
			this.PK_VSISTEMA.Name = "PK_VSISTEMA";
			this.PK_VSISTEMA.ReadOnly = true;
			this.PK_VSISTEMA.Visible = false;
			// 
			// PK_SISTEMA
			// 
			this.PK_SISTEMA.DataPropertyName = "PK_SISTEMA";
			this.PK_SISTEMA.HeaderText = "IdSistema";
			this.PK_SISTEMA.Name = "PK_SISTEMA";
			this.PK_SISTEMA.ReadOnly = true;
			this.PK_SISTEMA.Visible = false;
			// 
			// GVS_DESCRIPCION
			// 
			this.GVS_DESCRIPCION.DataPropertyName = "GVS_DESCRIPCION";
			this.GVS_DESCRIPCION.HeaderText = "Descripción";
			this.GVS_DESCRIPCION.Name = "GVS_DESCRIPCION";
			this.GVS_DESCRIPCION.ReadOnly = true;
			// 
			// GVS_N_VERSION
			// 
			this.GVS_N_VERSION.DataPropertyName = "GVS_N_VERSION";
			this.GVS_N_VERSION.HeaderText = "N_Versión";
			this.GVS_N_VERSION.Name = "GVS_N_VERSION";
			this.GVS_N_VERSION.ReadOnly = true;
			// 
			// GVS_AMBIENTE
			// 
			this.GVS_AMBIENTE.DataPropertyName = "GVS_AMBIENTE";
			this.GVS_AMBIENTE.HeaderText = "gvs_Ambiente";
			this.GVS_AMBIENTE.Name = "GVS_AMBIENTE";
			this.GVS_AMBIENTE.ReadOnly = true;
			this.GVS_AMBIENTE.Visible = false;
			// 
			// AMBIENTE
			// 
			this.AMBIENTE.DataPropertyName = "AMBIENTE";
			this.AMBIENTE.HeaderText = "Ambiente";
			this.AMBIENTE.Name = "AMBIENTE";
			this.AMBIENTE.ReadOnly = true;
			// 
			// cmsMenuContexto
			// 
			this.cmsMenuContexto.ImageScalingSize = new System.Drawing.Size(20, 20);
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
			// 
			// tsmEliminar
			// 
			this.tsmEliminar.Name = "tsmEliminar";
			this.tsmEliminar.Size = new System.Drawing.Size(160, 22);
			this.tsmEliminar.Text = "Eliminar";
			this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
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
			this.gpxFiltrar.Controls.Add(this.btn_Buscar);
			this.gpxFiltrar.Controls.Add(this.cbx_GVS_AMBIENTE_Buscar);
			this.gpxFiltrar.Controls.Add(this.label1);
			this.gpxFiltrar.Location = new System.Drawing.Point(3, 3);
			this.gpxFiltrar.Name = "gpxFiltrar";
			this.gpxFiltrar.Size = new System.Drawing.Size(533, 62);
			this.gpxFiltrar.TabIndex = 0;
			this.gpxFiltrar.TabStop = false;
			this.gpxFiltrar.Text = "Filtrar";
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Buscar.Location = new System.Drawing.Point(190, 13);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(46, 40);
			this.btn_Buscar.TabIndex = 3;
			this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Buscar.UseVisualStyleBackColor = true;
			this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
			// 
			// cbx_GVS_AMBIENTE_Buscar
			// 
			this.cbx_GVS_AMBIENTE_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_GVS_AMBIENTE_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_GVS_AMBIENTE_Buscar.FormattingEnabled = true;
			this.cbx_GVS_AMBIENTE_Buscar.Location = new System.Drawing.Point(63, 24);
			this.cbx_GVS_AMBIENTE_Buscar.Name = "cbx_GVS_AMBIENTE_Buscar";
			this.cbx_GVS_AMBIENTE_Buscar.Size = new System.Drawing.Size(121, 21);
			this.cbx_GVS_AMBIENTE_Buscar.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Estado";
			// 
			// GES_VERSIONES_SISTEMA
			// 
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.lbl_PK_VSISTEMA);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.txt_PK_VSISTEMA);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.lbl_PK_SISTEMA);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.txt_PK_SISTEMA);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.cbx_GVS_AMBIENTE);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.lbl_GVS_AMBIENTE);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.txt_GVS_N_VERSION);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.lbl_GVS_N_VERSION);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.btn_Minimizar);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.btn_Limpiar);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.btn_Guardar);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.txt_GVS_NOMBRE);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.lbl_GVS_NOMBRE);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.txt_GVS_DESCRIPCION);
			this.GES_VERSIONES_SISTEMA.Controls.Add(this.lbl_GVS_DESCRIPCION);
			this.GES_VERSIONES_SISTEMA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GES_VERSIONES_SISTEMA.Location = new System.Drawing.Point(0, 0);
			this.GES_VERSIONES_SISTEMA.Name = "GES_VERSIONES_SISTEMA";
			this.GES_VERSIONES_SISTEMA.Size = new System.Drawing.Size(375, 334);
			this.GES_VERSIONES_SISTEMA.TabIndex = 6;
			this.GES_VERSIONES_SISTEMA.TabStop = false;
			this.GES_VERSIONES_SISTEMA.Text = "Datos";
			// 
			// lbl_PK_VSISTEMA
			// 
			this.lbl_PK_VSISTEMA.AutoSize = true;
			this.lbl_PK_VSISTEMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_PK_VSISTEMA.Location = new System.Drawing.Point(277, 214);
			this.lbl_PK_VSISTEMA.Name = "lbl_PK_VSISTEMA";
			this.lbl_PK_VSISTEMA.Size = new System.Drawing.Size(64, 13);
			this.lbl_PK_VSISTEMA.TabIndex = 22;
			this.lbl_PK_VSISTEMA.Text = "PkVSistema";
			// 
			// txt_PK_VSISTEMA
			// 
			this.txt_PK_VSISTEMA.Location = new System.Drawing.Point(344, 216);
			this.txt_PK_VSISTEMA.MaxLength = 100;
			this.txt_PK_VSISTEMA.Name = "txt_PK_VSISTEMA";
			this.txt_PK_VSISTEMA.Size = new System.Drawing.Size(20, 20);
			this.txt_PK_VSISTEMA.TabIndex = 21;
			// 
			// lbl_PK_SISTEMA
			// 
			this.lbl_PK_SISTEMA.AutoSize = true;
			this.lbl_PK_SISTEMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_PK_SISTEMA.Location = new System.Drawing.Point(184, 213);
			this.lbl_PK_SISTEMA.Name = "lbl_PK_SISTEMA";
			this.lbl_PK_SISTEMA.Size = new System.Drawing.Size(57, 13);
			this.lbl_PK_SISTEMA.TabIndex = 20;
			this.lbl_PK_SISTEMA.Text = "PkSistema";
			// 
			// txt_PK_SISTEMA
			// 
			this.txt_PK_SISTEMA.Location = new System.Drawing.Point(251, 214);
			this.txt_PK_SISTEMA.MaxLength = 100;
			this.txt_PK_SISTEMA.Name = "txt_PK_SISTEMA";
			this.txt_PK_SISTEMA.Size = new System.Drawing.Size(20, 20);
			this.txt_PK_SISTEMA.TabIndex = 19;
			// 
			// cbx_GVS_AMBIENTE
			// 
			this.cbx_GVS_AMBIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_GVS_AMBIENTE.FormattingEnabled = true;
			this.cbx_GVS_AMBIENTE.Location = new System.Drawing.Point(88, 213);
			this.cbx_GVS_AMBIENTE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbx_GVS_AMBIENTE.Name = "cbx_GVS_AMBIENTE";
			this.cbx_GVS_AMBIENTE.Size = new System.Drawing.Size(92, 21);
			this.cbx_GVS_AMBIENTE.TabIndex = 10;
			// 
			// lbl_GVS_AMBIENTE
			// 
			this.lbl_GVS_AMBIENTE.AutoSize = true;
			this.lbl_GVS_AMBIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_GVS_AMBIENTE.Location = new System.Drawing.Point(3, 213);
			this.lbl_GVS_AMBIENTE.Name = "lbl_GVS_AMBIENTE";
			this.lbl_GVS_AMBIENTE.Size = new System.Drawing.Size(51, 13);
			this.lbl_GVS_AMBIENTE.TabIndex = 17;
			this.lbl_GVS_AMBIENTE.Text = "Ambiente";
			// 
			// txt_GVS_N_VERSION
			// 
			this.txt_GVS_N_VERSION.Location = new System.Drawing.Point(88, 183);
			this.txt_GVS_N_VERSION.MaxLength = 10;
			this.txt_GVS_N_VERSION.Name = "txt_GVS_N_VERSION";
			this.txt_GVS_N_VERSION.Size = new System.Drawing.Size(260, 20);
			this.txt_GVS_N_VERSION.TabIndex = 9;
			// 
			// lbl_GVS_N_VERSION
			// 
			this.lbl_GVS_N_VERSION.AutoSize = true;
			this.lbl_GVS_N_VERSION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_GVS_N_VERSION.Location = new System.Drawing.Point(3, 183);
			this.lbl_GVS_N_VERSION.Name = "lbl_GVS_N_VERSION";
			this.lbl_GVS_N_VERSION.Size = new System.Drawing.Size(57, 13);
			this.lbl_GVS_N_VERSION.TabIndex = 15;
			this.lbl_GVS_N_VERSION.Text = "N° Versión";
			// 
			// btn_Minimizar
			// 
			this.btn_Minimizar.Image = global::ControlDosimetro.Properties.Resources.minimizar;
			this.btn_Minimizar.Location = new System.Drawing.Point(319, 0);
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
			this.btn_Limpiar.Location = new System.Drawing.Point(178, 284);
			this.btn_Limpiar.Name = "btn_Limpiar";
			this.btn_Limpiar.Size = new System.Drawing.Size(85, 40);
			this.btn_Limpiar.TabIndex = 10;
			this.btn_Limpiar.Text = "Limpiar";
			this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Limpiar.UseVisualStyleBackColor = true;
			this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(49, 284);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
			this.btn_Guardar.TabIndex = 11;
			this.btn_Guardar.Text = "Grabar";
			this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// txt_GVS_NOMBRE
			// 
			this.txt_GVS_NOMBRE.Location = new System.Drawing.Point(88, 24);
			this.txt_GVS_NOMBRE.MaxLength = 100;
			this.txt_GVS_NOMBRE.Name = "txt_GVS_NOMBRE";
			this.txt_GVS_NOMBRE.Size = new System.Drawing.Size(260, 20);
			this.txt_GVS_NOMBRE.TabIndex = 7;
			// 
			// lbl_GVS_NOMBRE
			// 
			this.lbl_GVS_NOMBRE.AutoSize = true;
			this.lbl_GVS_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_GVS_NOMBRE.Location = new System.Drawing.Point(3, 24);
			this.lbl_GVS_NOMBRE.Name = "lbl_GVS_NOMBRE";
			this.lbl_GVS_NOMBRE.Size = new System.Drawing.Size(44, 13);
			this.lbl_GVS_NOMBRE.TabIndex = 10;
			this.lbl_GVS_NOMBRE.Text = "Nombre";
			// 
			// txt_GVS_DESCRIPCION
			// 
			this.txt_GVS_DESCRIPCION.Location = new System.Drawing.Point(88, 59);
			this.txt_GVS_DESCRIPCION.MaxLength = 5000;
			this.txt_GVS_DESCRIPCION.Multiline = true;
			this.txt_GVS_DESCRIPCION.Name = "txt_GVS_DESCRIPCION";
			this.txt_GVS_DESCRIPCION.Size = new System.Drawing.Size(260, 114);
			this.txt_GVS_DESCRIPCION.TabIndex = 8;
			// 
			// lbl_GVS_DESCRIPCION
			// 
			this.lbl_GVS_DESCRIPCION.AutoSize = true;
			this.lbl_GVS_DESCRIPCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_GVS_DESCRIPCION.Location = new System.Drawing.Point(3, 59);
			this.lbl_GVS_DESCRIPCION.Name = "lbl_GVS_DESCRIPCION";
			this.lbl_GVS_DESCRIPCION.Size = new System.Drawing.Size(63, 13);
			this.lbl_GVS_DESCRIPCION.TabIndex = 8;
			this.lbl_GVS_DESCRIPCION.Text = "Descripción";
			// 
			// frmMantVersionesSistema
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 384);
			this.Controls.Add(this.scPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.stsEstado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(644, 298);
			this.Name = "frmMantVersionesSistema";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mantenedor de versiones de sistema";
			this.Load += new System.EventHandler(this.frmMantVersionesSistema_Load);
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
			this.GES_VERSIONES_SISTEMA.ResumeLayout(false);
			this.GES_VERSIONES_SISTEMA.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbx_GVS_AMBIENTE_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox gpxListado;
        private System.Windows.Forms.GroupBox GES_VERSIONES_SISTEMA;
        private System.Windows.Forms.TextBox txt_GVS_NOMBRE;
        private System.Windows.Forms.Label lbl_GVS_NOMBRE;
        private System.Windows.Forms.TextBox txt_GVS_DESCRIPCION;
        private System.Windows.Forms.Label lbl_GVS_DESCRIPCION;
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
        private System.Windows.Forms.ToolStripDropDownButton tsdReporte;
        private System.Windows.Forms.Label lbl_GVS_AMBIENTE;
        private System.Windows.Forms.TextBox txt_GVS_N_VERSION;
        private System.Windows.Forms.Label lbl_GVS_N_VERSION;
        private System.Windows.Forms.ComboBox cbx_GVS_AMBIENTE;
        private System.Windows.Forms.TextBox txt_PK_SISTEMA;
        private System.Windows.Forms.Label lbl_PK_SISTEMA;
        private System.Windows.Forms.Label lbl_PK_VSISTEMA;
        private System.Windows.Forms.TextBox txt_PK_VSISTEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVS_NOMBRE;
        private GridExtension.IntegerGridColumn PK_VSISTEMA;
        private GridExtension.IntegerGridColumn PK_SISTEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVS_DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVS_N_VERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVS_AMBIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMBIENTE;
    }
}