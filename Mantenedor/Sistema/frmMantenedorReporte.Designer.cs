namespace ControlDosimetro
{
    partial class frmMantenedorReporte
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
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_Reporte = new System.Windows.Forms.GroupBox();
            this.txt_N_Reporte = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_NameMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_N_Reporte = new System.Windows.Forms.Label();
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
            this.tbl_Reporte.SuspendLayout();
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
            this.tsbAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
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
            this.scPrincipal.Panel2.Controls.Add(this.tbl_Reporte);
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
            this.gpxListado.Location = new System.Drawing.Point(0, 4);
            this.gpxListado.Name = "gpxListado";
            this.gpxListado.Size = new System.Drawing.Size(322, 317);
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
            this.ColNombre});
            this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(316, 298);
            this.dgvGrilla.TabIndex = 1;
            this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
            this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
            this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // cmsMenuContexto
            // 
            this.cmsMenuContexto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripSeparator2,
            this.tsmSep3,
            this.tsmAsignarPermiso});
            this.cmsMenuContexto.Name = "cmsMenuContexto";
            this.cmsMenuContexto.Size = new System.Drawing.Size(161, 60);
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
            // tbl_Reporte
            // 
            this.tbl_Reporte.BackColor = System.Drawing.SystemColors.Control;
            this.tbl_Reporte.Controls.Add(this.txt_N_Reporte);
            this.tbl_Reporte.Controls.Add(this.pictureBox1);
            this.tbl_Reporte.Controls.Add(this.btn_Guardar);
            this.tbl_Reporte.Controls.Add(this.txt_NameMenu);
            this.tbl_Reporte.Controls.Add(this.label3);
            this.tbl_Reporte.Controls.Add(this.txt_Nombre);
            this.tbl_Reporte.Controls.Add(this.label2);
            this.tbl_Reporte.Controls.Add(this.lbl_N_Reporte);
            this.tbl_Reporte.Controls.Add(this.btn_Limpiar);
            this.tbl_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Reporte.Location = new System.Drawing.Point(0, 0);
            this.tbl_Reporte.Name = "tbl_Reporte";
            this.tbl_Reporte.Size = new System.Drawing.Size(401, 323);
            this.tbl_Reporte.TabIndex = 6;
            this.tbl_Reporte.TabStop = false;
            this.tbl_Reporte.Text = "Datos";
            // 
            // txt_N_Reporte
            // 
            this.txt_N_Reporte.Location = new System.Drawing.Point(164, 139);
            this.txt_N_Reporte.Name = "txt_N_Reporte";
            this.txt_N_Reporte.ReadOnly = true;
            this.txt_N_Reporte.Size = new System.Drawing.Size(155, 20);
            this.txt_N_Reporte.TabIndex = 24;
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
            this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(73, 273);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
            this.btn_Guardar.TabIndex = 22;
            this.btn_Guardar.Text = "Grabar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // txt_NameMenu
            // 
            this.txt_NameMenu.Location = new System.Drawing.Point(164, 166);
            this.txt_NameMenu.MaxLength = 50;
            this.txt_NameMenu.Name = "txt_NameMenu";
            this.txt_NameMenu.Size = new System.Drawing.Size(155, 20);
            this.txt_NameMenu.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "NameMenu";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(164, 112);
            this.txt_Nombre.MaxLength = 100;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(155, 20);
            this.txt_Nombre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // lbl_N_Reporte
            // 
            this.lbl_N_Reporte.AutoSize = true;
            this.lbl_N_Reporte.Location = new System.Drawing.Point(69, 144);
            this.lbl_N_Reporte.Name = "lbl_N_Reporte";
            this.lbl_N_Reporte.Size = new System.Drawing.Size(59, 13);
            this.lbl_N_Reporte.TabIndex = 14;
            this.lbl_N_Reporte.Text = "N_Reporte";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(234, 273);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(85, 40);
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frmMantenedorReporte
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
            this.Name = "frmMantenedorReporte";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Reporte";
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
            this.tbl_Reporte.ResumeLayout(false);
            this.tbl_Reporte.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpxListado;
        private System.Windows.Forms.GroupBox tbl_Reporte;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContexto;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator tsmSep3;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignarPermiso;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox txt_NameMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_N_Reporte;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.TextBox txt_N_Reporte;
    }
}