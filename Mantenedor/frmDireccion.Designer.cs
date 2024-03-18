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
			this.colSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColRazon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Colrunsuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colregion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colcomuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Colestado_casa_matriz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColOpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColOPR_RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.grpFiltro = new System.Windows.Forms.GroupBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.btn_cargarCliente = new System.Windows.Forms.Button();
			this.txt_cliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_RazonSocial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Rut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
            this.colIdCliente,
            this.colRut,
            this.ColRazon_Social,
            this.Colrunsuc,
            this.colDireccion,
            this.colregion,
            this.colProvincia,
            this.colcomuna,
            this.ColTelefono,
            this.Colestado_casa_matriz,
            this.ColEmail,
            this.ColDirector,
            this.ColOpr,
            this.ColOPR_RUT,
            this.ColServicio,
            this.colEstado});
			this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgPrincipal.Location = new System.Drawing.Point(0, 172);
			this.dtgPrincipal.Name = "dtgPrincipal";
			this.dtgPrincipal.Size = new System.Drawing.Size(1406, 256);
			this.dtgPrincipal.TabIndex = 5;
			this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
			this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
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
			// colIdCliente
			// 
			this.colIdCliente.DataPropertyName = "id_cliente";
			this.colIdCliente.HeaderText = "N° Cliente";
			this.colIdCliente.Name = "colIdCliente";
			this.colIdCliente.ToolTipText = "Número Cliente";
			this.colIdCliente.Width = 80;
			// 
			// colRut
			// 
			this.colRut.DataPropertyName = "run";
			this.colRut.HeaderText = "Rut";
			this.colRut.MaxInputLength = 11;
			this.colRut.Name = "colRut";
			// 
			// ColRazon_Social
			// 
			this.ColRazon_Social.DataPropertyName = "Razon_Social";
			this.ColRazon_Social.HeaderText = "Razon  social";
			this.ColRazon_Social.MaxInputLength = 100;
			this.ColRazon_Social.Name = "ColRazon_Social";
			this.ColRazon_Social.Width = 150;
			// 
			// Colrunsuc
			// 
			this.Colrunsuc.DataPropertyName = "runsuc";
			this.Colrunsuc.HeaderText = "Rut suc.";
			this.Colrunsuc.MaxInputLength = 100;
			this.Colrunsuc.Name = "Colrunsuc";
			this.Colrunsuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Colrunsuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Colrunsuc.ToolTipText = "Rut sucursal";
			this.Colrunsuc.Width = 180;
			// 
			// colDireccion
			// 
			this.colDireccion.DataPropertyName = "Direccion";
			this.colDireccion.HeaderText = "Dirección";
			this.colDireccion.MaxInputLength = 100;
			this.colDireccion.Name = "colDireccion";
			this.colDireccion.Width = 150;
			// 
			// colregion
			// 
			this.colregion.DataPropertyName = "region";
			this.colregion.HeaderText = "Región";
			this.colregion.MaxInputLength = 200;
			this.colregion.Name = "colregion";
			this.colregion.Width = 200;
			// 
			// colProvincia
			// 
			this.colProvincia.DataPropertyName = "provincia";
			this.colProvincia.HeaderText = "Provincia";
			this.colProvincia.MaxInputLength = 30;
			this.colProvincia.Name = "colProvincia";
			// 
			// colcomuna
			// 
			this.colcomuna.DataPropertyName = "comuna";
			this.colcomuna.HeaderText = "Comuna";
			this.colcomuna.MaxInputLength = 10;
			this.colcomuna.Name = "colcomuna";
			this.colcomuna.Width = 150;
			// 
			// ColTelefono
			// 
			this.ColTelefono.DataPropertyName = "Telefono";
			this.ColTelefono.HeaderText = "Teléfono";
			this.ColTelefono.Name = "ColTelefono";
			// 
			// Colestado_casa_matriz
			// 
			this.Colestado_casa_matriz.DataPropertyName = "estado_casa_matriz";
			this.Colestado_casa_matriz.HeaderText = "Casa matriz";
			this.Colestado_casa_matriz.Name = "Colestado_casa_matriz";
			// 
			// ColEmail
			// 
			this.ColEmail.DataPropertyName = "Email";
			this.ColEmail.HeaderText = "Email";
			this.ColEmail.Name = "ColEmail";
			// 
			// ColDirector
			// 
			this.ColDirector.DataPropertyName = "Director";
			this.ColDirector.HeaderText = "Director";
			this.ColDirector.Name = "ColDirector";
			// 
			// ColOpr
			// 
			this.ColOpr.DataPropertyName = "Opr";
			this.ColOpr.HeaderText = "Opr";
			this.ColOpr.Name = "ColOpr";
			// 
			// ColOPR_RUT
			// 
			this.ColOPR_RUT.DataPropertyName = "OPR_RUT";
			this.ColOPR_RUT.HeaderText = "OPR Rut";
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
			// grpFiltro
			// 
			this.grpFiltro.Controls.Add(this.btnLimpiar);
			this.grpFiltro.Controls.Add(this.btnFiltrar);
			this.grpFiltro.Controls.Add(this.btn_cargarCliente);
			this.grpFiltro.Controls.Add(this.txt_cliente);
			this.grpFiltro.Controls.Add(this.label2);
			this.grpFiltro.Controls.Add(this.txt_RazonSocial);
			this.grpFiltro.Controls.Add(this.label3);
			this.grpFiltro.Controls.Add(this.txt_Rut);
			this.grpFiltro.Controls.Add(this.label1);
			this.grpFiltro.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpFiltro.Location = new System.Drawing.Point(0, 39);
			this.grpFiltro.Name = "grpFiltro";
			this.grpFiltro.Size = new System.Drawing.Size(1406, 133);
			this.grpFiltro.TabIndex = 6;
			this.grpFiltro.TabStop = false;
			this.grpFiltro.Text = "Dato cliente";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(139, 97);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(101, 23);
			this.btnLimpiar.TabIndex = 43;
			this.btnLimpiar.Text = "Limpiar filtro";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Location = new System.Drawing.Point(14, 97);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(101, 23);
			this.btnFiltrar.TabIndex = 42;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = true;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// btn_cargarCliente
			// 
			this.btn_cargarCliente.Location = new System.Drawing.Point(199, 19);
			this.btn_cargarCliente.Name = "btn_cargarCliente";
			this.btn_cargarCliente.Size = new System.Drawing.Size(101, 23);
			this.btn_cargarCliente.TabIndex = 38;
			this.btn_cargarCliente.Text = "Cargar Cliente";
			this.btn_cargarCliente.UseVisualStyleBackColor = true;
			this.btn_cargarCliente.Click += new System.EventHandler(this.btn_cargarCliente_Click);
			// 
			// txt_cliente
			// 
			this.txt_cliente.Location = new System.Drawing.Point(93, 19);
			this.txt_cliente.MaxLength = 4;
			this.txt_cliente.Name = "txt_cliente";
			this.txt_cliente.Size = new System.Drawing.Size(100, 20);
			this.txt_cliente.TabIndex = 36;
			this.txt_cliente.Validating += new System.ComponentModel.CancelEventHandler(this.txt_cliente_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 41;
			this.label2.Text = "N°  Cliente";
			// 
			// txt_RazonSocial
			// 
			this.txt_RazonSocial.Location = new System.Drawing.Point(93, 71);
			this.txt_RazonSocial.MaxLength = 60;
			this.txt_RazonSocial.Name = "txt_RazonSocial";
			this.txt_RazonSocial.ReadOnly = true;
			this.txt_RazonSocial.Size = new System.Drawing.Size(342, 20);
			this.txt_RazonSocial.TabIndex = 39;
			this.txt_RazonSocial.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 40;
			this.label3.Text = "Razon Social";
			// 
			// txt_Rut
			// 
			this.txt_Rut.Location = new System.Drawing.Point(93, 46);
			this.txt_Rut.MaxLength = 10;
			this.txt_Rut.Name = "txt_Rut";
			this.txt_Rut.Size = new System.Drawing.Size(100, 20);
			this.txt_Rut.TabIndex = 37;
			this.txt_Rut.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Rut_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Rut";
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
		private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRut;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColRazon_Social;
		private System.Windows.Forms.DataGridViewTextBoxColumn Colrunsuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colregion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProvincia;
		private System.Windows.Forms.DataGridViewTextBoxColumn colcomuna;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Colestado_casa_matriz;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDirector;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColOpr;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColOPR_RUT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColServicio;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
		private System.Windows.Forms.GroupBox grpFiltro;
		private System.Windows.Forms.Button btn_cargarCliente;
		private System.Windows.Forms.TextBox txt_cliente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_RazonSocial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Rut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Button btnLimpiar;
	}
}