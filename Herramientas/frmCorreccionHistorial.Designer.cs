namespace ControlDosimetro
{
    partial class frmCorreccionHistorial
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.grpDatosCliente = new System.Windows.Forms.GroupBox();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.integerGridColumn1 = new GridExtension.IntegerGridColumn();
			this.integerGridColumn2 = new GridExtension.IntegerGridColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fdgLetra = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_EliminarSeleccion = new System.Windows.Forms.ToolStripMenuItem();
			this.grpPrincipal = new System.Windows.Forms.GroupBox();
			this.grpHistorial = new System.Windows.Forms.GroupBox();
			this.dtgHistorial = new System.Windows.Forms.DataGridView();
			this.grpCliente = new System.Windows.Forms.GroupBox();
			this.grdCliente = new System.Windows.Forms.DataGridView();
			this.btnGrabarAgregarHistorial = new System.Windows.Forms.Button();
			this.grpDatosCliente.SuspendLayout();
			this.cmsPopup.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.grpPrincipal.SuspendLayout();
			this.grpHistorial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
			this.grpCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// grpDatosCliente
			// 
			this.grpDatosCliente.Controls.Add(this.btn_filtro);
			this.grpDatosCliente.Controls.Add(this.lbl_id_cliente);
			this.grpDatosCliente.Controls.Add(this.btn_cargar);
			this.grpDatosCliente.Controls.Add(this.label2);
			this.grpDatosCliente.Location = new System.Drawing.Point(5, 28);
			this.grpDatosCliente.Name = "grpDatosCliente";
			this.grpDatosCliente.Size = new System.Drawing.Size(432, 58);
			this.grpDatosCliente.TabIndex = 1;
			this.grpDatosCliente.TabStop = false;
			this.grpDatosCliente.Text = "Dato Cliente";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(264, 20);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 45;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.Btn_filtro_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(87, 19);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 1;
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(169, 17);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 2;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.Btn_cargar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// cmsPopup
			// 
			this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminar});
			this.cmsPopup.Name = "contextMenuStrip1";
			this.cmsPopup.Size = new System.Drawing.Size(68, 26);
			// 
			// tsmEliminar
			// 
			this.tsmEliminar.Name = "tsmEliminar";
			this.tsmEliminar.Size = new System.Drawing.Size(67, 22);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(819, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Personal";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id_Personal";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 88;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_dosimetro";
			this.dataGridViewTextBoxColumn2.HeaderText = "Id_dosimetro";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Visible = false;
			this.dataGridViewTextBoxColumn2.Width = 92;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Cliente";
			this.dataGridViewTextBoxColumn3.HeaderText = "N° Cliente";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.Width = 79;
			// 
			// integerGridColumn1
			// 
			this.integerGridColumn1.DataPropertyName = "N_Documento";
			this.integerGridColumn1.HeaderText = "N° Documento";
			this.integerGridColumn1.Name = "integerGridColumn1";
			this.integerGridColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.integerGridColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.integerGridColumn1.Width = 102;
			// 
			// integerGridColumn2
			// 
			this.integerGridColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.integerGridColumn2.DataPropertyName = "N_Pelicula";
			this.integerGridColumn2.HeaderText = "Nº Pelicula";
			this.integerGridColumn2.Name = "integerGridColumn2";
			this.integerGridColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.integerGridColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "N_Documento";
			this.dataGridViewTextBoxColumn4.HeaderText = "N° Documento";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "N_Pelicula";
			this.dataGridViewTextBoxColumn5.HeaderText = "Nº Pelicula";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Rut";
			this.dataGridViewTextBoxColumn6.FillWeight = 300F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Rut";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombres";
			this.dataGridViewTextBoxColumn7.HeaderText = "Nombres";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Paterno";
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn8.FillWeight = 300F;
			this.dataGridViewTextBoxColumn8.HeaderText = "Paterno";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Maternos";
			this.dataGridViewTextBoxColumn9.HeaderText = "Maternos";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "dosis";
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EliminarSeleccion});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
			// 
			// btn_EliminarSeleccion
			// 
			this.btn_EliminarSeleccion.Name = "btn_EliminarSeleccion";
			this.btn_EliminarSeleccion.Size = new System.Drawing.Size(67, 22);
			// 
			// grpPrincipal
			// 
			this.grpPrincipal.Controls.Add(this.grpHistorial);
			this.grpPrincipal.Controls.Add(this.grpCliente);
			this.grpPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpPrincipal.Location = new System.Drawing.Point(0, 103);
			this.grpPrincipal.Name = "grpPrincipal";
			this.grpPrincipal.Size = new System.Drawing.Size(819, 309);
			this.grpPrincipal.TabIndex = 3;
			this.grpPrincipal.TabStop = false;
			this.grpPrincipal.Text = "Datos a corregir";
			// 
			// grpHistorial
			// 
			this.grpHistorial.Controls.Add(this.dtgHistorial);
			this.grpHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpHistorial.Location = new System.Drawing.Point(3, 140);
			this.grpHistorial.Name = "grpHistorial";
			this.grpHistorial.Size = new System.Drawing.Size(813, 166);
			this.grpHistorial.TabIndex = 1;
			this.grpHistorial.TabStop = false;
			this.grpHistorial.Text = "Historial";
			// 
			// dtgHistorial
			// 
			this.dtgHistorial.AllowUserToAddRows = false;
			this.dtgHistorial.AllowUserToDeleteRows = false;
			this.dtgHistorial.AllowUserToResizeColumns = false;
			this.dtgHistorial.AllowUserToResizeRows = false;
			this.dtgHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dtgHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dtgHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgHistorial.Location = new System.Drawing.Point(3, 16);
			this.dtgHistorial.Name = "dtgHistorial";
			this.dtgHistorial.ReadOnly = true;
			this.dtgHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.dtgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dtgHistorial.Size = new System.Drawing.Size(807, 147);
			this.dtgHistorial.TabIndex = 10;
			this.dtgHistorial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgHistorial_KeyDown);
			// 
			// grpCliente
			// 
			this.grpCliente.Controls.Add(this.grdCliente);
			this.grpCliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpCliente.Location = new System.Drawing.Point(3, 16);
			this.grpCliente.Name = "grpCliente";
			this.grpCliente.Size = new System.Drawing.Size(813, 118);
			this.grpCliente.TabIndex = 0;
			this.grpCliente.TabStop = false;
			this.grpCliente.Text = "Cliente";
			// 
			// grdCliente
			// 
			this.grdCliente.AllowUserToAddRows = false;
			this.grdCliente.AllowUserToDeleteRows = false;
			this.grdCliente.AllowUserToResizeColumns = false;
			this.grdCliente.AllowUserToResizeRows = false;
			this.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdCliente.Location = new System.Drawing.Point(3, 16);
			this.grdCliente.Name = "grdCliente";
			this.grdCliente.ReadOnly = true;
			this.grdCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdCliente.Size = new System.Drawing.Size(807, 99);
			this.grdCliente.TabIndex = 9;
			// 
			// btnGrabarAgregarHistorial
			// 
			this.btnGrabarAgregarHistorial.Location = new System.Drawing.Point(473, 28);
			this.btnGrabarAgregarHistorial.Name = "btnGrabarAgregarHistorial";
			this.btnGrabarAgregarHistorial.Size = new System.Drawing.Size(166, 23);
			this.btnGrabarAgregarHistorial.TabIndex = 2;
			this.btnGrabarAgregarHistorial.Text = "Agregar cliente en el historial";
			this.btnGrabarAgregarHistorial.UseVisualStyleBackColor = true;
			this.btnGrabarAgregarHistorial.Click += new System.EventHandler(this.btnGrabarAgregarHistorial_Click);
			// 
			// frmCorreccionHistorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 412);
			this.Controls.Add(this.btnGrabarAgregarHistorial);
			this.Controls.Add(this.grpPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.grpDatosCliente);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCorreccionHistorial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Correccion de datos historial";
			this.grpDatosCliente.ResumeLayout(false);
			this.grpDatosCliente.PerformLayout();
			this.cmsPopup.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.grpPrincipal.ResumeLayout(false);
			this.grpHistorial.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
			this.grpCliente.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCliente;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button btn_cargar;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
                                private GridExtension.IntegerGridColumn integerGridColumn1;
                                private GridExtension.IntegerGridColumn integerGridColumn2;
                                private System.Windows.Forms.ContextMenuStrip cmsPopup;
                                private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.FontDialog fdgLetra;
                                private System.Windows.Forms.ColorDialog colorDialog1;
                                private System.Windows.Forms.OpenFileDialog openFileDialog1;
                                private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
                                private System.Windows.Forms.ToolStripMenuItem btn_EliminarSeleccion;
                                private System.Windows.Forms.GroupBox grpPrincipal;
                                private System.Windows.Forms.Button btn_filtro;
		private System.Windows.Forms.GroupBox grpHistorial;
		private System.Windows.Forms.GroupBox grpCliente;
		private System.Windows.Forms.DataGridView dtgHistorial;
		private System.Windows.Forms.DataGridView grdCliente;
		private System.Windows.Forms.Button btnGrabarAgregarHistorial;
	}
}