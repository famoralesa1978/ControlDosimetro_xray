namespace ControlDosimetro
{
    partial class frmEliminarPelicula
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txt_NTLD = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
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
			this.tbcPrincipal = new System.Windows.Forms.TabControl();
			this.tabTLD = new System.Windows.Forms.TabPage();
			this.btnBuscarTLD = new System.Windows.Forms.Button();
			this.tabDosimetro = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPersonal = new System.Windows.Forms.Label();
			this.lblRut = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDirección = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNCliente = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.cmsPopup.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tbcPrincipal.SuspendLayout();
			this.tabTLD.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_NTLD
			// 
			this.txt_NTLD.Location = new System.Drawing.Point(116, 22);
			this.txt_NTLD.MaxLength = 10;
			this.txt_NTLD.Name = "txt_NTLD";
			this.txt_NTLD.Size = new System.Drawing.Size(74, 20);
			this.txt_NTLD.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 47;
			this.label1.Text = "N°  TLD";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(191, 211);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 4;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Location = new System.Drawing.Point(71, 211);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(114, 23);
			this.btn_Guardar.TabIndex = 3;
			this.btn_Guardar.Text = "Eliminar TLD";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// cmsPopup
			// 
			this.cmsPopup.ImageScalingSize = new System.Drawing.Size(20, 20);
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
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(437, 25);
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
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
			// tbcPrincipal
			// 
			this.tbcPrincipal.Controls.Add(this.tabTLD);
			this.tbcPrincipal.Controls.Add(this.tabDosimetro);
			this.tbcPrincipal.Location = new System.Drawing.Point(0, 28);
			this.tbcPrincipal.Name = "tbcPrincipal";
			this.tbcPrincipal.SelectedIndex = 0;
			this.tbcPrincipal.Size = new System.Drawing.Size(432, 279);
			this.tbcPrincipal.TabIndex = 3;
			// 
			// tabTLD
			// 
			this.tabTLD.Controls.Add(this.lbl_nombreCliente);
			this.tabTLD.Controls.Add(this.label3);
			this.tabTLD.Controls.Add(this.label7);
			this.tabTLD.Controls.Add(this.label11);
			this.tabTLD.Controls.Add(this.lbl_rut_cliente);
			this.tabTLD.Controls.Add(this.lblNCliente);
			this.tabTLD.Controls.Add(this.label6);
			this.tabTLD.Controls.Add(this.lblDirección);
			this.tabTLD.Controls.Add(this.label5);
			this.tabTLD.Controls.Add(this.lblRut);
			this.tabTLD.Controls.Add(this.label4);
			this.tabTLD.Controls.Add(this.lblPersonal);
			this.tabTLD.Controls.Add(this.label2);
			this.tabTLD.Controls.Add(this.btnBuscarTLD);
			this.tabTLD.Controls.Add(this.txt_NTLD);
			this.tabTLD.Controls.Add(this.btn_Guardar);
			this.tabTLD.Controls.Add(this.label1);
			this.tabTLD.Controls.Add(this.btn_filtro);
			this.tabTLD.Location = new System.Drawing.Point(4, 22);
			this.tabTLD.Name = "tabTLD";
			this.tabTLD.Padding = new System.Windows.Forms.Padding(3);
			this.tabTLD.Size = new System.Drawing.Size(424, 253);
			this.tabTLD.TabIndex = 0;
			this.tabTLD.Text = "TLD";
			this.tabTLD.UseVisualStyleBackColor = true;
			// 
			// btnBuscarTLD
			// 
			this.btnBuscarTLD.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btnBuscarTLD.Location = new System.Drawing.Point(209, 12);
			this.btnBuscarTLD.Name = "btnBuscarTLD";
			this.btnBuscarTLD.Size = new System.Drawing.Size(62, 39);
			this.btnBuscarTLD.TabIndex = 48;
			this.btnBuscarTLD.UseVisualStyleBackColor = true;
			this.btnBuscarTLD.Click += new System.EventHandler(this.btnBuscarTLD_Click);
			// 
			// tabDosimetro
			// 
			this.tabDosimetro.Location = new System.Drawing.Point(4, 22);
			this.tabDosimetro.Name = "tabDosimetro";
			this.tabDosimetro.Padding = new System.Windows.Forms.Padding(3);
			this.tabDosimetro.Size = new System.Drawing.Size(424, 203);
			this.tabDosimetro.TabIndex = 1;
			this.tabDosimetro.Text = "Filimico";
			this.tabDosimetro.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "Personal ";
			// 
			// lblPersonal
			// 
			this.lblPersonal.AutoSize = true;
			this.lblPersonal.Location = new System.Drawing.Point(116, 123);
			this.lblPersonal.Name = "lblPersonal";
			this.lblPersonal.Size = new System.Drawing.Size(0, 13);
			this.lblPersonal.TabIndex = 50;
			// 
			// lblRut
			// 
			this.lblRut.AutoSize = true;
			this.lblRut.Location = new System.Drawing.Point(116, 145);
			this.lblRut.Name = "lblRut";
			this.lblRut.Size = new System.Drawing.Size(0, 13);
			this.lblRut.TabIndex = 52;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 51;
			this.label4.Text = "Rut ";
			// 
			// lblDirección
			// 
			this.lblDirección.AutoSize = true;
			this.lblDirección.Location = new System.Drawing.Point(116, 168);
			this.lblDirección.Name = "lblDirección";
			this.lblDirección.Size = new System.Drawing.Size(0, 13);
			this.lblDirección.TabIndex = 54;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 53;
			this.label5.Text = "Sucursal";
			// 
			// lblNCliente
			// 
			this.lblNCliente.AutoSize = true;
			this.lblNCliente.Location = new System.Drawing.Point(116, 57);
			this.lblNCliente.Name = "lblNCliente";
			this.lblNCliente.Size = new System.Drawing.Size(0, 13);
			this.lblNCliente.TabIndex = 56;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 55;
			this.label6.Text = "N° Cliente";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(19, 83);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 58;
			this.label11.Text = "Rut";
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(91, 83);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut_cliente.TabIndex = 57;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 60;
			this.label3.Text = "Cliente";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(91, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 59;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(97, 108);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 61;
			// 
			// frmEliminarPelicula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 319);
			this.Controls.Add(this.tbcPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEliminarPelicula";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Eliminar TLD o Dosimetro";
			this.cmsPopup.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tbcPrincipal.ResumeLayout(false);
			this.tabTLD.ResumeLayout(false);
			this.tabTLD.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Button btn_Guardar;
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
                                private System.Windows.Forms.FontDialog fdgLetra;
                                private System.Windows.Forms.ColorDialog colorDialog1;
                                private System.Windows.Forms.OpenFileDialog openFileDialog1;
                                private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
                                private System.Windows.Forms.ToolStripMenuItem btn_EliminarSeleccion;
                                private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.TextBox txt_NTLD;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tbcPrincipal;
		private System.Windows.Forms.TabPage tabTLD;
		private System.Windows.Forms.Button btnBuscarTLD;
		private System.Windows.Forms.TabPage tabDosimetro;
		private System.Windows.Forms.Label lblNCliente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblDirección;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblRut;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblPersonal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbl_rut_cliente;
		private System.Windows.Forms.Label lbl_nombreCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
	}
}