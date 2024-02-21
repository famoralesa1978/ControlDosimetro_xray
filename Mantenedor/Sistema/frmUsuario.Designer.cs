namespace ControlDosimetro
{
	partial class frmUsuario
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
			this.colRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colId_perfil = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
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
			this.tsbModificar.Visible = false;
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
            this.ColPaterno,
            this.colMaternos,
            this.colId_perfil,
            this.colEmail,
            this.colUsuario,
            this.colContraseña,
            this.colEstado});
			this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgPrincipal.Location = new System.Drawing.Point(0, 39);
			this.dtgPrincipal.Name = "dtgPrincipal";
			this.dtgPrincipal.Size = new System.Drawing.Size(1406, 389);
			this.dtgPrincipal.TabIndex = 5;
			this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
			this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
			this.dtgPrincipal.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_RowValidated);
			this.dtgPrincipal.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgPrincipal_RowValidating);
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
			this.colRut.DataPropertyName = "Rut";
			this.colRut.HeaderText = "Rut";
			this.colRut.MaxInputLength = 10;
			this.colRut.Name = "colRut";
			// 
			// ColNombre
			// 
			this.ColNombre.DataPropertyName = "Nombres";
			this.ColNombre.HeaderText = "Nombres";
			this.ColNombre.MaxInputLength = 100;
			this.ColNombre.Name = "ColNombre";
			this.ColNombre.Width = 150;
			// 
			// ColPaterno
			// 
			this.ColPaterno.DataPropertyName = "Paterno";
			this.ColPaterno.HeaderText = "Ap. Paterno";
			this.ColPaterno.MaxInputLength = 100;
			this.ColPaterno.Name = "ColPaterno";
			this.ColPaterno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColPaterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColPaterno.ToolTipText = "Apellido paterno";
			this.ColPaterno.Width = 180;
			// 
			// colMaternos
			// 
			this.colMaternos.DataPropertyName = "Maternos";
			this.colMaternos.HeaderText = "Ap. Maternos";
			this.colMaternos.MaxInputLength = 100;
			this.colMaternos.Name = "colMaternos";
			this.colMaternos.ToolTipText = "Apellido paterno";
			this.colMaternos.Width = 150;
			// 
			// colId_perfil
			// 
			this.colId_perfil.DataPropertyName = "Id_Perfil";
			this.colId_perfil.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colId_perfil.DisplayStyleForCurrentCellOnly = true;
			this.colId_perfil.HeaderText = "Perfil";
			this.colId_perfil.Name = "colId_perfil";
			this.colId_perfil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colId_perfil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colId_perfil.Width = 160;
			// 
			// colEmail
			// 
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.MaxInputLength = 200;
			this.colEmail.Name = "colEmail";
			this.colEmail.Width = 200;
			// 
			// colUsuario
			// 
			this.colUsuario.DataPropertyName = "Usuario";
			this.colUsuario.HeaderText = "Usuario";
			this.colUsuario.MaxInputLength = 30;
			this.colUsuario.Name = "colUsuario";
			// 
			// colContraseña
			// 
			this.colContraseña.DataPropertyName = "Contraseña";
			this.colContraseña.HeaderText = "Contraseña";
			this.colContraseña.MaxInputLength = 10;
			this.colContraseña.Name = "colContraseña";
			this.colContraseña.Width = 150;
			// 
			// colEstado
			// 
			this.colEstado.DataPropertyName = "Estado";
			this.colEstado.HeaderText = "Estado";
			this.colEstado.Name = "colEstado";
			this.colEstado.Width = 70;
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1406, 450);
			this.Controls.Add(this.dtgPrincipal);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmUsuario";
			this.Text = "Usuario";
			this.Load += new System.EventHandler(this.frmUsuario_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn colRut;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColPaterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaternos;
		private System.Windows.Forms.DataGridViewComboBoxColumn colId_perfil;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContraseña;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
	}
}