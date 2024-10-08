﻿namespace ControlDosimetro
{
    partial class frmMantenedorSeccion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenedorSeccion));
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
			this.Colperfil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
			this.gpxFiltrar = new System.Windows.Forms.GroupBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.cbx_id_estado_Buscar = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbl_seccion = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_Run = new System.Windows.Forms.Label();
			this.lbl_Nombre = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.btn_Minimizar = new System.Windows.Forms.Button();
			this.btn_Limpiar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.cbx_id_estado = new System.Windows.Forms.ComboBox();
			this.lbl_id_estado = new System.Windows.Forms.Label();
			this.txt_seccion = new System.Windows.Forms.TextBox();
			this.lbl_seccion = new System.Windows.Forms.Label();
			this.txt_id_seccion = new System.Windows.Forms.TextBox();
			this.lbl_id_seccion = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
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
			this.tbl_seccion.SuspendLayout();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 348);
			this.stsEstado.Name = "stsEstado";
			this.stsEstado.Size = new System.Drawing.Size(628, 22);
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
			this.toolStrip1.Size = new System.Drawing.Size(628, 39);
			this.toolStrip1.TabIndex = 1;
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
			this.tsbGuardar.Text = "toolStripButton1";
			this.tsbGuardar.ToolTipText = "Guarda la infomación";
			this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// tsbAgregar
			// 
			this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.tsbAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregar.Name = "tsbAgregar";
			this.tsbAgregar.Size = new System.Drawing.Size(36, 36);
			this.tsbAgregar.Text = "Permite  Agregar un perfil de usuario";
			this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
			// 
			// tsdReporte
			// 
			this.tsdReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsdReporte.Image")));
			this.tsdReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdReporte.Name = "tsdReporte";
			this.tsdReporte.Size = new System.Drawing.Size(61, 36);
			this.tsdReporte.Text = "Reporte";
			// 
			// scPrincipal
			// 
			this.scPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scPrincipal.Location = new System.Drawing.Point(0, 39);
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
			this.scPrincipal.Panel2.Controls.Add(this.tbl_seccion);
			this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel2MinSize = 200;
			this.scPrincipal.Size = new System.Drawing.Size(628, 309);
			this.scPrincipal.SplitterDistance = 253;
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
			this.pnlPrincipal.Size = new System.Drawing.Size(248, 303);
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
			this.gpxListado.Size = new System.Drawing.Size(240, 227);
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
            this.Colperfil1});
			this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(234, 208);
			this.dgvGrilla.TabIndex = 0;
			this.dgvGrilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellClick);
			this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
			this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
			this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
			// 
			// Colperfil1
			// 
			this.Colperfil1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Colperfil1.DataPropertyName = "seccion";
			this.Colperfil1.HeaderText = "Nombre";
			this.Colperfil1.Name = "Colperfil1";
			this.Colperfil1.ReadOnly = true;
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
			this.gpxFiltrar.Controls.Add(this.cbx_id_estado_Buscar);
			this.gpxFiltrar.Controls.Add(this.label1);
			this.gpxFiltrar.Location = new System.Drawing.Point(3, 3);
			this.gpxFiltrar.Name = "gpxFiltrar";
			this.gpxFiltrar.Size = new System.Drawing.Size(240, 62);
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
			// cbx_id_estado_Buscar
			// 
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
			this.label1.Location = new System.Drawing.Point(0, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Estado";
			// 
			// tbl_seccion
			// 
			this.tbl_seccion.Controls.Add(this.btnEliminar);
			this.tbl_seccion.Controls.Add(this.label4);
			this.tbl_seccion.Controls.Add(this.label3);
			this.tbl_seccion.Controls.Add(this.lbl_Run);
			this.tbl_seccion.Controls.Add(this.lbl_Nombre);
			this.tbl_seccion.Controls.Add(this.label2);
			this.tbl_seccion.Controls.Add(this.lbl_id_cliente);
			this.tbl_seccion.Controls.Add(this.btn_Minimizar);
			this.tbl_seccion.Controls.Add(this.btn_Limpiar);
			this.tbl_seccion.Controls.Add(this.btn_Guardar);
			this.tbl_seccion.Controls.Add(this.cbx_id_estado);
			this.tbl_seccion.Controls.Add(this.lbl_id_estado);
			this.tbl_seccion.Controls.Add(this.txt_seccion);
			this.tbl_seccion.Controls.Add(this.lbl_seccion);
			this.tbl_seccion.Controls.Add(this.txt_id_seccion);
			this.tbl_seccion.Controls.Add(this.lbl_id_seccion);
			this.tbl_seccion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_seccion.Location = new System.Drawing.Point(0, 0);
			this.tbl_seccion.Name = "tbl_seccion";
			this.tbl_seccion.Size = new System.Drawing.Size(371, 309);
			this.tbl_seccion.TabIndex = 6;
			this.tbl_seccion.TabStop = false;
			this.tbl_seccion.Text = "Datos";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Razón  social";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Rut";
			// 
			// lbl_Run
			// 
			this.lbl_Run.AutoSize = true;
			this.lbl_Run.Location = new System.Drawing.Point(85, 63);
			this.lbl_Run.Name = "lbl_Run";
			this.lbl_Run.Size = new System.Drawing.Size(44, 13);
			this.lbl_Run.TabIndex = 18;
			this.lbl_Run.Text = "Nombre";
			// 
			// lbl_Nombre
			// 
			this.lbl_Nombre.AutoSize = true;
			this.lbl_Nombre.Location = new System.Drawing.Point(85, 40);
			this.lbl_Nombre.Name = "lbl_Nombre";
			this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
			this.lbl_Nombre.TabIndex = 16;
			this.lbl_Nombre.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "N° Cliente";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Location = new System.Drawing.Point(85, 20);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(54, 13);
			this.lbl_id_cliente.TabIndex = 14;
			this.lbl_id_cliente.Text = "N° Cliente";
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
			this.btn_Limpiar.Location = new System.Drawing.Point(248, 259);
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
			this.btn_Guardar.Location = new System.Drawing.Point(11, 259);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
			this.btn_Guardar.TabIndex = 9;
			this.btn_Guardar.Text = "Grabar";
			this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// cbx_id_estado
			// 
			this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_estado.FormattingEnabled = true;
			this.cbx_id_estado.Location = new System.Drawing.Point(88, 118);
			this.cbx_id_estado.Name = "cbx_id_estado";
			this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_estado.TabIndex = 8;
			// 
			// lbl_id_estado
			// 
			this.lbl_id_estado.AutoSize = true;
			this.lbl_id_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_estado.Location = new System.Drawing.Point(3, 121);
			this.lbl_id_estado.Name = "lbl_id_estado";
			this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
			this.lbl_id_estado.TabIndex = 12;
			this.lbl_id_estado.Text = "Estado";
			// 
			// txt_seccion
			// 
			this.txt_seccion.Location = new System.Drawing.Point(88, 92);
			this.txt_seccion.MaxLength = 50;
			this.txt_seccion.Name = "txt_seccion";
			this.txt_seccion.Size = new System.Drawing.Size(260, 20);
			this.txt_seccion.TabIndex = 7;
			// 
			// lbl_seccion
			// 
			this.lbl_seccion.AutoSize = true;
			this.lbl_seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_seccion.Location = new System.Drawing.Point(3, 95);
			this.lbl_seccion.Name = "lbl_seccion";
			this.lbl_seccion.Size = new System.Drawing.Size(63, 13);
			this.lbl_seccion.TabIndex = 10;
			this.lbl_seccion.Text = "Descripción";
			// 
			// txt_id_seccion
			// 
			this.txt_id_seccion.Enabled = false;
			this.txt_id_seccion.Location = new System.Drawing.Point(88, 145);
			this.txt_id_seccion.Name = "txt_id_seccion";
			this.txt_id_seccion.Size = new System.Drawing.Size(66, 20);
			this.txt_id_seccion.TabIndex = 9;
			// 
			// lbl_id_seccion
			// 
			this.lbl_id_seccion.AutoSize = true;
			this.lbl_id_seccion.Location = new System.Drawing.Point(3, 148);
			this.lbl_id_seccion.Name = "lbl_id_seccion";
			this.lbl_id_seccion.Size = new System.Drawing.Size(18, 13);
			this.lbl_id_seccion.TabIndex = 8;
			this.lbl_id_seccion.Text = "ID";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnEliminar.Image = global::ControlDosimetro.Properties.Resources.delete_32;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(135, 259);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(87, 40);
			this.btnEliminar.TabIndex = 21;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// frmMantenedorSeccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 370);
			this.Controls.Add(this.scPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.stsEstado);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(644, 298);
			this.Name = "frmMantenedorSeccion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mantenedor de sección";
			this.Load += new System.EventHandler(this.frmMantenedorSeccion_Load);
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
			this.tbl_seccion.ResumeLayout(false);
			this.tbl_seccion.PerformLayout();
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
        private System.Windows.Forms.GroupBox tbl_seccion;
        private System.Windows.Forms.ComboBox cbx_id_estado;
        private System.Windows.Forms.Label lbl_id_estado;
        private System.Windows.Forms.TextBox txt_seccion;
        private System.Windows.Forms.Label lbl_seccion;
        private System.Windows.Forms.TextBox txt_id_seccion;
        private System.Windows.Forms.Label lbl_id_seccion;
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
		private System.Windows.Forms.Label lbl_id_cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Colperfil1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_Nombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_Run;
		private System.Windows.Forms.Button btnEliminar;
	}
}