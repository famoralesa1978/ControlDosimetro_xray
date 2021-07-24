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
			this.grpFactura = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.grpDatosCliente.SuspendLayout();
			this.grpFactura.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(307, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "Facturación";
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
			// grpFactura
			// 
			this.grpFactura.Controls.Add(this.label13);
			this.grpFactura.Controls.Add(this.label12);
			this.grpFactura.Controls.Add(this.label10);
			this.grpFactura.Controls.Add(this.label9);
			this.grpFactura.Controls.Add(this.label8);
			this.grpFactura.Controls.Add(this.label7);
			this.grpFactura.Controls.Add(this.label6);
			this.grpFactura.Controls.Add(this.label5);
			this.grpFactura.Location = new System.Drawing.Point(15, 186);
			this.grpFactura.Name = "grpFactura";
			this.grpFactura.Size = new System.Drawing.Size(622, 234);
			this.grpFactura.TabIndex = 11;
			this.grpFactura.TabStop = false;
			this.grpFactura.Text = "Datos factura";
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "N° factura";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Cantidad filmico";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Cantidad TLD";
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
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(173, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Precio";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(16, 166);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Total factura";
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
			// frmFacturar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 666);
			this.Controls.Add(this.grpFactura);
			this.Controls.Add(this.grpDatosCliente);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFacturar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Facturación Cliente";
			this.grpDatosCliente.ResumeLayout(false);
			this.grpDatosCliente.PerformLayout();
			this.grpFactura.ResumeLayout(false);
			this.grpFactura.PerformLayout();
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
		private System.Windows.Forms.GroupBox grpFactura;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label13;
	}
}

