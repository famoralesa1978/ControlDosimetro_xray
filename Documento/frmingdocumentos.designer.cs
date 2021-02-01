namespace ControlDosimetro
{
    partial class frmingdocumentos
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_RazonSocial = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.cbx_TipoPeriodo = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_rut = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_Cargar_cliente = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_Direccion = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gpx_Asociar = new System.Windows.Forms.GroupBox();
			this.btn_Ver = new System.Windows.Forms.Button();
			this.txtDescripcionArchivo = new System.Windows.Forms.TextBox();
			this.txtRutaArchivo = new System.Windows.Forms.TextBox();
			this.btnExaminar = new System.Windows.Forms.Button();
			this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGrabarArchivo = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.gpx_Asociar.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_RazonSocial);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnLimpiar);
			this.groupBox1.Controls.Add(this.cbx_TipoPeriodo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.lbl_rut);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.btn_Cargar_cliente);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_Direccion);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(23, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(516, 197);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// lbl_RazonSocial
			// 
			this.lbl_RazonSocial.AutoSize = true;
			this.lbl_RazonSocial.Location = new System.Drawing.Point(105, 121);
			this.lbl_RazonSocial.Name = "lbl_RazonSocial";
			this.lbl_RazonSocial.Size = new System.Drawing.Size(0, 13);
			this.lbl_RazonSocial.TabIndex = 53;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 13);
			this.label8.TabIndex = 52;
			this.label8.Text = "Razon social";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(366, 89);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(144, 23);
			this.btnLimpiar.TabIndex = 11;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// cbx_TipoPeriodo
			// 
			this.cbx_TipoPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_TipoPeriodo.FormattingEnabled = true;
			this.cbx_TipoPeriodo.Location = new System.Drawing.Point(90, 15);
			this.cbx_TipoPeriodo.Name = "cbx_TipoPeriodo";
			this.cbx_TipoPeriodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_TipoPeriodo.TabIndex = 50;
			this.cbx_TipoPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoPeriodo_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 13);
			this.label7.TabIndex = 51;
			this.label7.Text = "Tipo periodo";
			// 
			// lbl_rut
			// 
			this.lbl_rut.AutoSize = true;
			this.lbl_rut.Location = new System.Drawing.Point(84, 142);
			this.lbl_rut.Name = "lbl_rut";
			this.lbl_rut.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut.TabIndex = 49;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 142);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 48;
			this.label11.Text = "Rut";
			// 
			// btn_Cargar_cliente
			// 
			this.btn_Cargar_cliente.Location = new System.Drawing.Point(229, 90);
			this.btn_Cargar_cliente.Name = "btn_Cargar_cliente";
			this.btn_Cargar_cliente.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_cliente.TabIndex = 47;
			this.btn_Cargar_cliente.Text = "Cargar Cliente";
			this.btn_Cargar_cliente.UseVisualStyleBackColor = true;
			this.btn_Cargar_cliente.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(90, 92);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(121, 20);
			this.lbl_id_cliente.TabIndex = 1;
			// 
			// lbl_Direccion
			// 
			this.lbl_Direccion.AutoSize = true;
			this.lbl_Direccion.Location = new System.Drawing.Point(84, 168);
			this.lbl_Direccion.Name = "lbl_Direccion";
			this.lbl_Direccion.Size = new System.Drawing.Size(0, 13);
			this.lbl_Direccion.TabIndex = 46;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 45;
			this.label6.Text = "Dirección";
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(90, 65);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 3;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(146, 114);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 42;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(90, 40);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 2;
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Año";
			// 
			// gpx_Asociar
			// 
			this.gpx_Asociar.Controls.Add(this.btn_Ver);
			this.gpx_Asociar.Controls.Add(this.txtDescripcionArchivo);
			this.gpx_Asociar.Controls.Add(this.txtRutaArchivo);
			this.gpx_Asociar.Controls.Add(this.btnExaminar);
			this.gpx_Asociar.Controls.Add(this.cbxTipoDocumento);
			this.gpx_Asociar.Controls.Add(this.label4);
			this.gpx_Asociar.Controls.Add(this.label5);
			this.gpx_Asociar.Location = new System.Drawing.Point(23, 215);
			this.gpx_Asociar.Name = "gpx_Asociar";
			this.gpx_Asociar.Size = new System.Drawing.Size(516, 169);
			this.gpx_Asociar.TabIndex = 45;
			this.gpx_Asociar.TabStop = false;
			this.gpx_Asociar.Text = "Asociar Documentos a Cliente";
			// 
			// btn_Ver
			// 
			this.btn_Ver.Image = global::ControlDosimetro.Properties.Resources.lookImage_32;
			this.btn_Ver.Location = new System.Drawing.Point(458, 123);
			this.btn_Ver.Name = "btn_Ver";
			this.btn_Ver.Size = new System.Drawing.Size(36, 37);
			this.btn_Ver.TabIndex = 8;
			this.btn_Ver.UseVisualStyleBackColor = true;
			this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
			// 
			// txtDescripcionArchivo
			// 
			this.txtDescripcionArchivo.CausesValidation = false;
			this.txtDescripcionArchivo.Location = new System.Drawing.Point(151, 50);
			this.txtDescripcionArchivo.MaxLength = 100;
			this.txtDescripcionArchivo.Name = "txtDescripcionArchivo";
			this.txtDescripcionArchivo.Size = new System.Drawing.Size(295, 20);
			this.txtDescripcionArchivo.TabIndex = 1;
			// 
			// txtRutaArchivo
			// 
			this.txtRutaArchivo.Location = new System.Drawing.Point(7, 132);
			this.txtRutaArchivo.Name = "txtRutaArchivo";
			this.txtRutaArchivo.ReadOnly = true;
			this.txtRutaArchivo.Size = new System.Drawing.Size(295, 20);
			this.txtRutaArchivo.TabIndex = 3;
			// 
			// btnExaminar
			// 
			this.btnExaminar.Location = new System.Drawing.Point(308, 130);
			this.btnExaminar.Name = "btnExaminar";
			this.btnExaminar.Size = new System.Drawing.Size(144, 23);
			this.btnExaminar.TabIndex = 4;
			this.btnExaminar.Text = "Seleccionar Archivo...";
			this.btnExaminar.UseVisualStyleBackColor = true;
			this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
			// 
			// cbxTipoDocumento
			// 
			this.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipoDocumento.FormattingEnabled = true;
			this.cbxTipoDocumento.Location = new System.Drawing.Point(151, 85);
			this.cbxTipoDocumento.Name = "cbxTipoDocumento";
			this.cbxTipoDocumento.Size = new System.Drawing.Size(295, 21);
			this.cbxTipoDocumento.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tipo de Documento";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Descripción";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::ControlDosimetro.Properties.Resources.Close_24;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(304, 390);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(125, 29);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cerrar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGrabarArchivo
			// 
			this.btnGrabarArchivo.Image = global::ControlDosimetro.Properties.Resources.Save_24;
			this.btnGrabarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGrabarArchivo.Location = new System.Drawing.Point(113, 390);
			this.btnGrabarArchivo.Name = "btnGrabarArchivo";
			this.btnGrabarArchivo.Size = new System.Drawing.Size(125, 29);
			this.btnGrabarArchivo.TabIndex = 5;
			this.btnGrabarArchivo.Text = "Grabar";
			this.btnGrabarArchivo.UseVisualStyleBackColor = true;
			this.btnGrabarArchivo.Click += new System.EventHandler(this.btnGrabarArchivo_Click);
			// 
			// frmingdocumentos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 431);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.gpx_Asociar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGrabarArchivo);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmingdocumentos";
			this.Text = "Asociar Documentos a Clientes";
			this.Load += new System.EventHandler(this.frmingdocumentos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gpx_Asociar.ResumeLayout(false);
			this.gpx_Asociar.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_rut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Cargar_cliente;
        private System.Windows.Forms.TextBox lbl_id_cliente;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_id_periodo;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_anno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpx_Asociar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtDescripcionArchivo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnGrabarArchivo;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbx_TipoPeriodo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_RazonSocial;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_Ver;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}