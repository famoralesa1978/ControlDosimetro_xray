namespace ControlDosimetro
{
    partial class frmObservacionCliente
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
			this.tbl_observacioncliente = new System.Windows.Forms.GroupBox();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.lbl_rut = new System.Windows.Forms.Label();
			this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_FechaTermino = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rtb_Observacion = new System.Windows.Forms.RichTextBox();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_Grabar = new System.Windows.Forms.Button();
			this.dtp_FechaTermino = new System.Windows.Forms.DateTimePicker();
			this.tbl_observacioncliente.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbl_observacioncliente
			// 
			this.tbl_observacioncliente.Controls.Add(this.cbx_id_periodo);
			this.tbl_observacioncliente.Controls.Add(this.lbl_rut);
			this.tbl_observacioncliente.Controls.Add(this.dtp_FechaInicio);
			this.tbl_observacioncliente.Controls.Add(this.label4);
			this.tbl_observacioncliente.Controls.Add(this.lbl_FechaTermino);
			this.tbl_observacioncliente.Controls.Add(this.label1);
			this.tbl_observacioncliente.Controls.Add(this.rtb_Observacion);
			this.tbl_observacioncliente.Controls.Add(this.lbl_nombre);
			this.tbl_observacioncliente.Controls.Add(this.label2);
			this.tbl_observacioncliente.Controls.Add(this.lbl_id_cliente);
			this.tbl_observacioncliente.Controls.Add(this.label6);
			this.tbl_observacioncliente.Controls.Add(this.btn_Grabar);
			this.tbl_observacioncliente.Controls.Add(this.dtp_FechaTermino);
			this.tbl_observacioncliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_observacioncliente.Location = new System.Drawing.Point(0, 0);
			this.tbl_observacioncliente.Name = "tbl_observacioncliente";
			this.tbl_observacioncliente.Size = new System.Drawing.Size(493, 223);
			this.tbl_observacioncliente.TabIndex = 0;
			this.tbl_observacioncliente.TabStop = false;
			this.tbl_observacioncliente.Text = "Datos";
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(165, 67);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 44;
			this.cbx_id_periodo.SelectedIndexChanged += new System.EventHandler(this.cbx_id_periodo_SelectedIndexChanged);
			// 
			// lbl_rut
			// 
			this.lbl_rut.AutoSize = true;
			this.lbl_rut.Location = new System.Drawing.Point(16, 162);
			this.lbl_rut.Name = "lbl_rut";
			this.lbl_rut.Size = new System.Drawing.Size(35, 13);
			this.lbl_rut.TabIndex = 40;
			this.lbl_rut.Text = "label5";
			this.lbl_rut.Visible = false;
			// 
			// dtp_FechaInicio
			// 
			this.dtp_FechaInicio.CustomFormat = "dd/MM/yyyy";
			this.dtp_FechaInicio.Enabled = false;
			this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaInicio.Location = new System.Drawing.Point(165, 42);
			this.dtp_FechaInicio.Name = "dtp_FechaInicio";
			this.dtp_FechaInicio.Size = new System.Drawing.Size(98, 20);
			this.dtp_FechaInicio.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "Fecha Inicio Servicio";
			// 
			// lbl_FechaTermino
			// 
			this.lbl_FechaTermino.AutoSize = true;
			this.lbl_FechaTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_FechaTermino.Location = new System.Drawing.Point(12, 70);
			this.lbl_FechaTermino.Name = "lbl_FechaTermino";
			this.lbl_FechaTermino.Size = new System.Drawing.Size(119, 13);
			this.lbl_FechaTermino.TabIndex = 28;
			this.lbl_FechaTermino.Text = "Fecha Termino Servicio";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Observación";
			// 
			// rtb_Observacion
			// 
			this.rtb_Observacion.Location = new System.Drawing.Point(165, 94);
			this.rtb_Observacion.MaxLength = 200;
			this.rtb_Observacion.Name = "rtb_Observacion";
			this.rtb_Observacion.Size = new System.Drawing.Size(316, 67);
			this.rtb_Observacion.TabIndex = 26;
			this.rtb_Observacion.Text = "";
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.AutoSize = true;
			this.lbl_nombre.Location = new System.Drawing.Point(207, 16);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombre.TabIndex = 25;
			this.lbl_nombre.Text = "label4";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(191, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "-";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Location = new System.Drawing.Point(162, 16);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(10, 13);
			this.lbl_id_cliente.TabIndex = 23;
			this.lbl_id_cliente.Text = "-";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "Cliente";
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Location = new System.Drawing.Point(97, 181);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
			this.btn_Grabar.TabIndex = 17;
			this.btn_Grabar.Text = "Guardar";
			this.btn_Grabar.UseVisualStyleBackColor = true;
			this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
			// 
			// dtp_FechaTermino
			// 
			this.dtp_FechaTermino.CustomFormat = "dd/MM/yyyy";
			this.dtp_FechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaTermino.Location = new System.Drawing.Point(292, 68);
			this.dtp_FechaTermino.Name = "dtp_FechaTermino";
			this.dtp_FechaTermino.Size = new System.Drawing.Size(98, 20);
			this.dtp_FechaTermino.TabIndex = 37;
			this.dtp_FechaTermino.Value = new System.DateTime(2018, 2, 14, 0, 0, 0, 0);
			// 
			// frmObservacionCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 223);
			this.ControlBox = false;
			this.Controls.Add(this.tbl_observacioncliente);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmObservacionCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Observación ";
			this.tbl_observacioncliente.ResumeLayout(false);
			this.tbl_observacioncliente.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

								private System.Windows.Forms.GroupBox tbl_observacioncliente;
								private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.Label label6;
								private System.Windows.Forms.RichTextBox rtb_Observacion;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Label lbl_FechaTermino;
								private System.Windows.Forms.DateTimePicker dtp_FechaTermino;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
                                private System.Windows.Forms.Label lbl_rut;
                                private System.Windows.Forms.ComboBox cbx_id_periodo;
    }
}