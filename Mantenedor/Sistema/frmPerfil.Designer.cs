namespace ControlDosimetro
{
	partial class frmPerfil
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
			this.dtgPrincipal = new System.Windows.Forms.DataGridView();
			this.colEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.toolStrip1.Size = new System.Drawing.Size(483, 39);
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
			// dtgPrincipal
			// 
			this.dtgPrincipal.AllowUserToAddRows = false;
			this.dtgPrincipal.AllowUserToDeleteRows = false;
			this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEliminar,
            this.colDescripcion,
            this.colEstado});
			this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgPrincipal.Location = new System.Drawing.Point(0, 39);
			this.dtgPrincipal.Name = "dtgPrincipal";
			this.dtgPrincipal.Size = new System.Drawing.Size(483, 389);
			this.dtgPrincipal.TabIndex = 3;
			this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
			this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
			this.dtgPrincipal.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_RowValidated);
			this.dtgPrincipal.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgPrincipal_RowValidating);
			// 
			// colEliminar
			// 
			this.colEliminar.DataPropertyName = "Eliminar";
			this.colEliminar.HeaderText = "Eliminar";
			this.colEliminar.Name = "colEliminar";
			this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colEliminar.Width = 60;
			// 
			// colDescripcion
			// 
			this.colDescripcion.DataPropertyName = "Descripcion";
			this.colDescripcion.HeaderText = "Descripción";
			this.colDescripcion.MaxInputLength = 100;
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.Width = 250;
			// 
			// colEstado
			// 
			this.colEstado.DataPropertyName = "Estado";
			this.colEstado.HeaderText = "Estado";
			this.colEstado.Name = "colEstado";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(483, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
			this.dataGridViewTextBoxColumn1.HeaderText = "Descripción";
			this.dataGridViewTextBoxColumn1.MaxInputLength = 100;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 250;
			// 
			// frmPerfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 450);
			this.Controls.Add(this.dtgPrincipal);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmPerfil";
			this.Text = "Perfil";
			this.Load += new System.EventHandler(this.frmPerfil_Load);
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
		private System.Windows.Forms.DataGridView dtgPrincipal;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
		private System.Windows.Forms.ToolStripButton tsbRefrescar;
	}
}