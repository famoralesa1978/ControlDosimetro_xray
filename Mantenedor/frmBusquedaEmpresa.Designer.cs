namespace ControlDosimetro
{
    partial class frmBusquedaEmpresa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaEmpresa));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_NombreFantasia = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Direccion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_cargarCliente = new System.Windows.Forms.Button();
			this.txt_N_Cliente_Ref = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbx_Estado = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_RazonSocial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Rut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAgregarCliente = new System.Windows.Forms.ToolStripButton();
			this.tsbAgregarReferencia = new System.Windows.Forms.ToolStripButton();
			this.tsbAgregarPersonal = new System.Windows.Forms.ToolStripButton();
			this.tsbIngresoDosimetro = new System.Windows.Forms.ToolStripButton();
			this.btnIngresarDosisISP = new System.Windows.Forms.ToolStripButton();
			this.N_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNombrefantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.cmsPopup.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_NombreFantasia);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_Direccion);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btn_cargarCliente);
			this.groupBox1.Controls.Add(this.txt_N_Cliente_Ref);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbx_Estado);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txt_RazonSocial);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_Rut);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 34);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(1132, 175);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda Cliente";
			// 
			// txt_NombreFantasia
			// 
			this.txt_NombreFantasia.Location = new System.Drawing.Point(131, 80);
			this.txt_NombreFantasia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_NombreFantasia.MaxLength = 60;
			this.txt_NombreFantasia.Name = "txt_NombreFantasia";
			this.txt_NombreFantasia.Size = new System.Drawing.Size(455, 22);
			this.txt_NombreFantasia.TabIndex = 38;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 80);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 17);
			this.label5.TabIndex = 39;
			this.label5.Text = "Nombre fantasia";
			// 
			// txt_Direccion
			// 
			this.txt_Direccion.Location = new System.Drawing.Point(131, 108);
			this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_Direccion.MaxLength = 60;
			this.txt_Direccion.Name = "txt_Direccion";
			this.txt_Direccion.Size = new System.Drawing.Size(455, 22);
			this.txt_Direccion.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 17);
			this.label4.TabIndex = 37;
			this.label4.Text = "Dirección";
			// 
			// btn_cargarCliente
			// 
			this.btn_cargarCliente.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btn_cargarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cargarCliente.Location = new System.Drawing.Point(613, 124);
			this.btn_cargarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_cargarCliente.Name = "btn_cargarCliente";
			this.btn_cargarCliente.Size = new System.Drawing.Size(148, 49);
			this.btn_cargarCliente.TabIndex = 35;
			this.btn_cargarCliente.Text = "Busqueda";
			this.btn_cargarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cargarCliente.UseVisualStyleBackColor = true;
			this.btn_cargarCliente.Click += new System.EventHandler(this.btn_Buscar_Click);
			// 
			// txt_N_Cliente_Ref
			// 
			this.txt_N_Cliente_Ref.Location = new System.Drawing.Point(131, 21);
			this.txt_N_Cliente_Ref.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_N_Cliente_Ref.Name = "txt_N_Cliente_Ref";
			this.txt_N_Cliente_Ref.Size = new System.Drawing.Size(132, 22);
			this.txt_N_Cliente_Ref.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 25);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 17);
			this.label2.TabIndex = 34;
			this.label2.Text = "N° Cliente";
			// 
			// cbx_Estado
			// 
			this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Estado.FormattingEnabled = true;
			this.cbx_Estado.Location = new System.Drawing.Point(131, 138);
			this.cbx_Estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbx_Estado.Name = "cbx_Estado";
			this.cbx_Estado.Size = new System.Drawing.Size(160, 24);
			this.cbx_Estado.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(16, 142);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 17);
			this.label11.TabIndex = 31;
			this.label11.Text = "Estado";
			// 
			// txt_RazonSocial
			// 
			this.txt_RazonSocial.Location = new System.Drawing.Point(131, 50);
			this.txt_RazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_RazonSocial.MaxLength = 60;
			this.txt_RazonSocial.Name = "txt_RazonSocial";
			this.txt_RazonSocial.Size = new System.Drawing.Size(455, 22);
			this.txt_RazonSocial.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Razon Social";
			// 
			// txt_Rut
			// 
			this.txt_Rut.Location = new System.Drawing.Point(405, 23);
			this.txt_Rut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_Rut.MaxLength = 10;
			this.txt_Rut.Name = "txt_Rut";
			this.txt_Rut.Size = new System.Drawing.Size(132, 22);
			this.txt_Rut.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(303, 27);
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
			this.groupBox2.Location = new System.Drawing.Point(7, 217);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(1284, 438);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
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
            this.N_Cliente,
            this.Rut,
            this.Razon_Social,
            this.colNombrefantasia,
            this.Direccion,
            this.Telefono});
			this.grdDatos.ContextMenuStrip = this.cmsPopup;
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(4, 19);
			this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDatos.Size = new System.Drawing.Size(1276, 415);
			this.grdDatos.TabIndex = 7;
			this.grdDatos.DoubleClick += new System.EventHandler(this.grdDatos_DoubleClick);
			// 
			// cmsPopup
			// 
			this.cmsPopup.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminar});
			this.cmsPopup.Name = "contextMenuStrip1";
			this.cmsPopup.Size = new System.Drawing.Size(133, 28);
			// 
			// tsmEliminar
			// 
			this.tsmEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsmEliminar.Name = "tsmEliminar";
			this.tsmEliminar.Size = new System.Drawing.Size(132, 24);
			this.tsmEliminar.Text = "Eliminar";
			this.tsmEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarCliente,
            this.tsbAgregarReferencia,
            this.tsbAgregarPersonal,
            this.tsbIngresoDosimetro,
            this.btnIngresarDosisISP});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1306, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAgregarCliente
			// 
			this.tsbAgregarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregarCliente.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.tsbAgregarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregarCliente.Name = "tsbAgregarCliente";
			this.tsbAgregarCliente.Size = new System.Drawing.Size(24, 24);
			this.tsbAgregarCliente.Text = "toolStripButton1";
			this.tsbAgregarCliente.ToolTipText = "Agregar Cliente";
			this.tsbAgregarCliente.Click += new System.EventHandler(this.btn_Agregar_Click);
			// 
			// tsbAgregarReferencia
			// 
			this.tsbAgregarReferencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregarReferencia.Image = global::ControlDosimetro.Properties.Resources.REFERENCIA;
			this.tsbAgregarReferencia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregarReferencia.Name = "tsbAgregarReferencia";
			this.tsbAgregarReferencia.Size = new System.Drawing.Size(24, 24);
			this.tsbAgregarReferencia.ToolTipText = "Referencia";
			this.tsbAgregarReferencia.Click += new System.EventHandler(this.tsbAgregarReferencia_Click);
			// 
			// tsbAgregarPersonal
			// 
			this.tsbAgregarPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregarPersonal.Image = global::ControlDosimetro.Properties.Resources.Personal;
			this.tsbAgregarPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregarPersonal.Name = "tsbAgregarPersonal";
			this.tsbAgregarPersonal.Size = new System.Drawing.Size(24, 24);
			this.tsbAgregarPersonal.Text = "toolStripButton1";
			this.tsbAgregarPersonal.ToolTipText = "Personal";
			this.tsbAgregarPersonal.Click += new System.EventHandler(this.tsbAgregarPersonal_Click);
			// 
			// tsbIngresoDosimetro
			// 
			this.tsbIngresoDosimetro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbIngresoDosimetro.Image = global::ControlDosimetro.Properties.Resources.Filmica;
			this.tsbIngresoDosimetro.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbIngresoDosimetro.Name = "tsbIngresoDosimetro";
			this.tsbIngresoDosimetro.Size = new System.Drawing.Size(24, 24);
			this.tsbIngresoDosimetro.Text = "toolStripButton1";
			this.tsbIngresoDosimetro.ToolTipText = "Ingresar Dosis";
			this.tsbIngresoDosimetro.Click += new System.EventHandler(this.tsbIngresoDosimetro_Click);
			// 
			// btnIngresarDosisISP
			// 
			this.btnIngresarDosisISP.BackColor = System.Drawing.Color.SkyBlue;
			this.btnIngresarDosisISP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnIngresarDosisISP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnIngresarDosisISP.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarDosisISP.Image")));
			this.btnIngresarDosisISP.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnIngresarDosisISP.Name = "btnIngresarDosisISP";
			this.btnIngresarDosisISP.Size = new System.Drawing.Size(73, 24);
			this.btnIngresarDosisISP.Text = "Dosis ISP";
			this.btnIngresarDosisISP.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.btnIngresarDosisISP.Click += new System.EventHandler(this.btnIngresarDosisISP_Click);
			// 
			// N_Cliente
			// 
			this.N_Cliente.DataPropertyName = "Id_Cliente";
			this.N_Cliente.Frozen = true;
			this.N_Cliente.HeaderText = "N°Cliente";
			this.N_Cliente.Name = "N_Cliente";
			this.N_Cliente.ReadOnly = true;
			this.N_Cliente.Width = 96;
			// 
			// Rut
			// 
			this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Rut.DataPropertyName = "Run";
			this.Rut.Frozen = true;
			this.Rut.HeaderText = "Rut";
			this.Rut.Name = "Rut";
			this.Rut.ReadOnly = true;
			this.Rut.Width = 59;
			// 
			// Razon_Social
			// 
			this.Razon_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Razon_Social.DataPropertyName = "Razon_Social";
			this.Razon_Social.Frozen = true;
			this.Razon_Social.HeaderText = "Razon Social";
			this.Razon_Social.Name = "Razon_Social";
			this.Razon_Social.ReadOnly = true;
			this.Razon_Social.Width = 380;
			// 
			// colNombrefantasia
			// 
			this.colNombrefantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.colNombrefantasia.DataPropertyName = "Nombre_Fantasia";
			this.colNombrefantasia.HeaderText = "Nombre fantasia";
			this.colNombrefantasia.Name = "colNombrefantasia";
			this.colNombrefantasia.ReadOnly = true;
			this.colNombrefantasia.Width = 400;
			// 
			// Direccion
			// 
			this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Direccion.DataPropertyName = "Direccion";
			this.Direccion.HeaderText = "Direccion";
			this.Direccion.Name = "Direccion";
			this.Direccion.ReadOnly = true;
			this.Direccion.Width = 96;
			// 
			// Telefono
			// 
			this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Telefono.DataPropertyName = "Telefono";
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.MinimumWidth = 80;
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			this.Telefono.Width = 93;
			// 
			// frmBusquedaEmpresa
			// 
			this.AcceptButton = this.btn_cargarCliente;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1306, 655);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1029, 560);
			this.Name = "frmBusquedaEmpresa";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Busqueda Cliente";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.cmsPopup.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton tsbAgregarReferencia;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.Label label11;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.TextBox txt_N_Cliente_Ref;
								private System.Windows.Forms.ToolStripButton tsbAgregarPersonal;
								private System.Windows.Forms.ToolStripButton tsbIngresoDosimetro;
                                private System.Windows.Forms.ToolStripButton btnIngresarDosisISP;
                                private System.Windows.Forms.ContextMenuStrip cmsPopup;
                                private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
                                private System.Windows.Forms.Button btn_cargarCliente;
                                private System.Windows.Forms.ToolStripButton tsbAgregarCliente;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NombreFantasia;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNombrefantasia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
	}
}