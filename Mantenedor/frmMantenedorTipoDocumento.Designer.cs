namespace ControlDosimetro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Coldetalle_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.glo_TipoDocumentos = new System.Windows.Forms.GroupBox();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cbx_id_estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_detalle_tipo_documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_tipo_doc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // stsEstado
            // 
            this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
            this.stsEstado.Location = new System.Drawing.Point(0, 270);
            this.stsEstado.Name = "stsEstado";
            this.stsEstado.Size = new System.Drawing.Size(629, 22);
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
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
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
            this.scPrincipal.Panel2.Controls.Add(this.glo_TipoDocumentos);
            this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scPrincipal.Panel2MinSize = 200;
            this.scPrincipal.Size = new System.Drawing.Size(617, 242);
            this.scPrincipal.SplitterDistance = 250;
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
            this.pnlPrincipal.Size = new System.Drawing.Size(245, 236);
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
            this.gpxListado.Size = new System.Drawing.Size(237, 160);
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
            this.Coldetalle_tipo_documento});
            this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(231, 141);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
            this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
            this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
            // 
            // Coldetalle_tipo_documento
            // 
            this.Coldetalle_tipo_documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coldetalle_tipo_documento.DataPropertyName = "detalle_tipo_documento";
            this.Coldetalle_tipo_documento.HeaderText = "Nombre";
            this.Coldetalle_tipo_documento.Name = "Coldetalle_tipo_documento";
            this.Coldetalle_tipo_documento.ReadOnly = true;
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
            this.gpxFiltrar.Size = new System.Drawing.Size(237, 62);
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
            // glo_TipoDocumentos
            // 
            this.glo_TipoDocumentos.Controls.Add(this.cbx_id_estado);
            this.glo_TipoDocumentos.Controls.Add(this.label4);
            this.glo_TipoDocumentos.Controls.Add(this.txt_orden);
            this.glo_TipoDocumentos.Controls.Add(this.label3);
            this.glo_TipoDocumentos.Controls.Add(this.txt_detalle_tipo_documento);
            this.glo_TipoDocumentos.Controls.Add(this.label2);
            this.glo_TipoDocumentos.Controls.Add(this.txt_id_tipo_doc);
            this.glo_TipoDocumentos.Controls.Add(this.label5);
            this.glo_TipoDocumentos.Controls.Add(this.btn_Minimizar);
            this.glo_TipoDocumentos.Controls.Add(this.btn_Limpiar);
            this.glo_TipoDocumentos.Controls.Add(this.btn_Guardar);
            this.glo_TipoDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glo_TipoDocumentos.Location = new System.Drawing.Point(0, 0);
            this.glo_TipoDocumentos.Name = "glo_TipoDocumentos";
            this.glo_TipoDocumentos.Size = new System.Drawing.Size(363, 242);
            this.glo_TipoDocumentos.TabIndex = 6;
            this.glo_TipoDocumentos.TabStop = false;
            this.glo_TipoDocumentos.Text = "Datos";
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
            this.btn_Limpiar.Location = new System.Drawing.Point(173, 192);
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
            this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(44, 192);
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
            this.cbx_id_estado.Location = new System.Drawing.Point(95, 100);
            this.cbx_id_estado.Name = "cbx_id_estado";
            this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_id_estado.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado";
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(95, 73);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(100, 20);
            this.txt_orden.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Orden";
            // 
            // txt_detalle_tipo_documento
            // 
            this.txt_detalle_tipo_documento.Location = new System.Drawing.Point(95, 47);
            this.txt_detalle_tipo_documento.MaxLength = 50;
            this.txt_detalle_tipo_documento.Name = "txt_detalle_tipo_documento";
            this.txt_detalle_tipo_documento.Size = new System.Drawing.Size(260, 20);
            this.txt_detalle_tipo_documento.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripción";
            // 
            // txt_id_tipo_doc
            // 
            this.txt_id_tipo_doc.Enabled = false;
            this.txt_id_tipo_doc.Location = new System.Drawing.Point(95, 19);
            this.txt_id_tipo_doc.Name = "txt_id_tipo_doc";
            this.txt_id_tipo_doc.Size = new System.Drawing.Size(66, 20);
            this.txt_id_tipo_doc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // frmMantenedorTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 292);
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsEstado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(645, 300);
            this.Name = "frmMantenedorTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignarPermiso;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldetalle_tipo_documento;
        private System.Windows.Forms.ComboBox cbx_id_estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_detalle_tipo_documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_tipo_doc;
        private System.Windows.Forms.Label label5;
    }
}