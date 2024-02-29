namespace ControlDosimetro
{
    partial class frmSucursalMant
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
			this.tbl_sucursal = new System.Windows.Forms.GroupBox();
			this.btnCopiar = new System.Windows.Forms.Button();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.chk_CasaMatriz = new System.Windows.Forms.CheckBox();
			this.txt_runsuc = new System.Windows.Forms.TextBox();
			this.lbl_runsuc = new System.Windows.Forms.Label();
			this.lbl_id_Sucursal = new System.Windows.Forms.Label();
			this.cbx_id_estado = new System.Windows.Forms.ComboBox();
			this.lbl_id_estado = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbx_id_comuna = new System.Windows.Forms.ComboBox();
			this.cbx_id_provincia = new System.Windows.Forms.ComboBox();
			this.cbx_id_region = new System.Windows.Forms.ComboBox();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.btn_Grabar = new System.Windows.Forms.Button();
			this.txt_telefono = new System.Windows.Forms.TextBox();
			this.lbl_telefono = new System.Windows.Forms.Label();
			this.lbl_id_comuna = new System.Windows.Forms.Label();
			this.lbl_id_provincia = new System.Windows.Forms.Label();
			this.lbl_id_region = new System.Windows.Forms.Label();
			this.txt_direccion = new System.Windows.Forms.TextBox();
			this.lbl_direccion = new System.Windows.Forms.Label();
			this.txt_Razon_Social = new System.Windows.Forms.TextBox();
			this.lbl_Razon_Social = new System.Windows.Forms.Label();
			this.txt_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.txt_run = new System.Windows.Forms.TextBox();
			this.lbl_run = new System.Windows.Forms.Label();
			this.tbl_sucursal.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbl_sucursal
			// 
			this.tbl_sucursal.Controls.Add(this.btnCopiar);
			this.tbl_sucursal.Controls.Add(this.lbl_Email);
			this.tbl_sucursal.Controls.Add(this.txt_Email);
			this.tbl_sucursal.Controls.Add(this.chk_CasaMatriz);
			this.tbl_sucursal.Controls.Add(this.txt_runsuc);
			this.tbl_sucursal.Controls.Add(this.lbl_runsuc);
			this.tbl_sucursal.Controls.Add(this.lbl_id_Sucursal);
			this.tbl_sucursal.Controls.Add(this.cbx_id_estado);
			this.tbl_sucursal.Controls.Add(this.lbl_id_estado);
			this.tbl_sucursal.Controls.Add(this.label2);
			this.tbl_sucursal.Controls.Add(this.cbx_id_comuna);
			this.tbl_sucursal.Controls.Add(this.cbx_id_provincia);
			this.tbl_sucursal.Controls.Add(this.cbx_id_region);
			this.tbl_sucursal.Controls.Add(this.btn_cerrar);
			this.tbl_sucursal.Controls.Add(this.btn_Grabar);
			this.tbl_sucursal.Controls.Add(this.txt_telefono);
			this.tbl_sucursal.Controls.Add(this.lbl_telefono);
			this.tbl_sucursal.Controls.Add(this.lbl_id_comuna);
			this.tbl_sucursal.Controls.Add(this.lbl_id_provincia);
			this.tbl_sucursal.Controls.Add(this.lbl_id_region);
			this.tbl_sucursal.Controls.Add(this.txt_direccion);
			this.tbl_sucursal.Controls.Add(this.lbl_direccion);
			this.tbl_sucursal.Controls.Add(this.txt_Razon_Social);
			this.tbl_sucursal.Controls.Add(this.lbl_Razon_Social);
			this.tbl_sucursal.Controls.Add(this.txt_id_cliente);
			this.tbl_sucursal.Controls.Add(this.lbl_id_cliente);
			this.tbl_sucursal.Controls.Add(this.txt_run);
			this.tbl_sucursal.Controls.Add(this.lbl_run);
			this.tbl_sucursal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_sucursal.Location = new System.Drawing.Point(0, 0);
			this.tbl_sucursal.Name = "tbl_sucursal";
			this.tbl_sucursal.Size = new System.Drawing.Size(491, 477);
			this.tbl_sucursal.TabIndex = 0;
			this.tbl_sucursal.TabStop = false;
			this.tbl_sucursal.Text = "Datos";
			// 
			// btnCopiar
			// 
			this.btnCopiar.Image = global::ControlDosimetro.Properties.Resources.CopiarDatos;
			this.btnCopiar.Location = new System.Drawing.Point(438, 285);
			this.btnCopiar.Name = "btnCopiar";
			this.btnCopiar.Size = new System.Drawing.Size(47, 56);
			this.btnCopiar.TabIndex = 43;
			this.btnCopiar.UseVisualStyleBackColor = true;
			this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Location = new System.Drawing.Point(9, 258);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(32, 13);
			this.lbl_Email.TabIndex = 42;
			this.lbl_Email.Text = "Email";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(165, 255);
			this.txt_Email.MaxLength = 100;
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(303, 20);
			this.txt_Email.TabIndex = 10;
			// 
			// chk_CasaMatriz
			// 
			this.chk_CasaMatriz.AutoSize = true;
			this.chk_CasaMatriz.Location = new System.Drawing.Point(389, 21);
			this.chk_CasaMatriz.Name = "chk_CasaMatriz";
			this.chk_CasaMatriz.Size = new System.Drawing.Size(81, 17);
			this.chk_CasaMatriz.TabIndex = 32;
			this.chk_CasaMatriz.Text = "Casa Matriz";
			this.chk_CasaMatriz.UseVisualStyleBackColor = true;
			this.chk_CasaMatriz.CheckedChanged += new System.EventHandler(this.chk_CasaMatriz_CheckedChanged);
			// 
			// txt_runsuc
			// 
			this.txt_runsuc.Location = new System.Drawing.Point(167, 69);
			this.txt_runsuc.MaxLength = 10;
			this.txt_runsuc.Name = "txt_runsuc";
			this.txt_runsuc.Size = new System.Drawing.Size(120, 20);
			this.txt_runsuc.TabIndex = 31;
			// 
			// lbl_runsuc
			// 
			this.lbl_runsuc.AutoSize = true;
			this.lbl_runsuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_runsuc.Location = new System.Drawing.Point(11, 72);
			this.lbl_runsuc.Name = "lbl_runsuc";
			this.lbl_runsuc.Size = new System.Drawing.Size(68, 13);
			this.lbl_runsuc.TabIndex = 30;
			this.lbl_runsuc.Text = "Rut Sucursal";
			// 
			// lbl_id_Sucursal
			// 
			this.lbl_id_Sucursal.AutoSize = true;
			this.lbl_id_Sucursal.Location = new System.Drawing.Point(366, 232);
			this.lbl_id_Sucursal.Name = "lbl_id_Sucursal";
			this.lbl_id_Sucursal.Size = new System.Drawing.Size(35, 13);
			this.lbl_id_Sucursal.TabIndex = 29;
			this.lbl_id_Sucursal.Text = "label1";
			this.lbl_id_Sucursal.Visible = false;
			// 
			// cbx_id_estado
			// 
			this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_estado.FormattingEnabled = true;
			this.cbx_id_estado.Location = new System.Drawing.Point(165, 282);
			this.cbx_id_estado.Name = "cbx_id_estado";
			this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_estado.TabIndex = 11;
			// 
			// lbl_id_estado
			// 
			this.lbl_id_estado.AutoSize = true;
			this.lbl_id_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_estado.Location = new System.Drawing.Point(10, 285);
			this.lbl_id_estado.Name = "lbl_id_estado";
			this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
			this.lbl_id_estado.TabIndex = 28;
			this.lbl_id_estado.Text = "Estado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(293, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 27;
			this.label2.Text = "Formato: 12345678-9";
			// 
			// cbx_id_comuna
			// 
			this.cbx_id_comuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_comuna.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_comuna.FormattingEnabled = true;
			this.cbx_id_comuna.Location = new System.Drawing.Point(166, 203);
			this.cbx_id_comuna.Name = "cbx_id_comuna";
			this.cbx_id_comuna.Size = new System.Drawing.Size(303, 21);
			this.cbx_id_comuna.TabIndex = 23;
			this.cbx_id_comuna.TabStop = false;
			// 
			// cbx_id_provincia
			// 
			this.cbx_id_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_provincia.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_provincia.FormattingEnabled = true;
			this.cbx_id_provincia.Location = new System.Drawing.Point(166, 176);
			this.cbx_id_provincia.Name = "cbx_id_provincia";
			this.cbx_id_provincia.Size = new System.Drawing.Size(303, 21);
			this.cbx_id_provincia.TabIndex = 20;
			this.cbx_id_provincia.TabStop = false;
			this.cbx_id_provincia.SelectedIndexChanged += new System.EventHandler(this.cbx_id_provincia_SelectedIndexChanged);
			// 
			// cbx_id_region
			// 
			this.cbx_id_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_region.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_region.FormattingEnabled = true;
			this.cbx_id_region.Location = new System.Drawing.Point(166, 148);
			this.cbx_id_region.Name = "cbx_id_region";
			this.cbx_id_region.Size = new System.Drawing.Size(303, 21);
			this.cbx_id_region.TabIndex = 6;
			this.cbx_id_region.SelectedIndexChanged += new System.EventHandler(this.cbx_id_region_SelectedIndexChanged);
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.Location = new System.Drawing.Point(272, 415);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_cerrar.TabIndex = 13;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.UseVisualStyleBackColor = true;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Location = new System.Drawing.Point(85, 415);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
			this.btn_Grabar.TabIndex = 12;
			this.btn_Grabar.Text = "Guardar";
			this.btn_Grabar.UseVisualStyleBackColor = true;
			this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
			// 
			// txt_telefono
			// 
			this.txt_telefono.Location = new System.Drawing.Point(166, 229);
			this.txt_telefono.MaxLength = 15;
			this.txt_telefono.Name = "txt_telefono";
			this.txt_telefono.Size = new System.Drawing.Size(141, 20);
			this.txt_telefono.TabIndex = 9;
			// 
			// lbl_telefono
			// 
			this.lbl_telefono.AutoSize = true;
			this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_telefono.Location = new System.Drawing.Point(10, 232);
			this.lbl_telefono.Name = "lbl_telefono";
			this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
			this.lbl_telefono.TabIndex = 14;
			this.lbl_telefono.Text = "Telefono";
			// 
			// lbl_id_comuna
			// 
			this.lbl_id_comuna.AutoSize = true;
			this.lbl_id_comuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_comuna.Location = new System.Drawing.Point(10, 206);
			this.lbl_id_comuna.Name = "lbl_id_comuna";
			this.lbl_id_comuna.Size = new System.Drawing.Size(46, 13);
			this.lbl_id_comuna.TabIndex = 13;
			this.lbl_id_comuna.Text = "Comuna";
			// 
			// lbl_id_provincia
			// 
			this.lbl_id_provincia.AutoSize = true;
			this.lbl_id_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_provincia.Location = new System.Drawing.Point(10, 178);
			this.lbl_id_provincia.Name = "lbl_id_provincia";
			this.lbl_id_provincia.Size = new System.Drawing.Size(51, 13);
			this.lbl_id_provincia.TabIndex = 12;
			this.lbl_id_provincia.Text = "Provincia";
			// 
			// lbl_id_region
			// 
			this.lbl_id_region.AutoSize = true;
			this.lbl_id_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_region.Location = new System.Drawing.Point(10, 151);
			this.lbl_id_region.Name = "lbl_id_region";
			this.lbl_id_region.Size = new System.Drawing.Size(41, 13);
			this.lbl_id_region.TabIndex = 11;
			this.lbl_id_region.Text = "Región";
			// 
			// txt_direccion
			// 
			this.txt_direccion.Location = new System.Drawing.Point(166, 121);
			this.txt_direccion.MaxLength = 100;
			this.txt_direccion.Name = "txt_direccion";
			this.txt_direccion.Size = new System.Drawing.Size(313, 20);
			this.txt_direccion.TabIndex = 5;
			this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
			// 
			// lbl_direccion
			// 
			this.lbl_direccion.AutoSize = true;
			this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_direccion.Location = new System.Drawing.Point(10, 124);
			this.lbl_direccion.Name = "lbl_direccion";
			this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
			this.lbl_direccion.TabIndex = 9;
			this.lbl_direccion.Text = "Dirección";
			// 
			// txt_Razon_Social
			// 
			this.txt_Razon_Social.Location = new System.Drawing.Point(166, 95);
			this.txt_Razon_Social.MaxLength = 60;
			this.txt_Razon_Social.Name = "txt_Razon_Social";
			this.txt_Razon_Social.Size = new System.Drawing.Size(313, 20);
			this.txt_Razon_Social.TabIndex = 4;
			// 
			// lbl_Razon_Social
			// 
			this.lbl_Razon_Social.AutoSize = true;
			this.lbl_Razon_Social.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Razon_Social.Location = new System.Drawing.Point(10, 98);
			this.lbl_Razon_Social.Name = "lbl_Razon_Social";
			this.lbl_Razon_Social.Size = new System.Drawing.Size(70, 13);
			this.lbl_Razon_Social.TabIndex = 7;
			this.lbl_Razon_Social.Text = "Razon Social";
			// 
			// txt_id_cliente
			// 
			this.txt_id_cliente.Enabled = false;
			this.txt_id_cliente.Location = new System.Drawing.Point(167, 19);
			this.txt_id_cliente.MaxLength = 4;
			this.txt_id_cliente.Name = "txt_id_cliente";
			this.txt_id_cliente.Size = new System.Drawing.Size(75, 20);
			this.txt_id_cliente.TabIndex = 1;
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_id_cliente.Location = new System.Drawing.Point(11, 22);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(54, 13);
			this.lbl_id_cliente.TabIndex = 5;
			this.lbl_id_cliente.Text = "N° Cliente";
			// 
			// txt_run
			// 
			this.txt_run.Enabled = false;
			this.txt_run.Location = new System.Drawing.Point(167, 43);
			this.txt_run.MaxLength = 10;
			this.txt_run.Name = "txt_run";
			this.txt_run.Size = new System.Drawing.Size(120, 20);
			this.txt_run.TabIndex = 3;
			// 
			// lbl_run
			// 
			this.lbl_run.AutoSize = true;
			this.lbl_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_run.Location = new System.Drawing.Point(11, 46);
			this.lbl_run.Name = "lbl_run";
			this.lbl_run.Size = new System.Drawing.Size(58, 13);
			this.lbl_run.TabIndex = 0;
			this.lbl_run.Text = "Rut cliente";
			// 
			// frmSucursalMant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 477);
			this.Controls.Add(this.tbl_sucursal);
			this.Name = "frmSucursalMant";
			this.Text = "Dirección";
			this.tbl_sucursal.ResumeLayout(false);
			this.tbl_sucursal.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbl_sucursal;
        private System.Windows.Forms.TextBox txt_run;
        private System.Windows.Forms.Label lbl_run;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.TextBox txt_Razon_Social;
        private System.Windows.Forms.Label lbl_Razon_Social;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_id_comuna;
        private System.Windows.Forms.Label lbl_id_provincia;
        private System.Windows.Forms.Label lbl_id_region;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ComboBox cbx_id_comuna;
        private System.Windows.Forms.ComboBox cbx_id_provincia;
        private System.Windows.Forms.ComboBox cbx_id_region;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_id_estado;
        private System.Windows.Forms.Label lbl_id_estado;
        private System.Windows.Forms.Label lbl_id_Sucursal;
        private System.Windows.Forms.TextBox txt_runsuc;
        private System.Windows.Forms.Label lbl_runsuc;
        private System.Windows.Forms.CheckBox chk_CasaMatriz;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.Button btnCopiar;
	}
}