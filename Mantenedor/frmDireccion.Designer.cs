namespace ControlDosimetro
{
	partial class frmDireccion
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
			this.tsbModificar = new System.Windows.Forms.ToolStripButton();
			this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
			this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
			this.tsbSeparador = new System.Windows.Forms.ToolStripSeparator();
			this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgPrincipal = new System.Windows.Forms.DataGridView();
			this.grpFiltro = new System.Windows.Forms.GroupBox();
			this.btn_Filtro = new System.Windows.Forms.Button();
			this.btn_cargarCliente = new System.Windows.Forms.Button();
			this.txtNCliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCargar = new System.Windows.Forms.Button();
			this.colSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColComuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColEstado_casa_matriz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColOpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColOPR_RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
			this.grpFiltro.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbRefrescar,
            this.tsbSeparador,
            this.tsbGuardar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1406, 39);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAgregar
			// 
			this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAgregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.tsbAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAgregar.Name = "tsbAgregar";
			this.tsbAgregar.Size = new System.Drawing.Size(36, 36);
			this.tsbAgregar.Text = "Agregar registro";
			this.tsbAgregar.ToolTipText = "Agregar registro";
			this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
			// 
			// tsbModificar
			// 
			this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbModificar.Image = global::ControlDosimetro.Properties.Resources.Modificar;
			this.tsbModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbModificar.Name = "tsbModificar";
			this.tsbModificar.Size = new System.Drawing.Size(36, 36);
			this.tsbModificar.Text = "Modificar registro";
			this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.tsbModificar.ToolTipText = "Modificar registro";
			this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
			// 
			// tsbEliminar
			// 
			this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEliminar.Image = global::ControlDosimetro.Properties.Resources.Delete1;
			this.tsbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEliminar.Name = "tsbEliminar";
			this.tsbEliminar.Size = new System.Drawing.Size(36, 36);
			this.tsbEliminar.Text = "Eliminar registro";
			this.tsbEliminar.ToolTipText = "Eliminar registro";
			this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
			// 
			// tsbRefrescar
			// 
			this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbRefrescar.Image = global::ControlDosimetro.Properties.Resources.Refrescar__2_;
			this.tsbRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRefrescar.Name = "tsbRefrescar";
			this.tsbRefrescar.Size = new System.Drawing.Size(28, 36);
			this.tsbRefrescar.Text = "Refrescar los datos";
			this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
			// 
			// tsbSeparador
			// 
			this.tsbSeparador.Name = "tsbSeparador";
			this.tsbSeparador.Size = new System.Drawing.Size(6, 39);
			// 
			// tsbGuardar
			// 
			this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.Guardar;
			this.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbGuardar.Name = "tsbGuardar";
			this.tsbGuardar.Size = new System.Drawing.Size(36, 36);
			this.tsbGuardar.Text = "toolStripButton1";
			this.tsbGuardar.ToolTipText = "Guarda la infomación";
			this.tsbGuardar.Visible = false;
			this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1406, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dtgPrincipal
			// 
			this.dtgPrincipal.AllowUserToAddRows = false;
			this.dtgPrincipal.AllowUserToDeleteRows = false;
			this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeleccionar,
            this.colRut,
            this.ColNombre,
            this.ColDirección,
            this.colRegion,
            this.ColProvincia,
            this.ColComuna,
            this.ColTelefono,
            this.ColEstado_casa_matriz,
            this.colEmail,
            this.ColDirector,
            this.ColOpr,
            this.ColOPR_RUT,
            this.ColServicio,
            this.colEstado});
			this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgPrincipal.Location = new System.Drawing.Point(0, 174);
			this.dtgPrincipal.Name = "dtgPrincipal";
			this.dtgPrincipal.Size = new System.Drawing.Size(1406, 254);
			this.dtgPrincipal.TabIndex = 5;
			this.dtgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellDoubleClick);
			this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
			// 
			// grpFiltro
			// 
			this.grpFiltro.Controls.Add(this.btnCargar);
			this.grpFiltro.Controls.Add(this.btn_Filtro);
			this.grpFiltro.Controls.Add(this.btn_cargarCliente);
			this.grpFiltro.Controls.Add(this.txtNCliente);
			this.grpFiltro.Controls.Add(this.label2);
			this.grpFiltro.Controls.Add(this.txtRazonSocial);
			this.grpFiltro.Controls.Add(this.label3);
			this.grpFiltro.Controls.Add(this.txtRut);
			this.grpFiltro.Controls.Add(this.label1);
			this.grpFiltro.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpFiltro.Location = new System.Drawing.Point(0, 39);
			this.grpFiltro.Name = "grpFiltro";
			this.grpFiltro.Size = new System.Drawing.Size(1406, 135);
			this.grpFiltro.TabIndex = 6;
			this.grpFiltro.TabStop = false;
			this.grpFiltro.Text = "Filtro";
			// 
			// btn_Filtro
			// 
			this.btn_Filtro.Location = new System.Drawing.Point(334, 17);
			this.btn_Filtro.Name = "btn_Filtro";
			this.btn_Filtro.Size = new System.Drawing.Size(75, 23);
			this.btn_Filtro.TabIndex = 44;
			this.btn_Filtro.Text = "Limpiar Filtro";
			this.btn_Filtro.UseVisualStyleBackColor = true;
			this.btn_Filtro.Click += new System.EventHandler(this.btn_Filtro_Click);
			// 
			// btn_cargarCliente
			// 
			this.btn_cargarCliente.Location = new System.Drawing.Point(217, 17);
			this.btn_cargarCliente.Name = "btn_cargarCliente";
			this.btn_cargarCliente.Size = new System.Drawing.Size(101, 23);
			this.btn_cargarCliente.TabIndex = 39;
			this.btn_cargarCliente.Text = "Cargar Cliente";
			this.btn_cargarCliente.UseVisualStyleBackColor = true;
			this.btn_cargarCliente.Click += new System.EventHandler(this.btn_cargarCliente_Click);
			// 
			// txtNCliente
			// 
			this.txtNCliente.Location = new System.Drawing.Point(102, 19);
			this.txtNCliente.MaxLength = 4;
			this.txtNCliente.Name = "txtNCliente";
			this.txtNCliente.Size = new System.Drawing.Size(100, 20);
			this.txtNCliente.TabIndex = 37;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 43;
			this.label2.Text = "N°  Cliente";
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(102, 71);
			this.txtRazonSocial.MaxLength = 60;
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.ReadOnly = true;
			this.txtRazonSocial.Size = new System.Drawing.Size(342, 20);
			this.txtRazonSocial.TabIndex = 40;
			this.txtRazonSocial.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "Razon Social";
			// 
			// txtRut
			// 
			this.txtRut.Location = new System.Drawing.Point(102, 46);
			this.txtRut.MaxLength = 10;
			this.txtRut.Name = "txtRut";
			this.txtRut.ReadOnly = true;
			this.txtRut.Size = new System.Drawing.Size(100, 20);
			this.txtRut.TabIndex = 38;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Rut";
			// 
			// btnCargar
			// 
			this.btnCargar.Location = new System.Drawing.Point(22, 106);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(75, 23);
			this.btnCargar.TabIndex = 45;
			this.btnCargar.Text = "Cargar";
			this.btnCargar.UseVisualStyleBackColor = true;
			this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
			// 
			// colSeleccionar
			// 
			this.colSeleccionar.DataPropertyName = "Seleccionar";
			this.colSeleccionar.HeaderText = "Seleccionar";
			this.colSeleccionar.Name = "colSeleccionar";
			this.colSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colSeleccionar.ToolTipText = "Eliminar registro";
			this.colSeleccionar.Width = 70;
			// 
			// colRut
			// 
			this.colRut.DataPropertyName = "runsuc";
			this.colRut.HeaderText = "Rut";
			this.colRut.MaxInputLength = 10;
			this.colRut.Name = "colRut";
			// 
			// ColNombre
			// 
			this.ColNombre.DataPropertyName = "Razon_Social";
			this.ColNombre.HeaderText = "Razón social";
			this.ColNombre.MaxInputLength = 200;
			this.ColNombre.Name = "ColNombre";
			this.ColNombre.Width = 200;
			// 
			// ColDirección
			// 
			this.ColDirección.DataPropertyName = "Direccion";
			this.ColDirección.HeaderText = "Dirección";
			this.ColDirección.MaxInputLength = 100;
			this.ColDirección.Name = "ColDirección";
			this.ColDirección.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColDirección.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColDirección.Width = 200;
			// 
			// colRegion
			// 
			this.colRegion.DataPropertyName = "region";
			this.colRegion.HeaderText = "Región";
			this.colRegion.MaxInputLength = 100;
			this.colRegion.Name = "colRegion";
			this.colRegion.Width = 180;
			// 
			// ColProvincia
			// 
			this.ColProvincia.DataPropertyName = "provincia";
			this.ColProvincia.HeaderText = "Provincia";
			this.ColProvincia.Name = "ColProvincia";
			this.ColProvincia.Width = 150;
			// 
			// ColComuna
			// 
			this.ColComuna.DataPropertyName = "comuna";
			this.ColComuna.HeaderText = "Comuna";
			this.ColComuna.Name = "ColComuna";
			this.ColComuna.Width = 180;
			// 
			// ColTelefono
			// 
			this.ColTelefono.DataPropertyName = "Telefono";
			this.ColTelefono.HeaderText = "Telefono";
			this.ColTelefono.Name = "ColTelefono";
			// 
			// ColEstado_casa_matriz
			// 
			this.ColEstado_casa_matriz.DataPropertyName = "estado_casa_matriz";
			this.ColEstado_casa_matriz.HeaderText = "Casa matriz";
			this.ColEstado_casa_matriz.Name = "ColEstado_casa_matriz";
			this.ColEstado_casa_matriz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColEstado_casa_matriz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colEmail
			// 
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.MaxInputLength = 200;
			this.colEmail.Name = "colEmail";
			this.colEmail.Width = 200;
			// 
			// ColDirector
			// 
			this.ColDirector.DataPropertyName = "Director";
			this.ColDirector.HeaderText = "Director";
			this.ColDirector.Name = "ColDirector";
			this.ColDirector.Width = 180;
			// 
			// ColOpr
			// 
			this.ColOpr.DataPropertyName = "Opr";
			this.ColOpr.HeaderText = "Opr";
			this.ColOpr.Name = "ColOpr";
			this.ColOpr.Width = 150;
			// 
			// ColOPR_RUT
			// 
			this.ColOPR_RUT.DataPropertyName = "OPR_RUT";
			this.ColOPR_RUT.HeaderText = "Opr Rut";
			this.ColOPR_RUT.Name = "ColOPR_RUT";
			// 
			// ColServicio
			// 
			this.ColServicio.DataPropertyName = "Servicio";
			this.ColServicio.HeaderText = "Servicio";
			this.ColServicio.Name = "ColServicio";
			// 
			// colEstado
			// 
			this.colEstado.DataPropertyName = "Estado";
			this.colEstado.HeaderText = "Estado";
			this.colEstado.Name = "colEstado";
			this.colEstado.Width = 70;
			// 
			// frmDireccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1406, 450);
			this.Controls.Add(this.dtgPrincipal);
			this.Controls.Add(this.grpFiltro);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmDireccion";
			this.ShowInTaskbar = false;
			this.Text = "Dirección";
			this.Load += new System.EventHandler(this.frmDireccion_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
			this.grpFiltro.ResumeLayout(false);
			this.grpFiltro.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbAgregar;
		private System.Windows.Forms.ToolStripButton tsbModificar;
		private System.Windows.Forms.ToolStripButton tsbEliminar;
		private System.Windows.Forms.ToolStripSeparator tsbSeparador;
		private System.Windows.Forms.ToolStripButton tsbGuardar;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.ToolStripButton tsbRefrescar;
		private System.Windows.Forms.DataGridView dtgPrincipal;
		private System.Windows.Forms.GroupBox grpFiltro;
		private System.Windows.Forms.Button btn_Filtro;
		private System.Windows.Forms.Button btn_cargarCliente;
		private System.Windows.Forms.TextBox txtNCliente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRut;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDirección;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRegion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColProvincia;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColComuna;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColEstado_casa_matriz;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDirector;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColOpr;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColOPR_RUT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
	}
}