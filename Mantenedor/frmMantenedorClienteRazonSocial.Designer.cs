﻿namespace ControlDosimetro
{
    partial class frmMantenedorClienteRazonSocial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenedorClienteRazonSocial));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_razsocial_nvo = new System.Windows.Forms.TextBox();
			this.txt_rut_nvo = new System.Windows.Forms.TextBox();
			this.lbl_razsocial_nvo = new System.Windows.Forms.Label();
			this.lbl_rut_nvo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_rut = new System.Windows.Forms.Label();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cargar_cliente = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Cliente = new System.Windows.Forms.ToolStripButton();
			this.tsdReporte = new System.Windows.Forms.ToolStripDropDownButton();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_razsocial_nvo);
			this.groupBox1.Controls.Add(this.txt_rut_nvo);
			this.groupBox1.Controls.Add(this.lbl_razsocial_nvo);
			this.groupBox1.Controls.Add(this.lbl_rut_nvo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbl_rut);
			this.groupBox1.Controls.Add(this.btn_Cerrar);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.btn_Guardar);
			this.groupBox1.Controls.Add(this.btn_Cargar_cliente);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(460, 271);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// txt_razsocial_nvo
			// 
			this.txt_razsocial_nvo.Location = new System.Drawing.Point(118, 146);
			this.txt_razsocial_nvo.Name = "txt_razsocial_nvo";
			this.txt_razsocial_nvo.Size = new System.Drawing.Size(148, 20);
			this.txt_razsocial_nvo.TabIndex = 59;
			// 
			// txt_rut_nvo
			// 
			this.txt_rut_nvo.Location = new System.Drawing.Point(118, 117);
			this.txt_rut_nvo.Name = "txt_rut_nvo";
			this.txt_rut_nvo.Size = new System.Drawing.Size(80, 20);
			this.txt_rut_nvo.TabIndex = 58;
			// 
			// lbl_razsocial_nvo
			// 
			this.lbl_razsocial_nvo.AutoSize = true;
			this.lbl_razsocial_nvo.Location = new System.Drawing.Point(10, 149);
			this.lbl_razsocial_nvo.Name = "lbl_razsocial_nvo";
			this.lbl_razsocial_nvo.Size = new System.Drawing.Size(104, 13);
			this.lbl_razsocial_nvo.TabIndex = 57;
			this.lbl_razsocial_nvo.Text = "Razón social nueva:";
			// 
			// lbl_rut_nvo
			// 
			this.lbl_rut_nvo.AutoSize = true;
			this.lbl_rut_nvo.Location = new System.Drawing.Point(10, 120);
			this.lbl_rut_nvo.Name = "lbl_rut_nvo";
			this.lbl_rut_nvo.Size = new System.Drawing.Size(60, 13);
			this.lbl_rut_nvo.TabIndex = 56;
			this.lbl_rut_nvo.Text = "Rut nuevo:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 55;
			this.label1.Text = "Razón social:";
			// 
			// lbl_rut
			// 
			this.lbl_rut.AutoSize = true;
			this.lbl_rut.Location = new System.Drawing.Point(71, 62);
			this.lbl_rut.Name = "lbl_rut";
			this.lbl_rut.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut.TabIndex = 54;
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Image = global::ControlDosimetro.Properties.Resources.Close_24;
			this.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Cerrar.Location = new System.Drawing.Point(258, 203);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(116, 38);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(27, 13);
			this.label11.TabIndex = 53;
			this.label11.Text = "Rut:";
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(42, 203);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(139, 38);
			this.btn_Guardar.TabIndex = 7;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// btn_Cargar_cliente
			// 
			this.btn_Cargar_cliente.Location = new System.Drawing.Point(164, 15);
			this.btn_Cargar_cliente.Name = "btn_Cargar_cliente";
			this.btn_Cargar_cliente.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_cliente.TabIndex = 52;
			this.btn_Cargar_cliente.Text = "Cargar Cliente";
			this.btn_Cargar_cliente.UseVisualStyleBackColor = true;
			this.btn_Cargar_cliente.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(92, 18);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 50;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(117, 86);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 51;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(289, 15);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cliente,
            this.tsdReporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(476, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Cliente
			// 
			this.btn_Cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Cliente.Image = global::ControlDosimetro.Properties.Resources.cliente;
			this.btn_Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Cliente.Name = "btn_Cliente";
			this.btn_Cliente.Size = new System.Drawing.Size(24, 24);
			this.btn_Cliente.Text = "Cliente";
			this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
			// 
			// tsdReporte
			// 
			this.tsdReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsdReporte.Image")));
			this.tsdReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdReporte.Name = "tsdReporte";
			this.tsdReporte.Size = new System.Drawing.Size(61, 24);
			this.tsdReporte.Text = "Reporte";
			// 
			// frmMantenedorClienteRazonSocial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 309);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMantenedorClienteRazonSocial";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cliente - Modificar razón social";
			this.Load += new System.EventHandler(this.frmMantenedorClienteRazonSocial_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Button btn_Guardar;
								private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_filtro;
                                private System.Windows.Forms.Label lbl_rut;
                                private System.Windows.Forms.Label label11;
                                private System.Windows.Forms.Button btn_Cargar_cliente;
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.ToolStripDropDownButton tsdReporte;
        private System.Windows.Forms.ToolStripButton btn_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_razsocial_nvo;
        private System.Windows.Forms.Label lbl_rut_nvo;
        private System.Windows.Forms.TextBox txt_razsocial_nvo;
        private System.Windows.Forms.TextBox txt_rut_nvo;
    }
}