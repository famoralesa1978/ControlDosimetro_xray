namespace ControlDosimetro
{
    partial class frmDocumentoVerAprobar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCargar = new System.Windows.Forms.Button();
			this.txt_n_Cliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbx_Anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rbtSinAprobar = new System.Windows.Forms.RadioButton();
			this.rbtAprobado = new System.Windows.Forms.RadioButton();
			this.rbTodos = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
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
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.ColId_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.run = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.annomesperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDescTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColNombreArchivo = new System.Windows.Forms.DataGridViewLinkColumn();
			this.ColAprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCargar);
			this.groupBox1.Controls.Add(this.txt_n_Cliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbx_Anno);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rbtSinAprobar);
			this.groupBox1.Controls.Add(this.rbtAprobado);
			this.groupBox1.Controls.Add(this.rbTodos);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(462, 147);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar";
			// 
			// btnCargar
			// 
			this.btnCargar.Image = global::ControlDosimetro.Properties.Resources.filter_16;
			this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCargar.Location = new System.Drawing.Point(10, 107);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(75, 23);
			this.btnCargar.TabIndex = 14;
			this.btnCargar.Text = "Filtrar";
			this.btnCargar.UseVisualStyleBackColor = true;
			this.btnCargar.Click += new System.EventHandler(this.btn_cargar_Click);
			// 
			// txt_n_Cliente
			// 
			this.txt_n_Cliente.Location = new System.Drawing.Point(112, 42);
			this.txt_n_Cliente.Name = "txt_n_Cliente";
			this.txt_n_Cliente.Size = new System.Drawing.Size(84, 20);
			this.txt_n_Cliente.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "N° cliente";
			// 
			// cbx_Anno
			// 
			this.cbx_Anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Anno.FormattingEnabled = true;
			this.cbx_Anno.Location = new System.Drawing.Point(112, 13);
			this.cbx_Anno.Name = "cbx_Anno";
			this.cbx_Anno.Size = new System.Drawing.Size(84, 21);
			this.cbx_Anno.TabIndex = 11;
			this.cbx_Anno.SelectedIndexChanged += new System.EventHandler(this.cbx_Anno_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Año";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Estado documento";
			// 
			// rbtSinAprobar
			// 
			this.rbtSinAprobar.AutoSize = true;
			this.rbtSinAprobar.Location = new System.Drawing.Point(250, 75);
			this.rbtSinAprobar.Name = "rbtSinAprobar";
			this.rbtSinAprobar.Size = new System.Drawing.Size(88, 17);
			this.rbtSinAprobar.TabIndex = 8;
			this.rbtSinAprobar.Text = "Sin aprobado";
			this.rbtSinAprobar.UseVisualStyleBackColor = true;
			// 
			// rbtAprobado
			// 
			this.rbtAprobado.AutoSize = true;
			this.rbtAprobado.Location = new System.Drawing.Point(173, 75);
			this.rbtAprobado.Name = "rbtAprobado";
			this.rbtAprobado.Size = new System.Drawing.Size(71, 17);
			this.rbtAprobado.TabIndex = 7;
			this.rbtAprobado.Text = "Aprobado";
			this.rbtAprobado.UseVisualStyleBackColor = true;
			// 
			// rbTodos
			// 
			this.rbTodos.AutoSize = true;
			this.rbTodos.Checked = true;
			this.rbTodos.Location = new System.Drawing.Point(112, 75);
			this.rbTodos.Name = "rbTodos";
			this.rbTodos.Size = new System.Drawing.Size(55, 17);
			this.rbTodos.TabIndex = 6;
			this.rbTodos.TabStop = true;
			this.rbTodos.Text = "Todos";
			this.rbTodos.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(5, 181);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(836, 346);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.pgb_Barra);
			this.pnl_Progreso.Location = new System.Drawing.Point(54, 89);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(338, 118);
			this.pnl_Progreso.TabIndex = 10;
			this.pnl_Progreso.TabStop = false;
			this.pnl_Progreso.Text = "Progreso de Grabado";
			// 
			// pgb_Barra
			// 
			this.pgb_Barra.Location = new System.Drawing.Point(21, 43);
			this.pgb_Barra.Name = "pgb_Barra";
			this.pgb_Barra.Size = new System.Drawing.Size(311, 23);
			this.pgb_Barra.TabIndex = 0;
			// 
			// grdDatos
			// 
			this.grdDatos.AllowUserToAddRows = false;
			this.grdDatos.AllowUserToDeleteRows = false;
			this.grdDatos.AllowUserToResizeColumns = false;
			this.grdDatos.AllowUserToResizeRows = false;
			this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId_cliente,
            this.razon_social,
            this.run,
            this.annomesperiodo,
            this.ColDescTipo,
            this.ColNombreArchivo,
            this.ColAprobado,
            this.ColEliminar});
			this.grdDatos.Location = new System.Drawing.Point(3, 19);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(827, 377);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(841, 25);
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
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
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
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(538, 532);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 10;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click_1);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_16;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(366, 533);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(79, 22);
			this.btn_Guardar.TabIndex = 9;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.UseWaitCursor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// ColId_cliente
			// 
			this.ColId_cliente.DataPropertyName = "id_cliente";
			this.ColId_cliente.HeaderText = "N° Cliente";
			this.ColId_cliente.Name = "ColId_cliente";
			this.ColId_cliente.ReadOnly = true;
			this.ColId_cliente.Width = 79;
			// 
			// razon_social
			// 
			this.razon_social.DataPropertyName = "razon_social";
			this.razon_social.HeaderText = "Razon Social";
			this.razon_social.Name = "razon_social";
			this.razon_social.ReadOnly = true;
			this.razon_social.Width = 95;
			// 
			// run
			// 
			this.run.DataPropertyName = "run";
			this.run.HeaderText = "Rut";
			this.run.Name = "run";
			this.run.ReadOnly = true;
			this.run.Width = 49;
			// 
			// annomesperiodo
			// 
			this.annomesperiodo.DataPropertyName = "annomesperiodo";
			this.annomesperiodo.HeaderText = "Periodo";
			this.annomesperiodo.Name = "annomesperiodo";
			this.annomesperiodo.ReadOnly = true;
			this.annomesperiodo.Width = 68;
			// 
			// ColDescTipo
			// 
			this.ColDescTipo.DataPropertyName = "DescTipo";
			this.ColDescTipo.HeaderText = "Tipo documento";
			this.ColDescTipo.Name = "ColDescTipo";
			this.ColDescTipo.ReadOnly = true;
			this.ColDescTipo.Width = 109;
			// 
			// ColNombreArchivo
			// 
			this.ColNombreArchivo.DataPropertyName = "NombreArchivo";
			this.ColNombreArchivo.HeaderText = "Nombre archivo";
			this.ColNombreArchivo.Name = "ColNombreArchivo";
			this.ColNombreArchivo.ReadOnly = true;
			this.ColNombreArchivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColNombreArchivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColNombreArchivo.Width = 107;
			// 
			// ColAprobado
			// 
			this.ColAprobado.DataPropertyName = "Aprobado";
			this.ColAprobado.HeaderText = "Aprobar";
			this.ColAprobado.Name = "ColAprobado";
			this.ColAprobado.Width = 50;
			// 
			// ColEliminar
			// 
			this.ColEliminar.DataPropertyName = "Eliminar";
			this.ColEliminar.HeaderText = "Eliminar";
			this.ColEliminar.Name = "ColEliminar";
			this.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColEliminar.Text = "Eliminar";
			this.ColEliminar.Width = 49;
			// 
			// frmDocumentoVerAprobar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 565);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDocumentoVerAprobar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Documentos";
			this.Load += new System.EventHandler(this.frmDocumentoVerAprobar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
          private System.Windows.Forms.ToolStrip toolStrip1;
                                private System.Windows.Forms.GroupBox pnl_Progreso;
                                private System.Windows.Forms.ProgressBar pgb_Barra;
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
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.RadioButton rbtAprobado;
                                private System.Windows.Forms.RadioButton rbTodos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbtSinAprobar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_Anno;
		private System.Windows.Forms.TextBox txt_n_Cliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColId_cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
		private System.Windows.Forms.DataGridViewTextBoxColumn run;
		private System.Windows.Forms.DataGridViewTextBoxColumn annomesperiodo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDescTipo;
		private System.Windows.Forms.DataGridViewLinkColumn ColNombreArchivo;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColAprobado;
		private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
	}
}