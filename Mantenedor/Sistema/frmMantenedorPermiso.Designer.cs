namespace ControlDosimetro
{
    partial class frmMantenedorPermiso
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
			this.Colperfil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbl_perfil = new System.Windows.Forms.GroupBox();
			this.dgvDetalle = new System.Windows.Forms.DataGridView();
			this.ColMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColAcceso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColLectura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColNuevo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColModificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.stsEstado.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
			this.scPrincipal.Panel1.SuspendLayout();
			this.scPrincipal.Panel2.SuspendLayout();
			this.scPrincipal.SuspendLayout();
			this.pnlPrincipal.SuspendLayout();
			this.gpxListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
			this.tbl_perfil.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 489);
			this.stsEstado.Name = "stsEstado";
			this.stsEstado.Size = new System.Drawing.Size(969, 22);
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
			this.toolStrip1.Size = new System.Drawing.Size(969, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbGuardar
			// 
			this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
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
			this.scPrincipal.Panel2.Controls.Add(this.tbl_perfil);
			this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel2MinSize = 200;
			this.scPrincipal.Size = new System.Drawing.Size(957, 461);
			this.scPrincipal.SplitterDistance = 309;
			this.scPrincipal.TabIndex = 2;
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPrincipal.Controls.Add(this.gpxListado);
			this.pnlPrincipal.Location = new System.Drawing.Point(0, 3);
			this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(304, 455);
			this.pnlPrincipal.TabIndex = 1;
			// 
			// gpxListado
			// 
			this.gpxListado.Controls.Add(this.dgvGrilla);
			this.gpxListado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gpxListado.Location = new System.Drawing.Point(0, 0);
			this.gpxListado.Name = "gpxListado";
			this.gpxListado.Size = new System.Drawing.Size(302, 453);
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
            this.Colperfil1});
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(296, 434);
			this.dgvGrilla.TabIndex = 0;
			this.dgvGrilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellClick);
			this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
			this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
			// 
			// Colperfil1
			// 
			this.Colperfil1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Colperfil1.DataPropertyName = "Descripcion";
			this.Colperfil1.HeaderText = "Nombre";
			this.Colperfil1.Name = "Colperfil1";
			this.Colperfil1.ReadOnly = true;
			// 
			// tbl_perfil
			// 
			this.tbl_perfil.Controls.Add(this.dgvDetalle);
			this.tbl_perfil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_perfil.Location = new System.Drawing.Point(0, 0);
			this.tbl_perfil.Name = "tbl_perfil";
			this.tbl_perfil.Size = new System.Drawing.Size(644, 461);
			this.tbl_perfil.TabIndex = 6;
			this.tbl_perfil.TabStop = false;
			this.tbl_perfil.Text = "Permiso";
			// 
			// dgvDetalle
			// 
			this.dgvDetalle.AllowUserToAddRows = false;
			this.dgvDetalle.AllowUserToDeleteRows = false;
			this.dgvDetalle.AllowUserToResizeColumns = false;
			this.dgvDetalle.AllowUserToResizeRows = false;
			this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMenu,
            this.ColAcceso,
            this.ColLectura,
            this.ColNuevo,
            this.ColModificacion,
            this.ColEliminar});
			this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
			this.dgvDetalle.Name = "dgvDetalle";
			this.dgvDetalle.Size = new System.Drawing.Size(638, 442);
			this.dgvDetalle.TabIndex = 0;
			this.dgvDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellValueChanged);
			this.dgvDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetalle_CurrentCellDirtyStateChanged);
			this.dgvDetalle.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDetalle_DataBindingComplete);
			// 
			// ColMenu
			// 
			this.ColMenu.DataPropertyName = "Menu";
			this.ColMenu.HeaderText = "Menu";
			this.ColMenu.Name = "ColMenu";
			this.ColMenu.ReadOnly = true;
			this.ColMenu.Width = 130;
			// 
			// ColAcceso
			// 
			this.ColAcceso.DataPropertyName = "Acceso";
			this.ColAcceso.HeaderText = "Acceso";
			this.ColAcceso.Name = "ColAcceso";
			this.ColAcceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColAcceso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColAcceso.Width = 80;
			// 
			// ColLectura
			// 
			this.ColLectura.DataPropertyName = "Lectura";
			this.ColLectura.HeaderText = "Lectura";
			this.ColLectura.Name = "ColLectura";
			// 
			// ColNuevo
			// 
			this.ColNuevo.DataPropertyName = "Nuevo";
			this.ColNuevo.HeaderText = "Nuevo";
			this.ColNuevo.Name = "ColNuevo";
			// 
			// ColModificacion
			// 
			this.ColModificacion.DataPropertyName = "Modificacion";
			this.ColModificacion.HeaderText = "Modificación";
			this.ColModificacion.Name = "ColModificacion";
			// 
			// ColEliminar
			// 
			this.ColEliminar.DataPropertyName = "Eliminar";
			this.ColEliminar.HeaderText = "Eliminar";
			this.ColEliminar.Name = "ColEliminar";
			// 
			// frmMantenedorPermiso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 511);
			this.Controls.Add(this.scPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.stsEstado);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(645, 300);
			this.Name = "frmMantenedorPermiso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mantenedor de permiso";
			this.Load += new System.EventHandler(this.frmMantenedorPermiso_Load);
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
			this.tbl_perfil.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
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
        private System.Windows.Forms.GroupBox gpxListado;
        private System.Windows.Forms.GroupBox tbl_perfil;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colperfil1;
		private System.Windows.Forms.DataGridView dgvDetalle;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColMenu;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColAcceso;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColLectura;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColNuevo;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColModificacion;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColEliminar;
	}
}