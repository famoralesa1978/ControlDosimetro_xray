namespace ControlDosimetro
{
    partial class frmMantenedorClienteCorreo
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
			this.Colperfil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
			this.tbl_cliente_Email = new System.Windows.Forms.GroupBox();
			this.btn_Minimizar = new System.Windows.Forms.Button();
			this.btn_Limpiar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.txt_Id = new System.Windows.Forms.TextBox();
			this.lbl_Id_perfil = new System.Windows.Forms.Label();
			this.txt_run = new System.Windows.Forms.TextBox();
			this.lbl_run = new System.Windows.Forms.Label();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
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
			this.tbl_cliente_Email.SuspendLayout();
			this.SuspendLayout();
			// 
			// stsEstado
			// 
			this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
			this.stsEstado.Location = new System.Drawing.Point(0, 297);
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
			this.scPrincipal.Panel2.Controls.Add(this.tbl_cliente_Email);
			this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.scPrincipal.Panel2MinSize = 200;
			this.scPrincipal.Size = new System.Drawing.Size(617, 269);
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
			this.pnlPrincipal.Location = new System.Drawing.Point(0, 3);
			this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(245, 263);
			this.pnlPrincipal.TabIndex = 1;
			// 
			// gpxListado
			// 
			this.gpxListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpxListado.Controls.Add(this.dgvGrilla);
			this.gpxListado.Location = new System.Drawing.Point(3, 3);
			this.gpxListado.Name = "gpxListado";
			this.gpxListado.Size = new System.Drawing.Size(237, 255);
			this.gpxListado.TabIndex = 4;
			this.gpxListado.TabStop = false;
			this.gpxListado.Text = "Listado correo";
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
			this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
			this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.Size = new System.Drawing.Size(231, 236);
			this.dgvGrilla.TabIndex = 0;
			this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
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
			// tbl_cliente_Email
			// 
			this.tbl_cliente_Email.Controls.Add(this.lbl_Email);
			this.tbl_cliente_Email.Controls.Add(this.txt_Email);
			this.tbl_cliente_Email.Controls.Add(this.txt_run);
			this.tbl_cliente_Email.Controls.Add(this.lbl_run);
			this.tbl_cliente_Email.Controls.Add(this.btn_Minimizar);
			this.tbl_cliente_Email.Controls.Add(this.btn_Limpiar);
			this.tbl_cliente_Email.Controls.Add(this.btn_Guardar);
			this.tbl_cliente_Email.Controls.Add(this.txt_Id);
			this.tbl_cliente_Email.Controls.Add(this.lbl_Id_perfil);
			this.tbl_cliente_Email.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_cliente_Email.Location = new System.Drawing.Point(0, 0);
			this.tbl_cliente_Email.Name = "tbl_cliente_Email";
			this.tbl_cliente_Email.Size = new System.Drawing.Size(363, 269);
			this.tbl_cliente_Email.TabIndex = 6;
			this.tbl_cliente_Email.TabStop = false;
			this.tbl_cliente_Email.Text = "Datos";
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
			this.btn_Limpiar.Location = new System.Drawing.Point(173, 219);
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
			this.btn_Guardar.Location = new System.Drawing.Point(44, 219);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
			this.btn_Guardar.TabIndex = 9;
			this.btn_Guardar.Text = "Grabar";
			this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// txt_Id
			// 
			this.txt_Id.Enabled = false;
			this.txt_Id.Location = new System.Drawing.Point(88, 66);
			this.txt_Id.Name = "txt_Id";
			this.txt_Id.ReadOnly = true;
			this.txt_Id.Size = new System.Drawing.Size(66, 20);
			this.txt_Id.TabIndex = 9;
			this.txt_Id.Visible = false;
			// 
			// lbl_Id_perfil
			// 
			this.lbl_Id_perfil.AutoSize = true;
			this.lbl_Id_perfil.Location = new System.Drawing.Point(3, 73);
			this.lbl_Id_perfil.Name = "lbl_Id_perfil";
			this.lbl_Id_perfil.Size = new System.Drawing.Size(18, 13);
			this.lbl_Id_perfil.TabIndex = 8;
			this.lbl_Id_perfil.Text = "ID";
			this.lbl_Id_perfil.Visible = false;
			// 
			// txt_run
			// 
			this.txt_run.Location = new System.Drawing.Point(88, 13);
			this.txt_run.MaxLength = 10;
			this.txt_run.Name = "txt_run";
			this.txt_run.Size = new System.Drawing.Size(120, 20);
			this.txt_run.TabIndex = 15;
			// 
			// lbl_run
			// 
			this.lbl_run.AutoSize = true;
			this.lbl_run.Location = new System.Drawing.Point(6, 16);
			this.lbl_run.Name = "lbl_run";
			this.lbl_run.Size = new System.Drawing.Size(24, 13);
			this.lbl_run.TabIndex = 14;
			this.lbl_run.Text = "Rut";
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Location = new System.Drawing.Point(6, 42);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(32, 13);
			this.lbl_Email.TabIndex = 42;
			this.lbl_Email.Text = "Email";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(88, 39);
			this.txt_Email.MaxLength = 100;
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(303, 20);
			this.txt_Email.TabIndex = 41;
			// 
			// frmMantenedorClienteCorreo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 319);
			this.Controls.Add(this.scPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.stsEstado);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(645, 300);
			this.Name = "frmMantenedorClienteCorreo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mantenedor de perfil de usuario";
			this.Load += new System.EventHandler(this.frmMantenedorClienteCorreo_Load);
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
			this.tbl_cliente_Email.ResumeLayout(false);
			this.tbl_cliente_Email.PerformLayout();
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
        private System.Windows.Forms.GroupBox tbl_cliente_Email;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id_perfil;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Colperfil1;
		private System.Windows.Forms.TextBox txt_run;
		private System.Windows.Forms.Label lbl_run;
		private System.Windows.Forms.Label lbl_Email;
		private System.Windows.Forms.TextBox txt_Email;
	}
}