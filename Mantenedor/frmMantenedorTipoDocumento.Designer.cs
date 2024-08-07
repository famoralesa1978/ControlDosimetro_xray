﻿namespace ControlDosimetro
{
    partial class frmMantenedorTipoDocumento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenedorTipoDocumento));
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
			this.Coldetalle_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSep3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
			this.gpxFiltrar = new System.Windows.Forms.GroupBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.cbx_id_estado_Buscar = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.glo_TipoDocumentos = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.cbx_id_estado = new System.Windows.Forms.ComboBox();
			this.lbl_id_estado = new System.Windows.Forms.Label();
			this.txt_orden = new System.Windows.Forms.TextBox();
			this.lbl_orden = new System.Windows.Forms.Label();
			this.txt_detalle_tipo_documento = new System.Windows.Forms.TextBox();
			this.lbl_detalle_tipo_documento = new System.Windows.Forms.Label();
			this.txt_id_tipo_doc = new System.Windows.Forms.TextBox();
			this.lbl_id_tipo_doc = new System.Windows.Forms.Label();
			this.btn_Limpiar = new System.Windows.Forms.Button();
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
			this.glo_TipoDocumentos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 351);
			this.stsEstado.Name = "stsEstado";
			this.stsEstado.Size = new System.Drawing.Size(748, 22);
			this.stsEstado.SizingGrip = false;
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
			this.toolStrip1.Size = new System.Drawing.Size(748, 27);
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
			this.tsdReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsdReporte.Image")));
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
			this.scPrincipal.Panel1MinSize = 330;
			// 
			// scPrincipal.Panel2
			// 
			this.scPrincipal.Panel2.Controls.Add(this.glo_TipoDocumentos);
			this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel2MinSize = 300;
			this.scPrincipal.Size = new System.Drawing.Size(735, 323);
			this.scPrincipal.SplitterDistance = 330;
			this.scPrincipal.TabIndex = 2;
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPrincipal.Controls.Add(this.gpxListado);
			this.pnlPrincipal.Controls.Add(this.gpxFiltrar);
			this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
			this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(330, 323);
			this.pnlPrincipal.TabIndex = 1;
			// 
			// gpxListado
			// 
			this.gpxListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpxListado.Controls.Add(this.dgvGrilla);
			this.gpxListado.Location = new System.Drawing.Point(0, 107);
			this.gpxListado.Name = "gpxListado";
			this.gpxListado.Size = new System.Drawing.Size(322, 214);
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
            this.Coldetalle_tipo_documento});
			this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(316, 195);
			this.dgvGrilla.TabIndex = 1;
			this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
			this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
			this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
			// 
			// Coldetalle_tipo_documento
			// 
			this.Coldetalle_tipo_documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Coldetalle_tipo_documento.DataPropertyName = "detalle_tipo_documento";
			this.Coldetalle_tipo_documento.HeaderText = "Nombres";
			this.Coldetalle_tipo_documento.Name = "Coldetalle_tipo_documento";
			this.Coldetalle_tipo_documento.ReadOnly = true;
			// 
			// cmsMenuContexto
			// 
			this.cmsMenuContexto.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsMenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripSeparator2,
            this.tsmEliminar,
            this.tsmSep3,
            this.tsmAsignarPermiso});
			this.cmsMenuContexto.Name = "cmsMenuContexto";
			this.cmsMenuContexto.Size = new System.Drawing.Size(161, 82);
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
			// tsmEliminar
			// 
			this.tsmEliminar.Name = "tsmEliminar";
			this.tsmEliminar.Size = new System.Drawing.Size(160, 22);
			this.tsmEliminar.Text = "Eliminar";
			this.tsmEliminar.Click += new System.EventHandler(this.TsmEliminar_Click);
			// 
			// tsmSep3
			// 
			this.tsmSep3.Name = "tsmSep3";
			this.tsmSep3.Size = new System.Drawing.Size(157, 6);
			this.tsmSep3.Visible = false;
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
			this.gpxFiltrar.Controls.Add(this.btn_Buscar);
			this.gpxFiltrar.Controls.Add(this.cbx_id_estado_Buscar);
			this.gpxFiltrar.Controls.Add(this.label1);
			this.gpxFiltrar.Location = new System.Drawing.Point(3, 3);
			this.gpxFiltrar.Name = "gpxFiltrar";
			this.gpxFiltrar.Size = new System.Drawing.Size(319, 89);
			this.gpxFiltrar.TabIndex = 0;
			this.gpxFiltrar.TabStop = false;
			this.gpxFiltrar.Text = "Filtrar";
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Buscar.Location = new System.Drawing.Point(243, 24);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(46, 40);
			this.btn_Buscar.TabIndex = 3;
			this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Buscar.UseVisualStyleBackColor = true;
			this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
			// 
			// cbx_id_estado_Buscar
			// 
			this.cbx_id_estado_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estado_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_estado_Buscar.FormattingEnabled = true;
			this.cbx_id_estado_Buscar.Location = new System.Drawing.Point(68, 34);
			this.cbx_id_estado_Buscar.Name = "cbx_id_estado_Buscar";
			this.cbx_id_estado_Buscar.Size = new System.Drawing.Size(153, 21);
			this.cbx_id_estado_Buscar.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Estado";
			// 
			// glo_TipoDocumentos
			// 
			this.glo_TipoDocumentos.BackColor = System.Drawing.SystemColors.Control;
			this.glo_TipoDocumentos.Controls.Add(this.pictureBox1);
			this.glo_TipoDocumentos.Controls.Add(this.btn_Guardar);
			this.glo_TipoDocumentos.Controls.Add(this.cbx_id_estado);
			this.glo_TipoDocumentos.Controls.Add(this.lbl_id_estado);
			this.glo_TipoDocumentos.Controls.Add(this.txt_orden);
			this.glo_TipoDocumentos.Controls.Add(this.lbl_orden);
			this.glo_TipoDocumentos.Controls.Add(this.txt_detalle_tipo_documento);
			this.glo_TipoDocumentos.Controls.Add(this.lbl_detalle_tipo_documento);
			this.glo_TipoDocumentos.Controls.Add(this.txt_id_tipo_doc);
			this.glo_TipoDocumentos.Controls.Add(this.lbl_id_tipo_doc);
			this.glo_TipoDocumentos.Controls.Add(this.btn_Limpiar);
			this.glo_TipoDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glo_TipoDocumentos.Location = new System.Drawing.Point(0, 0);
			this.glo_TipoDocumentos.Name = "glo_TipoDocumentos";
			this.glo_TipoDocumentos.Size = new System.Drawing.Size(401, 323);
			this.glo_TipoDocumentos.TabIndex = 6;
			this.glo_TipoDocumentos.TabStop = false;
			this.glo_TipoDocumentos.Text = "Datos";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::ControlDosimetro.Properties.Resources.minimizar;
			this.pictureBox1.InitialImage = global::ControlDosimetro.Properties.Resources.minimizar;
			this.pictureBox1.Location = new System.Drawing.Point(3, 16);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(395, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.Btn_Minimizar_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(89, 273);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
			this.btn_Guardar.TabIndex = 22;
			this.btn_Guardar.Text = "Grabar";
			this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// cbx_id_estado
			// 
			this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_estado.FormattingEnabled = true;
			this.cbx_id_estado.Location = new System.Drawing.Point(131, 113);
			this.cbx_id_estado.Name = "cbx_id_estado";
			this.cbx_id_estado.Size = new System.Drawing.Size(155, 21);
			this.cbx_id_estado.TabIndex = 21;
			// 
			// lbl_id_estado
			// 
			this.lbl_id_estado.AutoSize = true;
			this.lbl_id_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_estado.Location = new System.Drawing.Point(29, 117);
			this.lbl_id_estado.Name = "lbl_id_estado";
			this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
			this.lbl_id_estado.TabIndex = 20;
			this.lbl_id_estado.Text = "Estado";
			// 
			// txt_orden
			// 
			this.txt_orden.Location = new System.Drawing.Point(131, 87);
			this.txt_orden.MaxLength = 2;
			this.txt_orden.Name = "txt_orden";
			this.txt_orden.Size = new System.Drawing.Size(155, 20);
			this.txt_orden.TabIndex = 19;
			// 
			// lbl_orden
			// 
			this.lbl_orden.AutoSize = true;
			this.lbl_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_orden.Location = new System.Drawing.Point(29, 90);
			this.lbl_orden.Name = "lbl_orden";
			this.lbl_orden.Size = new System.Drawing.Size(36, 13);
			this.lbl_orden.TabIndex = 18;
			this.lbl_orden.Text = "Orden";
			// 
			// txt_detalle_tipo_documento
			// 
			this.txt_detalle_tipo_documento.Location = new System.Drawing.Point(131, 61);
			this.txt_detalle_tipo_documento.MaxLength = 50;
			this.txt_detalle_tipo_documento.Name = "txt_detalle_tipo_documento";
			this.txt_detalle_tipo_documento.Size = new System.Drawing.Size(155, 20);
			this.txt_detalle_tipo_documento.TabIndex = 17;
			// 
			// lbl_detalle_tipo_documento
			// 
			this.lbl_detalle_tipo_documento.AutoSize = true;
			this.lbl_detalle_tipo_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_detalle_tipo_documento.Location = new System.Drawing.Point(29, 64);
			this.lbl_detalle_tipo_documento.Name = "lbl_detalle_tipo_documento";
			this.lbl_detalle_tipo_documento.Size = new System.Drawing.Size(63, 13);
			this.lbl_detalle_tipo_documento.TabIndex = 16;
			this.lbl_detalle_tipo_documento.Text = "Descripción";
			// 
			// txt_id_tipo_doc
			// 
			this.txt_id_tipo_doc.Enabled = false;
			this.txt_id_tipo_doc.Location = new System.Drawing.Point(131, 141);
			this.txt_id_tipo_doc.Name = "txt_id_tipo_doc";
			this.txt_id_tipo_doc.Size = new System.Drawing.Size(66, 20);
			this.txt_id_tipo_doc.TabIndex = 15;
			this.txt_id_tipo_doc.Visible = false;
			// 
			// lbl_id_tipo_doc
			// 
			this.lbl_id_tipo_doc.AutoSize = true;
			this.lbl_id_tipo_doc.Location = new System.Drawing.Point(29, 144);
			this.lbl_id_tipo_doc.Name = "lbl_id_tipo_doc";
			this.lbl_id_tipo_doc.Size = new System.Drawing.Size(18, 13);
			this.lbl_id_tipo_doc.TabIndex = 14;
			this.lbl_id_tipo_doc.Text = "ID";
			this.lbl_id_tipo_doc.Visible = false;
			// 
			// btn_Limpiar
			// 
			this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
			this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Limpiar.Location = new System.Drawing.Point(245, 273);
			this.btn_Limpiar.Name = "btn_Limpiar";
			this.btn_Limpiar.Size = new System.Drawing.Size(85, 40);
			this.btn_Limpiar.TabIndex = 10;
			this.btn_Limpiar.Text = "Limpiar";
			this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Limpiar.UseVisualStyleBackColor = true;
			this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
			// 
			// frmMantenedorTipoDocumento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(748, 373);
			this.Controls.Add(this.scPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.stsEstado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(764, 410);
			this.Name = "frmMantenedorTipoDocumento";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenedor de tipo documento";
			this.Load += new System.EventHandler(this.frmMantenedorPerfil_Load);
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
			this.glo_TipoDocumentos.ResumeLayout(false);
			this.glo_TipoDocumentos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox glo_TipoDocumentos;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContexto;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripSeparator tsmSep3;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignarPermiso;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ComboBox cbx_id_estado;
        private System.Windows.Forms.Label lbl_id_estado;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.TextBox txt_detalle_tipo_documento;
        private System.Windows.Forms.Label lbl_detalle_tipo_documento;
        private System.Windows.Forms.TextBox txt_id_tipo_doc;
        private System.Windows.Forms.Label lbl_id_tipo_doc;
		private System.Windows.Forms.Button btn_Guardar;
		private System.Windows.Forms.DataGridView dgvGrilla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Coldetalle_tipo_documento;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripDropDownButton tsdReporte;
	}
}