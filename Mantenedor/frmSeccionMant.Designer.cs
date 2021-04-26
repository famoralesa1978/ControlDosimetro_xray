namespace ControlDosimetro
{
	partial class frmSeccionMant
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
			this.tbl_seccion = new System.Windows.Forms.GroupBox();
			this.lbl_id_seccion = new System.Windows.Forms.Label();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.cbx_id_estado = new System.Windows.Forms.ComboBox();
			this.lbl_id_estado = new System.Windows.Forms.Label();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.btn_Grabar = new System.Windows.Forms.Button();
			this.lbl_id_secciondesc = new System.Windows.Forms.Label();
			this.txt_seccion = new System.Windows.Forms.TextBox();
			this.lbl_seccion = new System.Windows.Forms.Label();
			this.lbl_id_cliente1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tbl_seccion.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbl_seccion
			// 
			this.tbl_seccion.Controls.Add(this.lbl_id_seccion);
			this.tbl_seccion.Controls.Add(this.lbl_nombreCliente);
			this.tbl_seccion.Controls.Add(this.lbl_id_cliente);
			this.tbl_seccion.Controls.Add(this.cbx_id_estado);
			this.tbl_seccion.Controls.Add(this.lbl_id_estado);
			this.tbl_seccion.Controls.Add(this.btn_cerrar);
			this.tbl_seccion.Controls.Add(this.btn_Grabar);
			this.tbl_seccion.Controls.Add(this.lbl_id_secciondesc);
			this.tbl_seccion.Controls.Add(this.txt_seccion);
			this.tbl_seccion.Controls.Add(this.lbl_seccion);
			this.tbl_seccion.Controls.Add(this.lbl_id_cliente1);
			this.tbl_seccion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_seccion.Location = new System.Drawing.Point(0, 0);
			this.tbl_seccion.Name = "tbl_seccion";
			this.tbl_seccion.Size = new System.Drawing.Size(489, 172);
			this.tbl_seccion.TabIndex = 0;
			this.tbl_seccion.TabStop = false;
			this.tbl_seccion.Text = "Datos";
			// 
			// lbl_id_seccion
			// 
			this.lbl_id_seccion.AutoSize = true;
			this.lbl_id_seccion.Location = new System.Drawing.Point(166, 44);
			this.lbl_id_seccion.Name = "lbl_id_seccion";
			this.lbl_id_seccion.Size = new System.Drawing.Size(35, 13);
			this.lbl_id_seccion.TabIndex = 41;
			this.lbl_id_seccion.Text = "label1";
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(221, 20);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombreCliente.TabIndex = 40;
			this.lbl_nombreCliente.Text = "label1";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Location = new System.Drawing.Point(167, 21);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_id_cliente.TabIndex = 39;
			this.lbl_id_cliente.Text = "label1";
			// 
			// cbx_id_estado
			// 
			this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_estado.FormattingEnabled = true;
			this.cbx_id_estado.Location = new System.Drawing.Point(164, 95);
			this.cbx_id_estado.Name = "cbx_id_estado";
			this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_estado.TabIndex = 30;
			// 
			// lbl_id_estado
			// 
			this.lbl_id_estado.AutoSize = true;
			this.lbl_id_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_estado.Location = new System.Drawing.Point(11, 98);
			this.lbl_id_estado.Name = "lbl_id_estado";
			this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
			this.lbl_id_estado.TabIndex = 28;
			this.lbl_id_estado.Text = "Estado";
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.Image = global::ControlDosimetro.Properties.Resources.Close_24;
			this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cerrar.Location = new System.Drawing.Point(241, 127);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(112, 33);
			this.btn_cerrar.TabIndex = 10;
			this.btn_cerrar.Text = "Cerrar";
			this.toolTip1.SetToolTip(this.btn_cerrar, "Cerrar formulario");
			this.btn_cerrar.UseVisualStyleBackColor = true;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Image = global::ControlDosimetro.Properties.Resources.Save_24;
			this.btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Grabar.Location = new System.Drawing.Point(92, 127);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(109, 34);
			this.btn_Grabar.TabIndex = 9;
			this.btn_Grabar.Text = "Guardar";
			this.toolTip1.SetToolTip(this.btn_Grabar, "Guardar la información");
			this.btn_Grabar.UseVisualStyleBackColor = true;
			this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
			// 
			// lbl_id_secciondesc
			// 
			this.lbl_id_secciondesc.AutoSize = true;
			this.lbl_id_secciondesc.Location = new System.Drawing.Point(11, 45);
			this.lbl_id_secciondesc.Name = "lbl_id_secciondesc";
			this.lbl_id_secciondesc.Size = new System.Drawing.Size(71, 13);
			this.lbl_id_secciondesc.TabIndex = 11;
			this.lbl_id_secciondesc.Text = "Cod. Sección";
			// 
			// txt_seccion
			// 
			this.txt_seccion.Location = new System.Drawing.Point(164, 65);
			this.txt_seccion.MaxLength = 100;
			this.txt_seccion.Name = "txt_seccion";
			this.txt_seccion.Size = new System.Drawing.Size(313, 20);
			this.txt_seccion.TabIndex = 2;
			// 
			// lbl_seccion
			// 
			this.lbl_seccion.AutoSize = true;
			this.lbl_seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_seccion.Location = new System.Drawing.Point(11, 68);
			this.lbl_seccion.Name = "lbl_seccion";
			this.lbl_seccion.Size = new System.Drawing.Size(46, 13);
			this.lbl_seccion.TabIndex = 7;
			this.lbl_seccion.Text = "Sección";
			// 
			// lbl_id_cliente1
			// 
			this.lbl_id_cliente1.AutoSize = true;
			this.lbl_id_cliente1.Location = new System.Drawing.Point(11, 22);
			this.lbl_id_cliente1.Name = "lbl_id_cliente1";
			this.lbl_id_cliente1.Size = new System.Drawing.Size(54, 13);
			this.lbl_id_cliente1.TabIndex = 5;
			this.lbl_id_cliente1.Text = "N° Cliente";
			// 
			// frmSeccionMant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 172);
			this.Controls.Add(this.tbl_seccion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSeccionMant";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sección";
			this.tbl_seccion.ResumeLayout(false);
			this.tbl_seccion.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		  private System.Windows.Forms.GroupBox tbl_seccion;
		  private System.Windows.Forms.Label lbl_id_cliente1;
        private System.Windows.Forms.TextBox txt_seccion;
		  private System.Windows.Forms.Label lbl_seccion;
		  private System.Windows.Forms.Label lbl_id_secciondesc;
        private System.Windows.Forms.Button btn_cerrar;
		  private System.Windows.Forms.Button btn_Grabar;
          private System.Windows.Forms.ComboBox cbx_id_estado;
		  private System.Windows.Forms.Label lbl_id_estado;
								private System.Windows.Forms.Label lbl_id_cliente;
								private System.Windows.Forms.Label lbl_nombreCliente;
								private System.Windows.Forms.Label lbl_id_seccion;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}