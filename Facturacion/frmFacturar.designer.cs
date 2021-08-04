namespace ControlDosimetro
{
    partial class frmFacturar
	{
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label3 = new System.Windows.Forms.Label();
			this.grpDatosCliente = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.grpDatosFactura = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.grpDetalle = new System.Windows.Forms.GroupBox();
			this.grdDetalle = new System.Windows.Forms.DataGridView();
			this.ColSurcursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTLDRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColFilmico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColFilimicoRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.grpDatosCliente.SuspendLayout();
			this.grpDatosFactura.SuspendLayout();
			this.grpDetalle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(186, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "Datos facturación";
			// 
			// grpDatosCliente
			// 
			this.grpDatosCliente.Controls.Add(this.label11);
			this.grpDatosCliente.Controls.Add(this.lbl_id_cliente);
			this.grpDatosCliente.Controls.Add(this.lbl_nombreCliente);
			this.grpDatosCliente.Controls.Add(this.lbl_rut_cliente);
			this.grpDatosCliente.Controls.Add(this.btn_filtro);
			this.grpDatosCliente.Controls.Add(this.btn_cargar);
			this.grpDatosCliente.Controls.Add(this.cbx_id_periodo);
			this.grpDatosCliente.Controls.Add(this.label1);
			this.grpDatosCliente.Controls.Add(this.cbx_anno);
			this.grpDatosCliente.Controls.Add(this.label2);
			this.grpDatosCliente.Controls.Add(this.label4);
			this.grpDatosCliente.Location = new System.Drawing.Point(12, 55);
			this.grpDatosCliente.Name = "grpDatosCliente";
			this.grpDatosCliente.Size = new System.Drawing.Size(626, 126);
			this.grpDatosCliente.TabIndex = 10;
			this.grpDatosCliente.TabStop = false;
			this.grpDatosCliente.Text = "Dato Cliente";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 97);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 53;
			this.label11.Text = "Rut";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(88, 66);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 50;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(147, 67);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 51;
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(85, 97);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut_cliente.TabIndex = 46;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(295, 97);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(214, 97);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 3;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(88, 39);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 43;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(88, 14);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Año";
			// 
			// grpDatosFactura
			// 
			this.grpDatosFactura.Controls.Add(this.label13);
			this.grpDatosFactura.Controls.Add(this.label12);
			this.grpDatosFactura.Controls.Add(this.label10);
			this.grpDatosFactura.Controls.Add(this.label9);
			this.grpDatosFactura.Controls.Add(this.label8);
			this.grpDatosFactura.Controls.Add(this.label7);
			this.grpDatosFactura.Controls.Add(this.label6);
			this.grpDatosFactura.Controls.Add(this.label5);
			this.grpDatosFactura.Location = new System.Drawing.Point(15, 186);
			this.grpDatosFactura.Name = "grpDatosFactura";
			this.grpDatosFactura.Size = new System.Drawing.Size(622, 203);
			this.grpDatosFactura.TabIndex = 11;
			this.grpDatosFactura.TabStop = false;
			this.grpDatosFactura.Text = "Datos factura";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 60);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 13);
			this.label13.TabIndex = 7;
			this.label13.Text = "Fecha emisión";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 167);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Total factura";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(173, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Precio";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(170, 91);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Precio";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Cantidad TLD";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Cantidad filmico";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "N° factura";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(170, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Fecha facturación";
			// 
			// grpDetalle
			// 
			this.grpDetalle.Controls.Add(this.grdDetalle);
			this.grpDetalle.Location = new System.Drawing.Point(16, 394);
			this.grpDetalle.Name = "grpDetalle";
			this.grpDetalle.Size = new System.Drawing.Size(621, 222);
			this.grpDetalle.TabIndex = 12;
			this.grpDetalle.TabStop = false;
			this.grpDetalle.Text = "Detalle";
			// 
			// grdDetalle
			// 
			this.grdDetalle.AllowUserToAddRows = false;
			this.grdDetalle.AllowUserToDeleteRows = false;
			this.grdDetalle.AllowUserToOrderColumns = true;
			this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSurcursal,
            this.ColTLD,
            this.ColTLDRef,
            this.ColFilmico,
            this.ColFilimicoRef});
			this.grdDetalle.Location = new System.Drawing.Point(12, 19);
			this.grdDetalle.Name = "grdDetalle";
			this.grdDetalle.Size = new System.Drawing.Size(603, 197);
			this.grdDetalle.TabIndex = 0;
			// 
			// ColSurcursal
			// 
			this.ColSurcursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColSurcursal.HeaderText = "Sucursal";
			this.ColSurcursal.Name = "ColSurcursal";
			this.ColSurcursal.ReadOnly = true;
			// 
			// ColTLD
			// 
			this.ColTLD.HeaderText = "TLD";
			this.ColTLD.Name = "ColTLD";
			this.ColTLD.ReadOnly = true;
			this.ColTLD.Width = 70;
			// 
			// ColTLDRef
			// 
			this.ColTLDRef.HeaderText = "Ref";
			this.ColTLDRef.Name = "ColTLDRef";
			this.ColTLDRef.ReadOnly = true;
			this.ColTLDRef.ToolTipText = "Referencia";
			this.ColTLDRef.Width = 50;
			// 
			// ColFilmico
			// 
			this.ColFilmico.HeaderText = "Fílmico";
			this.ColFilmico.Name = "ColFilmico";
			this.ColFilmico.ReadOnly = true;
			this.ColFilmico.Width = 70;
			// 
			// ColFilimicoRef
			// 
			this.ColFilimicoRef.HeaderText = "Ref.";
			this.ColFilimicoRef.Name = "ColFilimicoRef";
			this.ColFilimicoRef.ReadOnly = true;
			this.ColFilimicoRef.Width = 50;
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(135, 622);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(129, 37);
			this.btn_Guardar.TabIndex = 1;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Image = global::ControlDosimetro.Properties.Resources.exit;
			this.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Cerrar.Location = new System.Drawing.Point(355, 622);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(123, 39);
			this.btn_Cerrar.TabIndex = 13;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			// 
			// frmFacturar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 666);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.grpDetalle);
			this.Controls.Add(this.grpDatosFactura);
			this.Controls.Add(this.grpDatosCliente);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFacturar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Facturación Cliente";
			this.Load += new System.EventHandler(this.frmFacturar_Load);
			this.grpDatosCliente.ResumeLayout(false);
			this.grpDatosCliente.PerformLayout();
			this.grpDatosFactura.ResumeLayout(false);
			this.grpDatosFactura.PerformLayout();
			this.grpDetalle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox grpDatosCliente;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox lbl_id_cliente;
		private System.Windows.Forms.Label lbl_nombreCliente;
		private System.Windows.Forms.Label lbl_rut_cliente;
		private System.Windows.Forms.Button btn_filtro;
		private System.Windows.Forms.Button btn_cargar;
		private System.Windows.Forms.ComboBox cbx_id_periodo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbx_anno;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox grpDatosFactura;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox grpDetalle;
		private System.Windows.Forms.DataGridView grdDetalle;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColSurcursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTLD;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTLDRef;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColFilmico;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColFilimicoRef;
		private System.Windows.Forms.Button btn_Guardar;
		private System.Windows.Forms.Button btn_Cerrar;
	}
}

