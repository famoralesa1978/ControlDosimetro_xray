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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Filtro = new System.Windows.Forms.Button();
            this.btn_cargarCliente = new System.Windows.Forms.Button();
            this.txt_ref_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Rut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColServicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColSeccion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1132, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dato Cliente";
            // 
            // btn_Filtro
            // 
            this.btn_Filtro.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
            this.btn_Filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filtro.Location = new System.Drawing.Point(449, 22);
            this.btn_Filtro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Filtro.Name = "btn_Filtro";
            this.btn_Filtro.Size = new System.Drawing.Size(163, 48);
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
            this.btn_cargarCliente.Location = new System.Drawing.Point(293, 21);
            this.btn_cargarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cargarCliente.Name = "btn_cargarCliente";
            this.btn_cargarCliente.Size = new System.Drawing.Size(148, 49);
            this.btn_cargarCliente.TabIndex = 3;
            this.btn_cargarCliente.Text = "Cargar";
            this.btn_cargarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cargarCliente.UseVisualStyleBackColor = true;
            this.btn_cargarCliente.Click += new System.EventHandler(this.btn_cargarCliente_Click);
            // 
            // txt_ref_cliente
            // 
            this.txt_ref_cliente.Location = new System.Drawing.Point(127, 21);
            this.txt_ref_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ref_cliente.MaxLength = 4;
            this.txt_ref_cliente.Name = "txt_ref_cliente";
            this.txt_ref_cliente.Size = new System.Drawing.Size(132, 22);
            this.txt_ref_cliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "N°  Cliente";
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.Location = new System.Drawing.Point(127, 85);
            this.txt_RazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RazonSocial.MaxLength = 60;
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.ReadOnly = true;
            this.txt_RazonSocial.Size = new System.Drawing.Size(455, 22);
            this.txt_RazonSocial.TabIndex = 3;
            this.txt_RazonSocial.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razon Social";
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(127, 54);
            this.txt_Rut.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rut.MaxLength = 10;
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.ReadOnly = true;
            this.txt_Rut.Size = new System.Drawing.Size(132, 22);
            this.txt_Rut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grdDatos);
            this.groupBox2.Location = new System.Drawing.Point(7, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1123, 481);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Personal,
            this.Rut,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.ColServicio,
            this.ColSeccion});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(4, 19);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDatos.Size = new System.Drawing.Size(1115, 458);
            this.grdDatos.TabIndex = 5;
            this.grdDatos.VirtualMode = true;
            this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
            this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
            // 
            // Id_Personal
            // 
            this.Id_Personal.DataPropertyName = "Id_Personal";
            this.Id_Personal.Frozen = true;
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
            this.Rut.Width = 59;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 94;
            // 
            // Paterno
            // 
            this.Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Paterno.DataPropertyName = "Paterno";
            this.Paterno.FillWeight = 300F;
            this.Paterno.HeaderText = "Paterno";
            this.Paterno.Name = "Paterno";
            this.Paterno.ReadOnly = true;
            this.Paterno.Width = 87;
            // 
            // Maternos
            // 
            this.Maternos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Maternos.DataPropertyName = "Maternos";
            this.Maternos.HeaderText = "Maternos";
            this.Maternos.MinimumWidth = 150;
            this.Maternos.Name = "Maternos";
            this.Maternos.ReadOnly = true;
            this.Maternos.Width = 150;
            // 
            // ColServicio
            // 
            this.ColServicio.DataPropertyName = "Id_CodServicio";
            this.ColServicio.HeaderText = "Servicio";
            this.ColServicio.Name = "ColServicio";
            this.ColServicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColServicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColServicio.Width = 110;
            // 
            // ColSeccion
            // 
            this.ColSeccion.DataPropertyName = "Id_Seccion";
            this.ColSeccion.HeaderText = "Sección";
            this.ColSeccion.Name = "ColSeccion";
            this.ColSeccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1145, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.Save_24;
            this.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(28, 28);
            this.tsbGuardar.Text = "toolStripButton1";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // frmModificarPersonalMasivo
            // 
            this.AcceptButton = this.btn_cargarCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 655);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1029, 558);
            this.Name = "frmModificarPersonalMasivo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar personal masivo";
            this.Load += new System.EventHandler(this.frmModificarPersonalMasivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Rut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
		  private System.Windows.Forms.ToolStrip toolStrip1;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.TextBox txt_ref_cliente;
								private System.Windows.Forms.Button btn_cargarCliente;
                                private System.Windows.Forms.Button btn_Filtro;
		private System.Windows.Forms.ToolStripButton tsbGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColSeccion;
	}
}