namespace ControlDosimetro
{
	partial class frmReferenciaMant
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
			this.tbl_encargado = new System.Windows.Forms.GroupBox();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_Id_Cliente = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbx_id_Estado = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.btn_Grabar = new System.Windows.Forms.Button();
			this.txt_Fono = new System.Windows.Forms.TextBox();
			this.lbl_Fono = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.txt_Encargado = new System.Windows.Forms.TextBox();
			this.lbl_Encargado = new System.Windows.Forms.Label();
			this.txt_id_referencia = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbl_encargado.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbl_encargado
			// 
			this.tbl_encargado.Controls.Add(this.lbl_nombre);
			this.tbl_encargado.Controls.Add(this.label2);
			this.tbl_encargado.Controls.Add(this.lbl_Id_Cliente);
			this.tbl_encargado.Controls.Add(this.label6);
			this.tbl_encargado.Controls.Add(this.cbx_id_Estado);
			this.tbl_encargado.Controls.Add(this.label1);
			this.tbl_encargado.Controls.Add(this.btn_cerrar);
			this.tbl_encargado.Controls.Add(this.btn_Grabar);
			this.tbl_encargado.Controls.Add(this.txt_Fono);
			this.tbl_encargado.Controls.Add(this.lbl_Fono);
			this.tbl_encargado.Controls.Add(this.txt_Email);
			this.tbl_encargado.Controls.Add(this.lbl_Email);
			this.tbl_encargado.Controls.Add(this.txt_Encargado);
			this.tbl_encargado.Controls.Add(this.lbl_Encargado);
			this.tbl_encargado.Controls.Add(this.txt_id_referencia);
			this.tbl_encargado.Controls.Add(this.label4);
			this.tbl_encargado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_encargado.Location = new System.Drawing.Point(0, 0);
			this.tbl_encargado.Name = "tbl_encargado";
			this.tbl_encargado.Size = new System.Drawing.Size(493, 228);
			this.tbl_encargado.TabIndex = 0;
			this.tbl_encargado.TabStop = false;
			this.tbl_encargado.Text = "Datos";
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
			// lbl_Id_Cliente
			// 
			this.lbl_Id_Cliente.AutoSize = true;
			this.lbl_Id_Cliente.Location = new System.Drawing.Point(162, 16);
			this.lbl_Id_Cliente.Name = "lbl_Id_Cliente";
			this.lbl_Id_Cliente.Size = new System.Drawing.Size(10, 13);
			this.lbl_Id_Cliente.TabIndex = 23;
			this.lbl_Id_Cliente.Text = "-";
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
			// cbx_id_Estado
			// 
			this.cbx_id_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_Estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_Estado.FormattingEnabled = true;
			this.cbx_id_Estado.Location = new System.Drawing.Point(167, 149);
			this.cbx_id_Estado.Name = "cbx_id_Estado";
			this.cbx_id_Estado.Size = new System.Drawing.Size(141, 21);
			this.cbx_id_Estado.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Estado";
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.Location = new System.Drawing.Point(234, 184);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_cerrar.TabIndex = 18;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.UseVisualStyleBackColor = true;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Location = new System.Drawing.Point(94, 184);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
			this.btn_Grabar.TabIndex = 5;
			this.btn_Grabar.Text = "Guardar";
			this.btn_Grabar.UseVisualStyleBackColor = true;
			this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
			// 
			// txt_Fono
			// 
			this.txt_Fono.Location = new System.Drawing.Point(167, 123);
			this.txt_Fono.MaxLength = 15;
			this.txt_Fono.Name = "txt_Fono";
			this.txt_Fono.Size = new System.Drawing.Size(141, 20);
			this.txt_Fono.TabIndex = 3;
			// 
			// lbl_Fono
			// 
			this.lbl_Fono.AutoSize = true;
			this.lbl_Fono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Fono.Location = new System.Drawing.Point(11, 126);
			this.lbl_Fono.Name = "lbl_Fono";
			this.lbl_Fono.Size = new System.Drawing.Size(49, 13);
			this.lbl_Fono.TabIndex = 14;
			this.lbl_Fono.Text = "Telefono";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(167, 97);
			this.txt_Email.MaxLength = 100;
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(313, 20);
			this.txt_Email.TabIndex = 2;
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Email.Location = new System.Drawing.Point(11, 100);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(32, 13);
			this.lbl_Email.TabIndex = 9;
			this.lbl_Email.Text = "Email";
			// 
			// txt_Encargado
			// 
			this.txt_Encargado.Location = new System.Drawing.Point(167, 71);
			this.txt_Encargado.MaxLength = 60;
			this.txt_Encargado.Name = "txt_Encargado";
			this.txt_Encargado.Size = new System.Drawing.Size(313, 20);
			this.txt_Encargado.TabIndex = 1;
			// 
			// lbl_Encargado
			// 
			this.lbl_Encargado.AutoSize = true;
			this.lbl_Encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Encargado.Location = new System.Drawing.Point(11, 74);
			this.lbl_Encargado.Name = "lbl_Encargado";
			this.lbl_Encargado.Size = new System.Drawing.Size(59, 13);
			this.lbl_Encargado.TabIndex = 7;
			this.lbl_Encargado.Text = "Encargado";
			// 
			// txt_id_referencia
			// 
			this.txt_id_referencia.Enabled = false;
			this.txt_id_referencia.Location = new System.Drawing.Point(167, 45);
			this.txt_id_referencia.MaxLength = 4;
			this.txt_id_referencia.Name = "txt_id_referencia";
			this.txt_id_referencia.ReadOnly = true;
			this.txt_id_referencia.Size = new System.Drawing.Size(75, 20);
			this.txt_id_referencia.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Cód. Referencia";
			// 
			// frmReferenciaMant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 228);
			this.Controls.Add(this.tbl_encargado);
			this.Name = "frmReferenciaMant";
			this.Text = "Referencia";
			this.tbl_encargado.ResumeLayout(false);
			this.tbl_encargado.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbl_encargado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_referencia;
        private System.Windows.Forms.TextBox txt_Encargado;
        private System.Windows.Forms.Label lbl_Encargado;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Fono;
        private System.Windows.Forms.Label lbl_Fono;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ComboBox cbx_id_Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Id_Cliente;
        private System.Windows.Forms.Label label6;
    }
}